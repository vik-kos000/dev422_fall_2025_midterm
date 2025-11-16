using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace EventManagementAndTicketingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public required List<User> _users;
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (string.IsNullOrEmpty(user.Name)|| 
                string.IsNullOrEmpty(user.Password)||
                (string.IsNullOrEmpty(user.Email))||
                (string.IsNullOrEmpty(user.Role)))
            {
                return BadRequest("Either Name, Password, Email, or Role are required for registration");
            }
            if (_users.Any(x => x.Name == user.Name))
            {
                return BadRequest("Name already exist");
            }
            if (_users.Any(x => x.Email == user.Email))
            {
                return BadRequest("Email already exist");
            }
            if (user.Role != "User" && user.Role != "Admin" && user.Role != "Event Manager") 
            {
                return Unauthorized("User's Role must be: User, Admin, or Event Manager");
            }
            user.Password = Hashpassword(user.Password);
            user.userid += _users.Count;
            _users.Add(user);

            return Ok(new { Message = "Registration Successful" });
        }
        private string Hashpassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {

                var hashedbytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                return Convert.ToBase64String(hashedbytes);
            }
        }
        public List<User> Getlistuser()
        {
            return _users;
        }
    }
}
