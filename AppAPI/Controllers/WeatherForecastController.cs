using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [ApiController]
    //[Route("app-like")] // bỏ đi chả sao cả - nó chỉ định danh chung cho các api cùng controller
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get-weather")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 9).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("get-random-number")]
        public int[] GetRandomIntegerArray(int size) // Random 1 mảng có size số từ 0 đến size
        {
            int[] arr = new int[size]; // Khởi tạo mảng
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = r.Next(size); // random mỗi phần tử 1 giá trị trong khoảng 0-size
            }
            return arr;
        }
        // Viết API tính Chỉ số BMI truyền vào các tham số: double cân nặng, double chiều cao
        // theo công thức BMI = cân_nặng/ chiều_cao^2
        [HttpGet("get-bmi")]
        public string GetBMI(double weight, double height) // Random 1 mảng có size số từ 0 đến size
        {
            double result = weight / (height * height);
            return $"Chỉ số BMI của bạn là: {Math.Round(result, 2)}";
        }
    }
}