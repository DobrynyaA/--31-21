using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Andreev_Dobrynya_Kt_31_21.Database.Configuration
{
	public class TestConfiguration : IEntityTypeConfiguration<Test>
	{
		public void Configure(EntityTypeBuilder<Test> builder)
		{
			builder.ToTable("Tests");

			builder.HasKey(t => t.TestId);

			builder.Property(t => t.TestId)
				.ValueGeneratedOnAdd();

			builder.HasOne(t => t.Subject)
				.WithMany()
				.HasForeignKey(e => e.SubjectId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(t => t.Student)
				.WithMany()
				.HasForeignKey(t => t.StudentId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.Property(t => t.isPassed)
				.IsRequired();

			builder.Property(t => t.TestDate)
				.IsRequired();
		}
	}
}
