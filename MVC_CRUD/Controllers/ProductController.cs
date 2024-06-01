using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.IServices;
using MVC_CRUD.Models;
using MVC_CRUD.Services;

namespace MVC_CRUD.Controllers
{
    public class ProductController : Controller
    {
        IProductServices _services;
        public ProductController()
        {
            _services = new ProductServices();
        }
        public IActionResult GetAll()
        {
            List<Product> products = _services.GetAll();
            return View(products);
        }
    }
}
