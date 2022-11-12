using Microsoft.AspNetCore.Mvc;
using Week3.Domain.Entities;
using Week3.Services.Abstract;

namespace Week3.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var productList = _productService.GetAll();
            return Ok(productList);
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromQuery]int id)
        {
            var product = _productService.GetById(id);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Add(Product entity)
        {
            _productService.Add(entity);
            return Ok();
        }
    }
}
