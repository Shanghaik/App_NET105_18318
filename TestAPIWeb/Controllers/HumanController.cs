using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace TestAPIWeb.Controllers
{
    public class HumanController : Controller
    {
        public IActionResult Index()
        {
            string urlRequest = @"https://localhost:7002/api/Practice/get-list-human";
            var response = new HttpClient().GetStringAsync(urlRequest).Result;
            List<Human> result = JsonConvert.DeserializeObject<List<Human>>(response);
            return View(result);
        }
    }
    public class Human
    {
        public string Name { get; set; }
        public string CCCD { get; set; }
        public int Age { get; set; }
    }
}
