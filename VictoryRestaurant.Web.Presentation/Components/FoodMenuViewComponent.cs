namespace VictoryRestaurant.Web.Presentation.Components;

public sealed class FoodMenuViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(string foodType, DisplaySide side)
    {
        ViewBag.Side = side;

        ViewBag.FoodTypeMessage = foodType;

        ViewBag.EngFoodTypeLower = foodType.ToLower();

        return View(model: Enumerable.Empty<FoodModel>());
    }
}