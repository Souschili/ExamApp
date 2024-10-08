﻿using ExamApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ExamApp.Domain.Configuration.EntitiesConfiguration
{
    internal class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.ToTable("Exam");

            builder.Property(x => x.SubjectCode)
                .IsRequired()
                .HasColumnType("char(3)");

            builder.Property(x => x.StudentNumber)
               .IsRequired()
               .HasColumnType("int");

            builder.Property(x => x.Date)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(x => x.Mark)
                .IsRequired()
                .HasColumnType("tinyint");

        }
    }
}
