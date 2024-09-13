using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Andreev_Dobrynya_Kt_31_21.Database.Configuration
{
	public class GroupConfiguration : IEntityTypeConfiguration<Group>
	{
		public void Configure(EntityTypeBuilder<Group> builder)
		{
			builder.ToTable("Groups");

			builder.HasKey(g => g.GroupId);

			builder.Property(g=>g.GroupId)
				.ValueGeneratedOnAdd();

			builder.Property(g => g.GroupId)
				.HasColumnName("GroupId")
				.IsRequired(); 

			builder.Property(g => g.GroupName)
				.HasColumnName("GroupName")
				.HasMaxLength(100) 
				.IsRequired(); 

			builder.Property(g => g.Date)
				.HasColumnName("CreationDate")
				.IsRequired(); 

			builder.Property(g => g.Speciality)
				.HasColumnName("Speciality")
				.HasMaxLength(100) 
				.IsRequired(); 

			builder.HasMany(g => g.Students)
				.WithOne(s => s.Group) 
				.HasForeignKey(s => s.GroupId) 
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
