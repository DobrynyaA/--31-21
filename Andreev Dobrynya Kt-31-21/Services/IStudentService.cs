using Andreev_Dobrynya_Kt_31_21.Database;
using Andreev_Dobrynya_Kt_31_21.Filters.StudentFilter;
using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
namespace Andreev_Dobrynya_Kt_31_21.Services
{
	public interface IStudentService
	{
		public Task<Student[]> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken);
	}

	public class StudentService : IStudentService
	{
		private readonly StudentDbContext _dbContext;
		public StudentService(StudentDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task<Student[]> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken = default)
		{
			var students = await _dbContext.Set<Student>().Where(w => w.Group.GroupName == filter.GroupName).ToArrayAsync(cancellationToken);

			return students;
		}
	}
}
