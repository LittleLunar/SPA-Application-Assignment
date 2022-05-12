using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace spa_backend.Controllers
{
  [ApiController]
  [Route("/")]
  public class HomeController : ControllerBase
  {
    [AllowAnonymous]
    [HttpGet]
    public IActionResult Index()
    {
      return Ok(new { message = "Welcome." });
    }

  }
}
