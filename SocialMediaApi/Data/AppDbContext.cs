using Microsoft.EntityFrameworkCore;
using SocialMediaApp.Api.Data.EntitiesConfig;
using SocialMediaApp.Api.Model;
using SocialMediaApp.Api.Models;

namespace SocialMediaApp.Api.Data;

public class AppDbContext : DbContext
{
	public DbSet<User> Users { get; set; }
	public DbSet<Post> Posts { get; set; }
	public DbSet<Comment> Comments { get; set; }
	public DbSet<Like> Likes { get; set; }
	public DbSet<Follower> Followers { get; set; }
	public DbSet<Hashtag> Hashtags { get; set; }
	public DbSet<PostHashtag> PostHashtags { get; set; }
	public DbSet<Notification> Notifications { get; set; }
	public DbSet<Media> Media { get; set; }
	public DbSet<Message> Messages { get; set; }
	public DbSet<Conversation> Conversations { get; set; }
	public DbSet<Participant> Participants { get; set; }
	public DbSet<Tag> Tags { get; set; }
	public DbSet<PostTag> PostTags { get; set; }

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// Configure entity relationships, constraints, and other configurations
		// ...
		modelBuilder.ApplyConfiguration(new UserConfiguration());

		base.OnModelCreating(modelBuilder);
	}
}
