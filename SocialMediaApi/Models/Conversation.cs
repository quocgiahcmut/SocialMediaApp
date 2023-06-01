namespace SocialMediaApp.Api.Models;

public class Conversation
{
	public int ConversationId { get; set; }
	public string Name { get; set; }
	public int CreatedBy { get; set; }
	public DateTime CreatedAt { get; set; }
}
