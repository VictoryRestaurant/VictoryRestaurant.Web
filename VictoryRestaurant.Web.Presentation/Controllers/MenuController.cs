namespace VictoryRestaurant.Web.Presentation.Controllers;

[Route(template: "Menu")]
public sealed class MenuController : Controller
{
	[ResponseCache(CacheProfileName = "Caching")]
	[HttpGet(template: "")]
	public IActionResult Index() => View(viewName: "Menu");
}