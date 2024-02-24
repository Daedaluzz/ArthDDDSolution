using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Arth.Api.Controllers
{
    [Route("[controller]")]
    public class LunchController : ApiController
    {
        [HttpGet]
        public IActionResult ListLunches()
        {
            return Ok(Array.Empty<string>());
        }
    }
}
