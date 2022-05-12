using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using spa_backend.Models;
using spa_backend.Services;

namespace spa_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ContentController : ControllerBase
    {
        private readonly DBService _mongo;
        public ContentController(DBService mongo)
        {
            _mongo = mongo;
        }

        
        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> Contents()
        {
            return Ok();
        }
    }
}
