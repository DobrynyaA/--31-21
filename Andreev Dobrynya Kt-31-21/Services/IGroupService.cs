using Andreev_Dobrynya_Kt_31_21.Database;
using Andreev_Dobrynya_Kt_31_21.Filters.GroupsFilter;
using Andreev_Dobrynya_Kt_31_21.Filters.StudentFilter;
using Andreev_Dobrynya_Kt_31_21.Models;
using Microsoft.EntityFrameworkCore;

namespace Andreev_Dobrynya_Kt_31_21.Services
{
	public interface IGroupService
	{
		public Task<Group[]> GetGroupByDateAndSpecialityAsync(GroupsFilter filter, CancellationToken cancellationToken);
	}
	public class GroupsService : IGroupService
	{
		private readonly StudentDbContext _dbContext;
		public GroupsService(StudentDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task<Group[]> GetGroupByDateAndSpecialityAsync(GroupsFilter filter, CancellationToken cancellationToken = default)
		{
			var students = await _dbContext.Set<Group>().Where(w => w.Speciality == filter.Speciality).Where(w => w.DateTime == filter.Date).ToArrayAsync(cancellationToken);

			return students;
		}
	}
}

