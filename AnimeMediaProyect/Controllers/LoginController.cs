using Microsoft.AspNetCore.Mvc;

namespace AnimeMediaProyect.Controllers
{
    [ApiController]
    [Route("api/")]
    public class LoginController : ControllerBase
    {

        [HttpPost("Login")]
        public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginRequest user)
        {
            var function = new LoginServices();
            var loginResponse = await function.Authentication(user);
            if(loginResponse.ResponseStatus == 1){               
             return Ok(loginResponse);

            }

            return Ok(new {loginResponse.ResponseMessage});
        }
    }

}