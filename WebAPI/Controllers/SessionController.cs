using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using spa_backend.Models;
using spa_backend.Services;
namespace spa_backend.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class SessionController : ControllerBase
  {
    private readonly DBService _mongo;
    public SessionController(DBService mongo)
    {
      _mongo = mongo;
    }

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
