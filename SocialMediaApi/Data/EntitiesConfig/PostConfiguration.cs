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
			.IsRequired();

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

		builder.HasMany(p => p.MediaAttachments)
			.WithOne(ma => ma.Post)
			.HasForeignKey(ma => ma.PostId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasMany(p => p.Tags)
			.WithMany(t => t.Posts)
			.UsingEntity(j => j.ToTable("PostTag"));

		builder.ToTable("Posts");
	}
}
