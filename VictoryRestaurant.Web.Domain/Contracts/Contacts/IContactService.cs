namespace VictoryRestaurant.Web.Domain.Contracts.Contacts;

/// <summary> A contract for contact service. </summary>
public interface IContactService
{
	/// <summary> Async create new contact message. </summary>
	/// <param name="message"> New message. </param>
	/// <param name="cancellationToken"> Operation cancellation token. </param>
	public ValueTask ContactAsync(ContactMessageModel message,
		CancellationToken cancellationToken = default);
}