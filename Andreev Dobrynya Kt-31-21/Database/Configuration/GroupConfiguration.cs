using Andreev_Dobrynya_Kt_31_21.Database.Helpers;
using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Andreev_Dobrynya_Kt_31_21.Database.Configuration
{
	public class GroupConfiguration : IEntityTypeConfiguration<Group>
	{
		private const string TableName = "cd_groups";
		public void Configure(EntityTypeBuilder<Group> builder)
		{
			builder.ToTable(TableName);

			builder.HasKey(g => g.GroupId)
				.HasName($"pk_{TableName}_group_id");

			builder.Property(g=>g.GroupId)
				.ValueGeneratedOnAdd();

			builder.Property(g => g.GroupId)
				.HasColumnName("group_id")
				.HasColumnType(ColumnType.Int)
				.IsRequired(); 

			builder.Property(g => g.GroupName)
				.HasColumnName("c_group_name")
				.HasColumnType(ColumnType.String)
				.HasMaxLength(100) 
				.IsRequired(); 

			builder.Property(g => g.DateTime)
				.HasColumnName("d_creation_date")
				.HasColumnType(ColumnType.Date)
				.IsRequired(); 

			builder.Property(g => g.Speciality)
				.HasColumnName("c_speciality")
				.HasColumnType(ColumnType.String)
				.HasMaxLength(100) 
				.IsRequired(); 

			builder.HasMany(g => g.Students)
				.WithOne(s => s.Group) 
				.HasForeignKey(s => s.GroupId) 
				.OnDelete(DeleteBehavior.Cascade);

			builder.Navigation(p => p.Students)
				.AutoInclude();

			builder.ToTable(TableName)
				.HasIndex(p => p.Speciality, $"idx_{TableName}_fk_c_speciality");

			builder.ToTable(TableName)
				.HasIndex(p => p.DateTime, $"idx_{TableName}_fk_d_creation_date");
		}
	}
}
