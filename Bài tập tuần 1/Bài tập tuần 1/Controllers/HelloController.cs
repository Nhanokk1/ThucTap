using Microsoft.AspNetCore.Mvc;

namespace Bài_tập_tuần_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
