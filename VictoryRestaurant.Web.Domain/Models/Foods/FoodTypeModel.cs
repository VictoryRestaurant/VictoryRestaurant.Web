namespace VictoryRestaurant.Web.Domain.Models.Foods;

/// <summary> The food type model. </summary>
/// <remarks>
/// Data Transfer Object aka DTO.
/// </remarks>
public sealed class FoodTypeModel
{
    /// <summary> Identifier. </summary>
    public Guid Id { get; set; }

    /// <summary> Type name. </summary>
    public string Name { get; set; } = default!;
}