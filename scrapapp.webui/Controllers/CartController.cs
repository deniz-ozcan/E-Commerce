using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using scrapapp.business.Abstract;
using scrapapp.entity;
using scrapapp.webui.Identity;
using scrapapp.webui.Models;

namespace scrapapp.webui.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private ICartService _cartService;
        private IOrderService _orderService;
        private UserManager<User> _userManager;
        public CartController(IOrderService orderService, ICartService cartService, UserManager<User> userManager)
        {
            _cartService = cartService;
            _orderService = orderService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));
            return View(new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.ProductId,
                    Name = i.Product.Detail.Name,
                    Price = (double)i.Product.Price,
                    ImageUrl = i.Product.Detail.Image,
                    Quantity = i.Quantity
                }).ToList()
            });
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int quantity)
        {
            _cartService.AddToCart(_userManager.GetUserId(User), productId, quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteFromCart(int productId)
        {
            var userId = _userManager.GetUserId(User);
            _cartService.DeleteFromCart(userId, productId);
            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));

            var orderModel = new OrderModel();

            orderModel.CartModel = new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.ProductId,
                    Name = i.Product.Detail.Name,
                    Price = (double)i.Product.Price,
                    ImageUrl = i.Product.Detail.Image,
                    Quantity = i.Quantity
                }).ToList()
            };
            return View(orderModel);
        }

        [HttpPost]
        public IActionResult Checkout(OrderModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                var cart = _cartService.GetCartByUserId(userId);
                model.CartModel = new CartModel()
                {
                    CartId = cart.Id,
                    CartItems = cart.CartItems.Select(i => new CartItemModel()
                    {
                        CartItemId = i.Id,
                        ProductId = i.ProductId,
                        Name = i.Product.Detail.Name,
                        Price = (double)i.Product.Price,
                        ImageUrl = i.Product.Detail.Image,
                        Quantity = i.Quantity
                    }).ToList()
                };
                SaveOrder(model, PaymentProcess(model), userId);
                ClearCart(model.CartModel.CartId);
                return View();
            }
            return View(model);
        }

        public IActionResult GetOrders()
        {
            var userId = _userManager.GetUserId(User);
            var orders = _orderService.GetOrders(userId);
            var orderListModel = new List<OrderListModel>();
            OrderListModel orderModel;
            foreach (var order in orders)
            {
                orderModel = new OrderListModel();

                orderModel.OrderId = order.Id;
                orderModel.OrderNumber = order.OrderNumber;
                orderModel.OrderDate = order.OrderDate;
                orderModel.Phone = order.Phone;
                orderModel.FirstName = order.FirstName;
                orderModel.LastName = order.LastName;
                orderModel.Email = order.Email;
                orderModel.Address = order.Address;
                orderModel.City = order.City;
                orderModel.OrderState = order.OrderState;
                orderModel.PaymentType = order.PaymentType;

                orderModel.OrderItems = order.OrderItems.Select(i => new OrderItemModel()
                {
                    OrderItemId = i.Id,
                    Name = i.Product.Detail.Name,
                    Price = (double)i.Price,
                    Quantity = i.Quantity,
                    ImageUrl = i.Product.Detail.Image
                }).ToList();

                orderListModel.Add(orderModel);
            }


            return View("Orders", orderListModel);
        }

        private void ClearCart(int cartId)
        {
            _cartService.ClearCart(cartId);
        }

        private void SaveOrder(OrderModel model, Payment payment, string userId)
        {
            var order = new Order();

            order.OrderNumber = new Random().Next(111111, 999999).ToString();
            order.OrderState = EnumOrderState.completed;
            order.PaymentType = EnumPaymentType.CreditCard;
            order.PaymentId = payment.PaymentId;
            order.ConversationId = payment.ConversationId;
            order.OrderDate = new DateTime();
            order.FirstName = model.FirstName;
            order.LastName = model.LastName;
            order.UserId = userId;
            order.Address = model.Address;
            order.Phone = model.Phone;
            order.Email = model.Email;
            order.City = model.City;
            order.Note = model.Note;

            order.OrderItems = new List<entity.OrderItem>();

            foreach (var item in model.CartModel.CartItems)
            {
                var orderItem = new scrapapp.entity.OrderItem()
                {
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ProductId = item.ProductId
                };
                order.OrderItems.Add(orderItem);
            }
            _orderService.Create(order);
        }

        private Payment PaymentProcess(OrderModel model)
        {
            var payment = new Payment
            {
                PaymentId = new Random().Next(111111, 999999).ToString(),
                ConversationId = new Random().Next(111111, 999999).ToString(),
                Status = "success",
            };
            return payment;
        }
    }
}