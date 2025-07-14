using Microsoft.AspNetCore.Mvc;

namespace Blog.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "API funcionando!" });
        }
    }
}