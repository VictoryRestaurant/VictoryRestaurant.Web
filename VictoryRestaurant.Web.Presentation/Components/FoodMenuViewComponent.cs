namespace VictoryRestaurant.Web.Presentation.Components;

public sealed class FoodMenuViewComponent : ViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync()
	{
		return View();
	}
}