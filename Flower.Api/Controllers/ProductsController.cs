using Flower.Application.Products.Dtos;
using Flower.Application.Products.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Flower.Api.Controllers
{
    [ApiController]
    [Route("api/products")] // 🔴 küçük harf, sabit
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlowerProductDto>>> GetAll()
        {
            var products = await _service.GetAllAsync();
            return Ok(products);
        }

        // GET: api/products/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<FlowerProductDto>> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);
            if (product is null) return NotFound();
            return Ok(product);
        }
    }
}
