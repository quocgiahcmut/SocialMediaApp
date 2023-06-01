using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMediaApp.Api.Models;

namespace SocialMediaApp.Api.Data.EntitiesConfig;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
	public void Configure(EntityTypeBuilder<Comment> builder)
	{
		builder.HasKey(c => c.CommentId);

		builder.Property(c => c.Content)
			.IsRequired();

		builder.Property(c => c.CreatedAt)
			.IsRequired();

		builder.HasOne(c => c.User)
			.WithMany(u => u.Comments)
			.HasForeignKey(c => c.UserId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.HasOne(c => c.Post)
			.WithMany(p => p.Comments)
			.HasForeignKey(c => c.PostId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.ToTable("Comments");
	}
}
