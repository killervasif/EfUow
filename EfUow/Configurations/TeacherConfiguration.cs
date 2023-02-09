using EfUow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfUow.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar(15)");

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasColumnType("nvarchar(25)");

            builder.HasOne(x => x.Department)
                .WithMany(x => x.Teachers)
                .HasForeignKey(x => x.Id_Dep);
        }
    }
}
