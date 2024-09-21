using Andreev_Dobrynya_Kt_31_21.Database.Helpers;
using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Andreev_Dobrynya_Kt_31_21.Database.Configuration
{
	public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
	{
		private const string TableName = "cd_subject";
		public void Configure(EntityTypeBuilder<Subject> builder)
		{
			builder.ToTable(TableName);
				

			builder.HasKey(s => s.SubjectId)
				.HasName($"pk_{TableName}_subject_id");

			builder.Property(s => s.SubjectId)
				.ValueGeneratedOnAdd();

			builder.Property(s => s.SubjectName)
				.HasColumnName("SubjectName")
				.HasColumnType(ColumnType.String)
				.IsRequired();

			builder.ToTable(TableName)
				.HasIndex(p => p.SubjectName, $"idx_{TableName}_fk_c_subject_id");
		}
	}
}
