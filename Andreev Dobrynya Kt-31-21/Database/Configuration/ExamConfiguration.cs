using Andreev_Dobrynya_Kt_31_21.Database.Helpers;
using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Andreev_Dobrynya_Kt_31_21.Database.Configuration
{
	public class ExamConfiguration : IEntityTypeConfiguration<Exam>
	{
		private const string TableName = "cd_exams";
		public void Configure(EntityTypeBuilder<Exam> builder)
		{
			builder.ToTable(TableName);

			builder.HasKey(e => e.ExamId)
				.HasName($"pk_{TableName}_exam_id");

			builder.Property(e => e.ExamId)
				.ValueGeneratedOnAdd();

			builder.Property(g => g.ExamId)
				.HasColumnName("exam_id")
				.HasColumnType(ColumnType.Int)
				.IsRequired();

			builder.HasOne(e => e.Subject)
				.WithMany() 
				.HasForeignKey(e => e.SubjectId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Property(g => g.SubjectId)
				.HasColumnName("f_subject_id")
				.HasColumnType(ColumnType.Int)
				.IsRequired();

			builder.HasOne(e => e.Student)
				.WithMany() 
				.HasForeignKey(e => e.StudentId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.Property(g => g.StudentId)
				.HasColumnName("f_student_id")
				.HasColumnType(ColumnType.Int)
				.IsRequired();

			builder.Property(e => e.Mark)
				.HasColumnName("n_mark_id")
				.HasColumnType(ColumnType.Int)
				.IsRequired(); 

			builder.Property(e => e.ExamDate)
				.HasColumnName("d_exam_date")
				.HasColumnType(ColumnType.Date)
				.IsRequired();

			builder.ToTable(TableName)
				.HasIndex(p => p.Mark, $"idx_{TableName}_fk_f_group_id");
		}
	}
}
