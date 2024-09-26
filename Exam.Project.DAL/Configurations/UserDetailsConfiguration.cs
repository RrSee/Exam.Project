using Exam.Project.Models.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.Project.DAL.Configurations;

public class UserDetailsConfiguration : IEntityTypeConfiguration<UserDetails>
{
    public void Configure(EntityTypeBuilder<UserDetails> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasOne(p => p.User)
            .WithOne(p => p.UserDetails)
            .HasForeignKey<UserDetails>(p => p.UserId)
            .OnDelete(DeleteBehavior.SetNull); // Kaskad silme
    }
}
