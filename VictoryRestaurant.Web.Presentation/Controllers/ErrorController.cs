namespace VictoryRestaurant.Web.Presentation.Controllers;

[Route(template: "Error")]
public sealed class ErrorController : Controller
{
	[Route(template: "404")]
	[ResponseCache(CacheProfileName = "Caching")]
	public IActionResult PageNotFound() => View(viewName: "Error404");

	[Route(template: "500")]
	[ResponseCache(CacheProfileName = "Caching")]
	public IActionResult InternalServerError() => View(viewName: "Error500");
}