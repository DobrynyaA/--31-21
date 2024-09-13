using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Andreev_Dobrynya_Kt_31_21.Database.Configuration
{
	public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
	{
		public void Configure(EntityTypeBuilder<Subject> builder)
		{
			builder.ToTable("Subjects");

			builder.HasKey(s => s.SubjectId);

			builder.Property(s => s.SubjectId)
				.ValueGeneratedOnAdd();

			builder.Property(s => s.SubjectName)
				.HasColumnName("SubjectName")
				.IsRequired();
		}
	}
}
