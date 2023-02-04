namespace VictoryRestaurant.Web.Presentation.Controllers;

[Route(template: "Bookings")]
public sealed class BookingsController : Controller
{
    [HttpPost(template: "")]
    public async Task<IActionResult> CreateBookingAsync()
    {
        return RedirectToAction(actionName: "Index", controllerName: "Home");
    }
}