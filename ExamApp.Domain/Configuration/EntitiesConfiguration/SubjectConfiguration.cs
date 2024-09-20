using ExamApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamApp.Domain.Configuration.EntitiesConfiguration
{
    internal class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subject");

            builder.Property(x => x.SubjectCode)
                .IsRequired()
                .HasMaxLength(3)
                .HasColumnType("char(3)");

            builder.Property(x => x.SubjectName)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(x => x.ClassNumber)
                .IsRequired()
                .HasColumnType("tinyint");

            builder.Property(x => x.TeacherFirstName)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.TeacherLastName)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar(20)");

        }
    }
}
