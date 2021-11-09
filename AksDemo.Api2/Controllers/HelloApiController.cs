using Microsoft.AspNetCore.Mvc;

namespace AksDemo.Api2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get(string name) => $"Hello {name}, this is API 2";
    }
}
