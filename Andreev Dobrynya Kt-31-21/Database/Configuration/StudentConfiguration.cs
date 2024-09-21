using Andreev_Dobrynya_Kt_31_21.Database.Helpers;
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
				.HasKey(p => p.StudentId)
				.HasName($"pk_{TableName}_student_id");
				

			builder.Property(p => p.StudentId)
				.ValueGeneratedOnAdd();

			builder.Property(p => p.StudentId)
				.HasColumnName("student_id")
				.HasComment("Индификатор записи студента")
				.IsRequired();

			builder.Property(p => p.FirstName)
				.HasColumnName("c_first_name")
				.HasColumnType(ColumnType.String)
				.HasMaxLength(50)
				.HasComment("Имя студента")
				.IsRequired();

			builder.Property(p => p.LastName)
				.HasColumnName("c_last_name")
				.HasColumnType(ColumnType.String)
				.HasMaxLength(50)
				.HasComment("Отчество студента")
				.IsRequired();

			builder.Property(p => p.MiddleName)
				.HasColumnName("c_middle_name")
				.HasColumnType(ColumnType.String)
				.HasComment("Фамилия Студента")
				.HasMaxLength(50)
				.IsRequired();

			builder.Property(p => p.GroupId)
				.HasColumnName("group_id")
				.IsRequired();

			builder.HasOne(s => s.Group) 
			.WithMany(g => g.Students) 
			.HasForeignKey(s => s.GroupId) 
			.OnDelete(DeleteBehavior.Cascade);

			builder.ToTable(TableName)
				.HasIndex(p => p.GroupId,$"idx_{TableName}_fk_f_group_id");

			builder.Navigation(p => p.Group)
				.AutoInclude();
		}
	}
}
