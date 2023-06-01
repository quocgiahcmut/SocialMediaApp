using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMediaApp.Api.Models;

namespace SocialMediaApp.Api.Data.EntitiesConfig;

public class MediaAttachmentConfiguration : IEntityTypeConfiguration<MediaAttachment>
{
    public void Configure(EntityTypeBuilder<MediaAttachment> builder)
    {
        builder.HasKey(ma => ma.MediaAttachmentId);

        builder.Property(ma => ma.FileName)
            .IsRequired();

        builder.Property(ma => ma.ContentType)
            .IsRequired();

        builder.Property(ma => ma.FilePath)
            .IsRequired();

        builder.HasOne(ma => ma.Post)
            .WithMany(p => p.MediaAttachments)
            .HasForeignKey(ma => ma.PostId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("MediaAttachments");
    }
}
