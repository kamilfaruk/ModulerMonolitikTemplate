using Microsoft.AspNetCore.Mvc;

namespace Location.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LocationsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok();
}
