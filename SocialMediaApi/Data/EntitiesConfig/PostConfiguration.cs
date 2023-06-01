using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMediaApp.Api.Models;

namespace SocialMediaApp.Api.Data.EntitiesConfig;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
	public void Configure(EntityTypeBuilder<Post> builder)
	{
		builder.HasKey(p => p.PostId);

		builder.Property(p => p.Title)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(p => p.Content)
			.IsRequired()
			.HasMaxLength(500);

		builder.Property(p => p.CreatedAt)
			.IsRequired();

		builder.HasOne(p => p.User)
			.WithMany()
			.HasForeignKey(p => p.UserId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasMany(p => p.Comments)
			.WithOne(c => c.Post)
			.HasForeignKey(c => c.PostId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasMany(p => p.Likes)
			.WithOne(l => l.Post)
			.HasForeignKey(l => l.PostId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasMany(p => p.PostTags)
			.WithOne(pt => pt.Post)
			.HasForeignKey(pt => pt.PostId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.ToTable("Posts");
	}
}
