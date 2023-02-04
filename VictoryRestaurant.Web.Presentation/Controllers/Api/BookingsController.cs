namespace VictoryRestaurant.Web.Presentation.Controllers.Api;

[Route(template: "/Bookings")]
public class BookingsController : Controller
{
    [HttpPost(template: "")]
    public async Task<IActionResult> CreateBookingAsync()
    {
        return RedirectToAction(actionName: "Index", controllerName: "Home");
    }
}