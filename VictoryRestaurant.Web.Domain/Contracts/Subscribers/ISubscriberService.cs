namespace VictoryRestaurant.Web.Domain.Contracts.Subscribers;

/// <summary> A contract for a subscribing service. </summary>
public interface ISubscriberService
{
	/// <summary> Async create new mail subscriber. </summary>
	/// <param name="subscriber"> New mail subscriber. </param>
	/// <param name="cancellationToken"> Operation cancellation token. </param>
	public ValueTask SubscribeAsync(MailSubscriberModel subscriber,
		CancellationToken cancellationToken = default);
}