namespace VictoryRestaurant.Web.Domain.Models.Subscribers;

/// <summary> The model involved in the mailing process. </summary>
/// <remarks>
/// Data Transfer Object aka DTO.
/// </remarks>
public sealed class MailSubscriberModel
{
    /// <summary> Identifier. </summary>
    public Guid Id { get; set; }

    /// <summary> Subscriber email. </summary>
    public string Email { get; set; } = default!;
}