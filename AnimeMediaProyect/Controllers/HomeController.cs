using Microsoft.AspNetCore.Mvc;

namespace AnimeMediaProyect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "First Controller";
        }
    }
}
