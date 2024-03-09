using Microsoft.AspNetCore.Mvc;

namespace AnimeMediaProyect.Controllers
{
    [ApiController]
    [Route("api/Content")]
    public class CarruselController : ControllerBase
    {

        [HttpGet("GetCarrusel")]
        public ActionResult<List<CarruselList>> ListCarrusel()
        {
            var function = new CarruselServices();
            var response = function.GetCarrusel();

            return StatusCode(200 , response);
        }
    }

}