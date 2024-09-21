using Andreev_Dobrynya_Kt_31_21.Database.Helpers;
using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Andreev_Dobrynya_Kt_31_21.Database.Configuration
{
	public class TestConfiguration : IEntityTypeConfiguration<Test>
	{
		private const string TableName = "cd_tests";
		public void Configure(EntityTypeBuilder<Test> builder)
		{
			builder.ToTable(TableName);

			builder.HasKey(t => t.TestId)
				.HasName($"pk_{TableName}_test_id");

			builder.Property(t => t.TestId)
				.HasColumnName("test_id")
				.ValueGeneratedOnAdd();

			builder.HasOne(t => t.Subject)
				.WithMany()
				.HasForeignKey(e => e.SubjectId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Property(t => t.SubjectId)
				.HasColumnName("subject_id")
				.ValueGeneratedOnAdd();

			builder.HasOne(t => t.Student)
				.WithMany()
				.HasForeignKey(t => t.StudentId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.Property(t => t.StudentId)
				.HasColumnName("student_id")
				.ValueGeneratedOnAdd();

			builder.Property(t => t.isPassed)
				.HasColumnName("b_is_passed")
				.HasColumnType(ColumnType.Bool)
				.IsRequired();

			builder.Property(t => t.TestDate)
				.IsRequired();

			builder.ToTable(TableName)
				.HasIndex(p => p.isPassed,$"idx_{TableName}_fk_b_is_passed");
		}
	}
}
