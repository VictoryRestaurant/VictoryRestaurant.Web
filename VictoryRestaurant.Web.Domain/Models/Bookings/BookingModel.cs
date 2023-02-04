namespace VictoryRestaurant.Web.Domain.Models.Bookings;

/// <summary> The model involved in booking a <see cref="TableModel"/>. </summary>
/// <remarks>
/// Data Transfer Object aka DTO.
/// </remarks>
public sealed class BookingModel
{
    /// <summary> Identifier. </summary>
    public Guid Id { get; set; }

    /// <summary> Booking date. </summary>
    public DateTime Date { get; set; }

	/// <summary> Date of creation. </summary>
	public DateTime CreatedDate { get; set; }

	/// <summary> Booking time. </summary>
	public string Time { get; set; } = default!;

    /// <summary> Booking owner name. </summary>
    public string Name { get; set; } = default!;

	/// <summary> Booking owner phone number. </summary>
	public string Phone { get; set; } = default!;

    /// <summary> Visitors count. </summary>
    public int VisitorsCount { get; set; }

    /// <summary> Booked table. </summary>
    public TableModel? Table { get; set; }
}