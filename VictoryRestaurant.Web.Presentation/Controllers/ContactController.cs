namespace VictoryRestaurant.Web.Presentation.Controllers;

[Route(template: "Contact")]
public sealed class ContactController : Controller
{
	[ResponseCache(CacheProfileName = "Caching")]
	[HttpGet(template: "")]
	public IActionResult Index() => View(viewName: "Contact");
}