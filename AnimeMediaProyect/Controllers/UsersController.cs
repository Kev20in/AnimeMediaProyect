using Microsoft.AspNetCore.Mvc;

namespace AnimeMediaProyect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet("GetUsers")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var function = new UserServices();
            var userList =  await function.GetUsers();
            return userList;
        }  
        [HttpGet("GetUserByName")]
        public async Task<ActionResult<User>> GetUserByName(string name)
        {
            var function = new UserServices();
            var userData =  await function.GetUserByName(name);
            return userData;
        }  
        [HttpGet("GetUserById/{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var function = new UserServices();
            var userData =  await function.GetUserById(id);
            return userData;
        }  
        [HttpPost("AddNewUser")]
        public async Task<ActionResult<User>> AddNewUser([FromBody] Register newUser)
        {
            var function = new UserServices();
            var userData =  await function.AddUser(newUser);
            return userData;
        }  
        [HttpPut("UpdateUser")]
        public async Task<ActionResult<User>> UpdateUser([FromBody] User userData)
        {
            var function = new UserServices();
            var newUserData =  await function.UpdateUser(userData);
            return Ok(newUserData); 
            

        }  
        [HttpDelete("DeleteUser/{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            try{
            var function = new UserServices();
            var userData =  await function.GetUserById(id);
            var userDeleted =  await function.DeleteUser(userData);

            var deleted = new{
                message = "Usuario Eliminado",
                userDeleted
            };
            return Ok(deleted); 

            }
            catch(Exception ex){
                return StatusCode(500, ex);
            }
        }  
    }
}
  