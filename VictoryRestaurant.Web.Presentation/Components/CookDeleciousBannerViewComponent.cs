namespace VictoryRestaurant.Web.Presentation.Components;

public sealed class CookDeleciousBannerViewComponent : ViewComponent
{
	public IViewComponentResult Invoke()
	{
        ViewBag.Phone = "Phone";

        return View();
	}
}