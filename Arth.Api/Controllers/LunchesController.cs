using Microsoft.AspNetCore.Mvc;

namespace Arth.Api.Controllers
{
    [Route("[controller]")]
    public class LunchesController : ApiController
    {
        [HttpGet]
        public IActionResult ListLunches()
        {
            return Ok(Array.Empty<string>());
        }
    }
}
