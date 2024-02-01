using Microsoft.AspNetCore.Mvc;

namespace AnimeMediaProyect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet("GetUsers")]
        public List<User> Index()
        {
            var query = "SELECT Nombre, Apellido, usuario FROM Usuarios";
              var user =  DatabaseConnection.SentQuery(query);
            return user;
        }
    }
}
