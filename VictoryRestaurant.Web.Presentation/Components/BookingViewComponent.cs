namespace VictoryRestaurant.Web.Presentation.Components;

public sealed class BookingViewComponent : ViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync()
	{
		return View();
	}
}