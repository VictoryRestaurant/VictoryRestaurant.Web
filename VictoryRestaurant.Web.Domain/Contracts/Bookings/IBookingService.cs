namespace VictoryRestaurant.Web.Domain.Contracts.Bookings;

/// <summary> A contract for a seat booking service. </summary>
public interface IBookingService
{
	/// <summary> Async create new booking. </summary>
	/// <param name="booking"> New booking. </param>
	/// <param name="cancellationToken"> Operation cancellation token. </param>
	/// <returns> New booking with actual data. </returns>
	public ValueTask<BookingModel?> BookingAsync(BookingModel booking,
		CancellationToken cancellationToken = default);
}