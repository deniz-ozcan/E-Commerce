using System;
using Microsoft.AspNetCore.Mvc;
using scrapapp.business.Abstract;
using System.Threading.Tasks;
using scrapapp.entity;
using System.Collections.Generic;
using scrapapp.webapi.DTO;

namespace scrapapp.webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetAll();

            var productsDTO = new List<ProductDTO>();

            foreach (var p in products)
            {
                productsDTO.Add(ProductToDTO(p));
            }

            return Ok(productsDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(string slug)
        {
            var p = await _productService.GetBySlug(slug);
            if (p == null)
            {
                return NotFound(); // 404
            }
            return Ok(ProductToDTO(p)); // 200
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product entity)
        {
            await _productService.CreateAsync(entity);
            return CreatedAtAction(nameof(GetProduct), new { id = entity.ProductId }, ProductToDTO(entity));
        }

        // localhost:5000/api/products/2
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(string slug, Product entity)
        {
            if (slug.Equals(entity.Detail.Slug)==false)
            {
                return BadRequest();
            }

            var product = await _productService.GetBySlug(slug);

            if (product == null)
            {
                return NotFound();
            }

            await _productService.UpdateAsync(product, entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(string slug)
        {
            var product = await _productService.GetBySlug(slug);

            if (product == null)
            {
                return NotFound();
            }

            await _productService.DeleteAsync(product);
            return NoContent();
        }

        private static ProductDTO ProductToDTO(Product p)
        {
            return new ProductDTO
            {
                ProductId = p.ProductId,
                Name = p.Detail.Name,
                Price = p.Price,
                Url = p.Detail.Image,
            };
        }
    }
}