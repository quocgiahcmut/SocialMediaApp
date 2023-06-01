using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMediaApp.Api.Models;

namespace SocialMediaApp.Api.Data.EntitiesConfig;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.HasKey(u => u.UserId);

		builder.Property(u => u.Username)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(u => u.Email)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(u => u.Password)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(u => u.ProfilePicture)
			.HasMaxLength(200);

		builder.Property(u => u.Bio)
			.HasMaxLength(500);

        // Relationships
        builder.HasMany(u => u.Posts)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Comments)
            .WithOne(c => c.User)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Likes)
            .WithOne(l => l.User)
            .HasForeignKey(l => l.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Followers)
            .WithOne(f => f.FollowedUser)
            .HasForeignKey(f => f.FollowedUserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Following)
            .WithOne(f => f.FollowerUser)
            .HasForeignKey(f => f.FollowerUserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Notifications)
            .WithOne(n => n.User)
            .HasForeignKey(n => n.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Conversations)
            .WithMany(c => c.Participants)
            .UsingEntity(j => j.ToTable("UserConversation"));

        builder.ToTable("Users");
	}
}
