using BasicAuthentication.DTO_s;
using BasicAuthentication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserContext u;
        public UserController(UserContext u) {
            this.u = u;
        }

        [HttpPost("Register")]
        public IActionResult UserRegistration(UserDTO user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var obj = u.Users.FirstOrDefault(u => u.Email == user.Email);
            if (obj != null)
            {
                return BadRequest();
            }
            else
            {
                u.Add(new User { Firstname = user.Firstname, Lastname = user.Lastname, Email = user.Email, Password = user.Password });
                u.SaveChanges();
                return Ok();
            }

        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDTO login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = u.Users.FirstOrDefault(u => u.Email == login.Email && u.Password==login.Password && u.isActive==true);
            if (user != null)
            {
                return Ok();
            }
            return NotFound();
        }


    }
}
