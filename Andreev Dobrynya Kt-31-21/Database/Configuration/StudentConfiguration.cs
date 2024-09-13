using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Andreev_Dobrynya_Kt_31_21.Database.Configuration
{
	public class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		private const string TableName = "cd_student";
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder
				.HasKey(p => p.StudentId);
				

			builder.Property(p => p.StudentId)
				.ValueGeneratedOnAdd();

			builder.Property(p => p.StudentId)
				.HasColumnName("student_id")
				.HasComment("Индификатор записи студента")
				.IsRequired();

			builder.Property(p => p.FirstName)
				.HasColumnName("first_name")
				.HasMaxLength(50)
				.IsRequired();

			builder.Property(p => p.LastName)
				.HasColumnName("last_name")
				.HasMaxLength(50)
				.IsRequired();

			builder.Property(p => p.MiddleName)
				.HasColumnName("middle_name")
				.HasMaxLength(50)
				.IsRequired();

			builder.HasOne(s => s.Group) 
			.WithMany(g => g.Students) 
			.HasForeignKey(s => s.GroupId) 
			.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
