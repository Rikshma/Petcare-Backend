using Microsoft.AspNetCore.Mvc;
using petcare.Application.Commands;
using petcare.Application.Models;
using petcare.Domain;

namespace petcare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly CreateNotificationCommand _createNotificationCommand;

        public NotificationController(CreateNotificationCommand createNotificationCommand)
        {
            _createNotificationCommand = createNotificationCommand;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePet([FromBody] Notification notification)
        {
            var result = await _createNotificationCommand.Create(notification);
            return Ok(result);
        }
    }
}
