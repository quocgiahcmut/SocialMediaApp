namespace SocialMediaApp.Api.Models;

public class Follower
{
	public int FollowerId { get; set; }
	public int FollowerUserId { get; set; }  // Foreign key to the follower user
	public int FollowedUserId { get; set; }  // Foreign key to the followed user

	public User FollowerUser { get; set; }   // Navigation property to the follower user
	public User FollowedUser { get; set; }
}
