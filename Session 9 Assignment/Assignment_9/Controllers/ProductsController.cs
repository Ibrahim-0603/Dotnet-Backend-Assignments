using Assignment_9.Models;
using Assignment_9.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_9.Controllers
{
      [ApiController]
      [Route("api/[controller]")]

      public class ProductsController : ControllerBase
      {
            private readonly IProductsService _productsService;
            public ProductsController(IProductsService productsService)
            {
                  _productsService = productsService;
            }
            [HttpGet]
            public ActionResult<IEnumerable<Product>> GetProducts()
            {
                  var products = _productsService.GetProducts();
                  return Ok(products);
            }

            [HttpGet("{id}")]
            public ActionResult<Product> GetProductById(string id)
            {
                  var product = _productsService.GetProductById(id);
                  if (product == null)
                  {
                        return NotFound();
                  }
                  return Ok(product);
            }

            [HttpPost]
            public ActionResult<Product> createProduct([FromBody] Product product)
            {
                  var productId = _productsService.createProduct(product);
                  return CreatedAtAction(nameof(GetProductById), new { id = productId }, product);
            }

            [HttpPut("{id}")]
            public IActionResult updateProduct(string id, Product updatedProduct)
            {
                  var productId = _productsService.updateProduct(id, updatedProduct);
                  if (productId == null)
                  {
                        return NotFound();
                  }
                  return Ok(updatedProduct);
            }

            [HttpDelete("{id}")]
            public IActionResult deleteProduct(string id)
            {
                  var productId = _productsService.deleteProduct(id);
                  if (productId == null)
                  {
                        return NotFound();
                  }
                  return NoContent();
            }
      }
}