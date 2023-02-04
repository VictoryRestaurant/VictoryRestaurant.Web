namespace VictoryRestaurant.Web.Domain.Models.Contacts;

/// <summary> The model involved in the process of leaving feedback. </summary>
/// <remarks>
/// Data Transfer Object aka DTO.
/// </remarks>
public sealed class ContactMessageModel
{
    /// <summary> Identifier. </summary>
    public Guid Id { get; set; }

    /// <summary> Date of creation. </summary>
	public DateTime CreatedDate { get; set; }

	/// <summary> Message author name. </summary>
	public string Name { get; set; } = default!;

    /// <summary> Message author email. </summary>
    public string Email { get; set; } = default!;

    /// <summary> Message author phone number. </summary>
    public string Phone { get; set; } = default!;

    /// <summary> Message text. </summary>
    public string Message { get; set; } = default!;
}