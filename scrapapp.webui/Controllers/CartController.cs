using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
                    Brand = i.Product.Brand,
                    Model = i.Product.Model,
                    Price = i.Product.Price,
                    ImageUrl = i.Product.Image,
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
            var orderModel = new OrderModel
            {
                CartModel = new CartModel()
                {
                    CartId = cart.Id,
                    CartItems = cart.CartItems.Select(i => new CartItemModel()
                    {
                        CartItemId = i.Id,
                        ProductId = i.ProductId,
                        Brand = i.Product.Brand,
                        Price = i.Product.Price,
                        ImageUrl = i.Product.Image,
                        Quantity = i.Quantity
                    }).ToList()
                }
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
                        Brand = i.Product.Brand,
                        Price = i.Product.Price,
                        ImageUrl = i.Product.Image,
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
            string userId = _userManager.GetUserId(User);
            List<Order> orders = _orderService.GetOrders(userId);
            List<OrderListModel> orderListModel = new();
            OrderListModel orderModel;
            foreach (var order in orders)
            {
                orderModel = new OrderListModel
                {
                    OrderId = order.Id,
                    OrderNumber = order.OrderNumber,
                    OrderDate = order.OrderDate,
                    Phone = order.Phone,
                    FirstName = order.FirstName,
                    LastName = order.LastName,
                    Email = order.Email,
                    Address = order.Address,
                    City = order.City,
                    OrderState = order.OrderState,
                    PaymentType = order.PaymentType,
                    OrderItems = order.OrderItems.Select(i => new OrderItemModel()
                    {
                        OrderItemId = i.Id,
                        Name = i.Product.Brand,
                        Price = i.Price,
                        Quantity = i.Quantity,
                        ImageUrl = i.Product.Image
                    }).ToList()
                };
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
            Order order = new()
            {
                OrderNumber = new Random().Next(111111, 999999).ToString(),
                OrderState = EnumOrderState.Completed,
                PaymentType = EnumPaymentType.CreditCard,
                PaymentId = payment.PaymentId,
                ConversationId = payment.ConversationId,
                OrderDate = new DateTime(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserId = userId,
                Address = model.Address,
                Phone = model.Phone,
                Email = model.Email,
                City = model.City,
                Note = model.Note,
                OrderItems = new List<OrderItem>()
            };

            foreach (var item in model.CartModel.CartItems)
            {
                var orderItem = new OrderItem()
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