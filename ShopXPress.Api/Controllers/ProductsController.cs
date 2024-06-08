using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopXPress.Api.Contracts;
using ShopXPress.Api.Controller;
using ShopXPress.Api.Services.Interfaces;

namespace ShopXPress.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : AuthorizedControllerBase
    {

        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [AllowAnonymous]
        [HttpGet("TopList")]
        public async Task<List<ProductContract>> GetTopListProducts()
        {
            return await _productService.GetTopListProducts(10);
        }

        [HttpGet]
        public async Task<List<ProductContract>> GetProducts()
        {
            return await _productService.GetProducts();
        }

        [HttpGet("{productId}")]
        public async Task<ProductContract> GetProductById([FromRoute] int productId)
        {
            return await _productService.GetProductById(productId);
        }

        [HttpPost("CreateProduct")]
        public async Task CreateProduct([FromBody] ProductContract product)
        {
            await _productService.CreateProduct(product);
        }

        [HttpPut("UpdateProduct/{productId}")]
        public async Task UpdateProduct([FromRoute] int productId, [FromBody] ProductContract product)
        {
            await _productService.UpdateProduct(productId, product);
        }

        [HttpDelete("DeleteProduct/{productId}")]
        public async Task DeleteProduct([FromRoute] int productId)
        {
            await _productService.DeleteProduct(productId);
        }
    }
}
