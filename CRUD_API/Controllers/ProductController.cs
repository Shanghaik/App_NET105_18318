using CRUD_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_API.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductController : ControllerBase
    {
        AppDbContext _context = new AppDbContext();
        [HttpGet("get-all-product")]
        public ActionResult GetAll()
        {
            return Ok(_context.Products.ToList());
        }
        [HttpGet("get-by-id")]
        public ActionResult GetAll(string id)
        {
            return Ok(_context.Products.Find(id));
        }
        [HttpPost("create-product")]
        public ActionResult CreateProduct(Product product) {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return Ok();    
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("update-product")]
        public ActionResult UpdateProduct(Product product)
        {
            try
            {
                var updateItem = _context.Products.Find(product.Id);
                updateItem.Name = product.Name;
                updateItem.Description = product.Description; // Còn vài thuộc tính nữa bỏ =))
                _context.Products.Update(updateItem);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("delete-product")]
        public ActionResult DeleteProduct(string id)
        {
            try
            {
                var deleteItem = _context.Products.Find(id);
                _context.Products.Remove(deleteItem);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
