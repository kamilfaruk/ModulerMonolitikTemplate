using Microsoft.AspNetCore.Mvc;

namespace Notification.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificationsController : ControllerBase
{
    [HttpPost]
    public IActionResult Send() => Ok();
}
