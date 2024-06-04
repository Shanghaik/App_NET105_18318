using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.IServices;
using MVC_CRUD.Models;
using MVC_CRUD.Services;

namespace MVC_CRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _services;
        public ProductController(IProductServices services)
        {
            // _services = new ProductServices(); // Chủ động tạo ra đối tượng cho services
            _services = services; // Sử dụng DI (Dependency Injection để truyền phụ thuộc)
        }
        // class A kế thừa class B => A phụ thuộc B khi cần gọi ra instance
        // khi class A kế thừa interface B => thì B lại phụ thuộc ngược vào A vì B cần được 
        // làm rõ thông qua A và để tạo instance thì cần có constructor của A
        public IActionResult GetAll()
        {
            List<Product> products = _services.GetAll();
            return View(products);
        }
        public IActionResult Details(string id)
        {
            var product = _services.GetById(id);
            return View(product);
        }
        public IActionResult Create() // Action tạo form
        {
            var Product = new Product()
            {
                Name = "Dữ liệu phếch",
                Price = new Random().Next(1000000),
                Quantity = 100
            };
            return View(Product);
        }
        [HttpPost]
        public IActionResult Create(Product p) // Action tạo đối tượng và lưu vào DB
        {
            _services.CreateProduct(p);
            return RedirectToAction("GetAll");
        }
        public ActionResult Edit(string id)
        {
            var product = _services.GetById(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            _services.UpdateProduct(p);
            return RedirectToAction("GetAll");
        }
        public ActionResult Delete(string id)
        {
            _services.DeleteProduct(id);
            return RedirectToAction("GetAll");
        }

    }
}
