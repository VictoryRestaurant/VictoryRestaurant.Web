namespace VictoryRestaurant.Web.Presentation.Controllers;

[Route(template: "/MailSubscribers")]
public sealed class MailSubscribersController : Controller
{
    [HttpPost(template: "")]
    public async Task<IActionResult> CreateMailSubscriber(
        [FromForm] MailSubscriberModel mailSubscriber)
    {
        return RedirectToAction(actionName: "Index", controllerName: "Home");
    }
}