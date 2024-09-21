using Microsoft.AspNetCore.Mvc;
using Andreev_Dobrynya_Kt_31_21.Filters.StudentFilter;
using Andreev_Dobrynya_Kt_31_21.Models;
using Andreev_Dobrynya_Kt_31_21.Services;

using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Andreev_Dobrynya_Kt_31_21.Filters.GroupsFilter;

namespace Andreev_Dobrynya_Kt_31_21.Controllers
{

	[ApiController]
	[Route("[controller]")]
	public class GroupsController : ControllerBase
	{
		private readonly ILogger<GroupsController> _logger;
		private readonly IGroupService _groupService;

		public GroupsController(ILogger<GroupsController> logger, IGroupService groupService)
		{
			_groupService = groupService;
			_logger = logger;
		}
		[HttpPost(Name = "GetGroupByDateAndSpecialityAsync")]
		public async Task<IActionResult> GetGroupByDateAndSpecialityAsync(GroupsFilter filter, CancellationToken cancellationToken = default)
		{
			var groups = await _groupService.GetGroupByDateAndSpecialityAsync(filter, cancellationToken);

			return Ok(groups);
		}
	}
}
