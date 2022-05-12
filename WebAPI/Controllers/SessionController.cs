using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using spa_backend.Models;
namespace spa_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionController : ControllerBase
    {
        public SessionController() { }

        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest body)
        {
            return Ok(body);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest body)
        {
            return Ok(body);
        }

    }
}
