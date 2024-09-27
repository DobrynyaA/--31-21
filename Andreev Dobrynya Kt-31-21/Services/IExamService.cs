using Andreev_Dobrynya_Kt_31_21.Database;
using Andreev_Dobrynya_Kt_31_21.Filters.ExamFilter;
using Andreev_Dobrynya_Kt_31_21.Filters.GroupsFilter;
using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;

namespace Andreev_Dobrynya_Kt_31_21.Services
{
	public interface IExamService
	{
		public Task<double> GetAverageMarkBySubjectInGroupAsync(GroupsFilter filter);
		public Task<int> GetStudentMarkInSubjectAsync(ExamFilterForStudent filter);
		public Task<double> GetYearlyAverageMarkAsync(ExamFilterForYearAvg filter);
	}

	public class ExamsService : IExamService
	{
		private readonly StudentDbContext _dbContext;
		public ExamsService(StudentDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<double> GetAverageMarkBySubjectInGroupAsync(GroupsFilter filter)
		{
			double s = await _dbContext.Set<Exam>().Where(x=>x.Student.Group.Speciality == filter.Speciality && x.Student.Group.DateTime == filter.Date).AverageAsync(x=>x.Mark);
			return s;
		}

		public async Task<int> GetStudentMarkInSubjectAsync(ExamFilterForStudent filter)
		{
			var s = await _dbContext.Set<Exam>().FirstOrDefaultAsync(x => x.Student.StudentId == filter.StudentId && x.Subject.SubjectName == filter.SubjectName);
			return s.Mark;
		}

		public async Task<double> GetYearlyAverageMarkAsync(ExamFilterForYearAvg filter)
		{
			double s = await _dbContext.Set<Exam>().Where(x => x.Subject.SubjectName == filter.SubjectName && x.ExamDate.Year == filter.Year).AverageAsync(x => x.Mark);
			return s;
		}
	}
}
