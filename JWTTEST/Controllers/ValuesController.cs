using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTTEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            var userName = User.Claims.FirstOrDefault(x => x.Type == "name")?.Value;
            return Ok(new { Message = $"Hello {userName}, this is a protected endpoint!" });
        }
    }
}
