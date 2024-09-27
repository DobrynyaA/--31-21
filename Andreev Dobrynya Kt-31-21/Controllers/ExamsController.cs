using Andreev_Dobrynya_Kt_31_21.Filters.ExamFilter;
using Andreev_Dobrynya_Kt_31_21.Filters.GroupsFilter;
using Andreev_Dobrynya_Kt_31_21.Services;
using Microsoft.AspNetCore.Mvc;

namespace Andreev_Dobrynya_Kt_31_21.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class ExamsController : ControllerBase
	{
		private readonly ILogger<ExamsController> _logger;
		private readonly IExamService _examService;

		public ExamsController(ILogger<ExamsController> logger, IExamService examService)
		{
			_examService = examService;
			_logger = logger;
		}
		[HttpPost(Name = "GetAverageMarkBySubjectInGroupAsync")]
		public async Task<IActionResult> GetAverageMarkBySubjectInGroupAsync(GroupsFilter filter)
		{
			var groups = await _examService.GetAverageMarkBySubjectInGroupAsync(filter);

			return Ok(groups);
		}

		[HttpPost(Name = "GetStudentMarkInSubjectAsync")]
		public async Task<IActionResult> GetStudentMarkInSubjectAsync(ExamFilterForStudent filter)
		{
			var groups = await _examService.GetStudentMarkInSubjectAsync(filter);

			return Ok(groups);

		}

		[HttpPost(Name = "GetYearlyAverageMarkAsync")]
		public async Task<IActionResult> GetYearlyAverageMarkAsync(ExamFilterForYearAvg filter)
		{
			var groups = await _examService.GetYearlyAverageMarkAsync(filter);

			return Ok(groups);

		}
	}
}
