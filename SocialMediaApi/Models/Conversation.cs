namespace SocialMediaApp.Api.Models;

public class Conversation
{
	public int ConversationId { get; set; }
	public string Name { get; set; }
	public int CreatedBy { get; set; }
	public DateTime CreatedAt { get; set; }

	public ICollection<User> Participants { get; set; }
	public ICollection<Message> Messages { get; set; }
}
