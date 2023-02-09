using EfUow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfUow.Configurations
{
    public class S_CardConfiguration : IEntityTypeConfiguration<S_Card>
    {
        public void Configure(EntityTypeBuilder<S_Card> builder)
        {
            builder.Property(x => x.DateOut)
                    .IsRequired()
                    .HasDefaultValue(DateTime.Now);

            builder.Property(x => x.DateIn)
                .IsRequired(false);

            builder.HasOne(x => x.Student)
                .WithMany(x => x.S_Cards)
                .HasForeignKey(x => x.Id_Student);

            builder.HasOne(x => x.Lib)
                .WithMany(x => x.S_Cards)
                .HasForeignKey(x => x.Id_Lib);

            builder.HasOne(x => x.Book)
                .WithMany(x => x.S_Cards)
                .HasForeignKey(x => x.Id_Book);
        }
    }
}
