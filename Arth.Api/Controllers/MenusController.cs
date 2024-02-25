using Arth.Contracts.Menus;

using Microsoft.AspNetCore.Mvc;

namespace Arth.Api.Controllers;

[Route("hosts/{hostId}/menus")]
public class MenusController : ApiController
{
    [HttpPost]
    public IActionResult CreateMenu(
        CreateMenuRequest request,
        string hostId)
    {
        return Ok(request);
    }
}
