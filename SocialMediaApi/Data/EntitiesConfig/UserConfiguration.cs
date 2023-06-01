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

		builder.ToTable("Users");
	}
}
