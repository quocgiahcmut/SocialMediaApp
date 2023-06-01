namespace SocialMediaApp.Api.Models;

public class User
{
	public int UserId { get; set; }
	public string Username { get; set; }
	public string Email { get; set; }
	public string Password { get; set; }
	public string ProfilePicture { get; set; }
	public string Bio { get; set; }

	public ICollection<Post> Posts { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public ICollection<Like> Likes { get; set; }
    public ICollection<Follower> Followers { get; set; }
    public ICollection<Follower> Following { get; set; }
    public ICollection<Notification> Notifications { get; set; }
	public ICollection<Conversation> Conversations { get; set; }
}
