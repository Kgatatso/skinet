using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;

        }

        [HttpGet]

        public async Task<ActionResult<List<Product>>> getProducts()
        {
           var products = await _context.Products.ToListAsync();
           return Ok(products);
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Product>> getProduct(int id) => await _context.Products.FindAsync(id);

    }
}