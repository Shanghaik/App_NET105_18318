using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestAPIWeb.Models;

namespace TestAPIWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CalculateBMI(double height = 0, double weight = 0)
        {
            if (height == 0 && weight == 0) ViewData["result"] = "Bạn chưa nhập gì cả";
            else
            {
                // Viết đoạn code call API
                // Bước 1: Lấy đường dẫn API (APIUrl) với các tham số tương ứng nếu có
                string requestURL = @$"https://localhost:7002/get-bmi?weight={weight}&height={height}";
                // Bước 2: Từ API Url => Lấy ra response body
                HttpClient client = new HttpClient();
                var response = client.GetStringAsync(requestURL).Result;
                // Bước 3: Đưa dữ liệu lấy được về dạng mà chúng ta cần
                ViewData["result"] = response;
            }
            return View();
        }
    }
}