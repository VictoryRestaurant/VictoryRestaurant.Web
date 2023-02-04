namespace VictoryRestaurant.Web.Domain.Models.Foods;

/// <summary> The food model. </summary>
/// <remarks>
/// Data Transfer Object aka DTO.
/// </remarks>
public sealed class FoodModel
{
    /// <summary> Identifier. </summary>
    public Guid Id { get; set; }

	/// <summary> Date of creation. </summary>
	public DateTime CreatedDate { get; set; }

    /// <summary> Food name. </summary>
	public string Name { get; set; } = default!;

    /// <summary> Food description. </summary>
    public string Description { get; set; } = default!;

    /// <summary> Food cost. </summary>
    public decimal Cost { get; set; } = 0;

    /// <summary> Food image path. </summary>
    public string? ImagePath { get; set; }

    /// <summary> Foreign key to <see cref="FoodTypeModel"/>. </summary>
	public Guid? FoodTypeId { get; set; }

    /// <summary> Food type. </summary>
	public FoodTypeModel? FoodType { get; set; }
}