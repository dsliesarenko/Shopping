using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Models;
using Shopping.Client.Data;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _context;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, ProductContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            var products = await _context.Products.Find(p => true).ToListAsync();
            return products;
        }
    }
}
