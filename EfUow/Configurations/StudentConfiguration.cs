using EfUow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfUow.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar(15)");

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasColumnType("nvarchar(25)");

            builder.HasOne(x => x.Group)
                .WithMany(x => x.Students)
                .HasForeignKey(x => x.Id_Group);
        }
    }
}
