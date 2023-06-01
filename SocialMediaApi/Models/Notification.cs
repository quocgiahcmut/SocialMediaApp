namespace SocialMediaApp.Api.Models;

public class Notification
{
	public int NotificationId { get; set; }
	public int UserId { get; set; }
	public string Type { get; set; }
	public string Content { get; set; }
	public DateTime Timestamp { get; set; }
}

