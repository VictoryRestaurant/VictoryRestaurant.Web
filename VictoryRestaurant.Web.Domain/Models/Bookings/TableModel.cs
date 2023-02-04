namespace VictoryRestaurant.Web.Domain.Models.Bookings;

/// <summary> The model of the table that is order at the time of <see cref="BookingModel"/>. </summary>
/// <remarks>
/// Data Transfer Object aka DTO.
/// </remarks>
public sealed class TableModel
{
    /// <summary> Identifier. </summary>
    public Guid Id { get; set; }

	/// <summary> Date of creation. </summary>
	public DateTime CreatedDate { get; set; }

	/// <summary> Table number. </summary>
	public int Number { get; set; }

    /// <summary> Table status. </summary>
    public string Status { get; set; } = default!;

    /// <summary> Foreign key to <see cref="BookingModel"/>. </summary>
    public Guid? BookingId { get; set; }

    /// <summary> Booking. </summary>
    public BookingModel? Booking { get; set; }
}