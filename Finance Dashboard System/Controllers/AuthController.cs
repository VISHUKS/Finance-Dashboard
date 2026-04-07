using Finance_Dashboard_System.Interfaces;
using Finance_Dashboard_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Finance_Dashboard_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;
        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }
        [HttpPost("login")]
        public string Login([FromBody] LoginRequest obj)
        {
            var token = _auth.Login(obj);
            return token;
        }
    }
}
