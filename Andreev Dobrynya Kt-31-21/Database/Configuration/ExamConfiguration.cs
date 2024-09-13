using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Andreev_Dobrynya_Kt_31_21.Database.Configuration
{
	public class ExamConfiguration : IEntityTypeConfiguration<Exam>
	{
		public void Configure(EntityTypeBuilder<Exam> builder)
		{
			builder.ToTable("Exams");

			builder.HasKey(e => e.ExamId);

			builder.Property(e => e.ExamId)
				.ValueGeneratedOnAdd();

			builder.HasOne(e => e.Subject)
				.WithMany() 
				.HasForeignKey(e => e.SubjectId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(e => e.Student)
				.WithMany() 
				.HasForeignKey(e => e.StudentId)
				.OnDelete(DeleteBehavior.Cascade); 

			builder.Property(e => e.Mark)
				.IsRequired(); 

			builder.Property(e => e.ExamDate)
				.IsRequired(); 
		}
	}
}
