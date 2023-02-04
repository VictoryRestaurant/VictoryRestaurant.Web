namespace VictoryRestaurant.Web.Presentation.Controllers;

[Route(template: "/ContactMessages")]
public sealed class ContactMessagesController : Controller
{
    public async Task<IActionResult> CreateContactMessage(
        [FromForm] ContactMessageModel contactMessage)
    {
        return RedirectToAction(actionName: "Index", controllerName: "Contact");
    }
}