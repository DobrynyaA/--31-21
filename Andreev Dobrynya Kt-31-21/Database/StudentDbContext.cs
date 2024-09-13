using Andreev_Dobrynya_Kt_31_21.Database.Configuration;
using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Andreev_Dobrynya_Kt_31_21.Database
{
	public class StudentDbContext : DbContext
	{
		DbSet<Student> Students { get; set; }
		DbSet<Group> Groups { get; set; }
		DbSet<Subject> Subjects { get; set; }
		DbSet<Test> Tests { get; set; }
		DbSet<Exam> Exams { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new StudentConfiguration());
			modelBuilder.ApplyConfiguration(new GroupConfiguration());
			modelBuilder.ApplyConfiguration(new SubjectConfiguration());
			modelBuilder.ApplyConfiguration(new TestConfiguration());
			modelBuilder.ApplyConfiguration(new ExamConfiguration());
		}
		public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
		{
		}
	}
		
	
}
