using Microsoft.AspNetCore.Mvc;
using Product_Crud_ebAPI.Models;
using Product_Crud_ebAPI.Services;

namespace Product_Crud_ebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
       
        
            private readonly IProductService _service;

            public ProductController(IProductService service)
            {
                _service = service;
            }

            [HttpGet]
            public IActionResult GetAll()
            {
                var products = _service.GetAll();
                return Ok(products);
            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                var product = _service.GetById(id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }

            [HttpPost]
            public IActionResult Create(Product product)
            {
                _service.Add(product);
                return Ok();
            }

            [HttpPut("{id}")]
            public IActionResult Update(int id, Product product)
            {
                var existing = _service.GetById(id);
                if (existing == null)
                {
                    return NotFound();
                }

                product.Id = id;
                _service.Update(product);
                return Ok();
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var existing = _service.GetById(id);
                if (existing == null)
                {
                    return NotFound();
                }

                _service.Delete(id);
                return Ok();
            }
        }
    }

