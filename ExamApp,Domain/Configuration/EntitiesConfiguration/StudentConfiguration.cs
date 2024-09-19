using ExamApp_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamApp_Domain.Configuration.EntitiesConfiguration
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");

            builder.Property(x => x.StudentNumber)
                .IsRequired()
                .HasColumnType("number(5,0)");

            builder.Property(x => x.Firstname)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("varchar(30)");

            builder.Property(x => x.Lastname)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("varchar(30)");

            builder.Property(x => x.ClassNumber)
                .IsRequired()
                .HasColumnType("number(2,0)");

        }
    }
}
