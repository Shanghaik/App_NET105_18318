using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracticeController : ControllerBase
    {
        [HttpGet("triangle-check")]
        public ActionResult<string> CheckTriangleEdge(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return BadRequest("These negative length edges are not the length of a triangle!!!");
            }
            else
            {
                if (a < b + c && a > Math.Abs(b - c))
                {
                    return Ok("These edges are the length of a triangle!!!");
                }
                else return NotFound("These edges are not the length of a triangle!!!");
            }
        }
        // Viết 1 API trả về danh sách 1 List Fake Kiểu Human (string Name, string CCCD, int Age)
        [HttpGet("get-list-human")]
        public List<Human> GetListHuman()
        {
            var fakeList = new List<Human>()
            {
                new Human(){Name = "Khánh", CCCD = "001980076450", Age = 21},
                new Human(){Name = "Dũng", CCCD = "001980476450", Age = 40},
                new Human(){Name = "Hằng", CCCD = "001180076450", Age = 27},
                new Human(){Name = "Ngân", CCCD = "001944076450", Age = 39}
            };
            return fakeList;
        }
    }
    public class Human
    {
        public string Name { get; set; }
        public string CCCD { get; set; }
        public int Age { get; set; }
    }
}
