using Exam.Project.Models.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.Project.DAL.Configurations;

public class PostCommentConfiguration : IEntityTypeConfiguration<PostComment>
{
    public void Configure(EntityTypeBuilder<PostComment> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasOne(p => p.Comment)
            .WithMany(p => p.PostComments)
            .HasForeignKey(p => p.CommentId)
            .OnDelete(DeleteBehavior.SetNull); // Kaskad silme

        builder
            .HasOne(p => p.Post)
            .WithMany(p => p.PostComments)
            .HasForeignKey(p => p.PostId)
            .OnDelete(DeleteBehavior.SetNull); // Kaskad silme
    }
}
