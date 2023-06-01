namespace SocialMediaApp.Api.Models;

public class Message
{
	public int MessageId { get; set; }
	public string Content { get; set; }
	public DateTime Timestamp { get; set; }

    public int SenderId { get; set; }
	public User Sender { get; set; }

	public ICollection<Message> Messages { get; set; }
}
