using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMediaApp.Api.Models;

namespace SocialMediaApp.Api.Data.EntitiesConfig;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasKey(t => t.TagId);

        builder.Property(t => t.Name)
            .IsRequired();

        builder.HasMany(t => t.Posts)
            .WithMany(p => p.Tags)
            .UsingEntity(j => j.ToTable("PostTags"));

        builder.ToTable("Tags");
    }
}
