using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
namespace EventManagementAndTicketingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private string _secretKey="";
        public required List<User> _users;
        private string tokenstring="";
        public AuthController()
        {

        }
        public AuthController(IConfiguration configuration)
        {
            _secretKey = configuration["Jwt:SecretKey"];
        }

        [HttpPost("login")]
        public IActionResult Login(User userLogin)
        {
            _secretKey = "ThisIsAVeryLongSecretKeyThatIsAtLeast32BytesLong123";
            var user = _users.FirstOrDefault(x => x.Name == userLogin.Name);
            var email = _users.FirstOrDefault(x => x.Email == userLogin.Email);
            var role = _users.FirstOrDefault(x => x.Role == userLogin.Role);
            if (user == null || 
                email == null || 
                role == null || 
                !VerifyPassword(userLogin.Password, user.Password))
            {
                return Unauthorized("Invalid credentials!");
            }
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Role),
                    new Claim(ClaimTypes.NameIdentifier, Convert.ToString(user.userid))
                }),
                Expires = DateTime.UtcNow.AddHours(1),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            var tokenString = tokenHandler.WriteToken(token);
            tokenstring = tokenString.ToString();
            return Ok(new { Message = tokenString });

        }
        private bool VerifyPassword(string password, string hashedPassword)
        {
            var hashedInput = Hashpassword(password);

            return hashedInput == hashedPassword;
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
        public string GetTokenString()
        {
            if (tokenstring.ToString()!="")
            {
                return tokenstring.ToString();
            }
            return "";
        }
    }
}
