namespace VictoryRestaurant.Web.Presentation.Controllers;

[Route(template: "/")]
[Route(template: "Home")]
public sealed class HomeController : Controller
{
	[ResponseCache(CacheProfileName = "Caching")]
	[HttpGet(template: "")]
	public IActionResult Index() => View(viewName: "Index");
}