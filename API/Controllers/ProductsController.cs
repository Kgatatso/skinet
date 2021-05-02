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
        private readonly iproductRepository _repo;
        
        public ProductsController(iproductRepository repo)
        {
            _repo = repo;
         

        }

        [HttpGet]

        public async Task<ActionResult<List<Product>>> getProducts()
        {
           var products = await _repo.getProductsAsync();
           return Ok(products);
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Product>> getProduct(int id)
        {
          await _repo.getProductByIdAsync(id);

        }
    }
} 