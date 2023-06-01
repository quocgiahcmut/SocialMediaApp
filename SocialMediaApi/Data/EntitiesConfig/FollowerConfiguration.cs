using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMediaApp.Api.Models;

namespace SocialMediaApp.Api.Data.EntitiesConfig;

public class FollowerConfiguration : IEntityTypeConfiguration<Follower>
{
	public void Configure(EntityTypeBuilder<Follower> builder)
	{
		builder.HasKey(f => f.FollowerId);

		builder.HasOne(f => f.FollowerUser)
			.WithMany()
			.HasForeignKey(f => f.FollowerUserId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.HasOne(f => f.FollowedUser)
			.WithMany()
			.HasForeignKey(f => f.FollowedUserId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.ToTable("Followers");
	}
}
