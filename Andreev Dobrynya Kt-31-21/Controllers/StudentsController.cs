namespace Andreev_Dobrynya_Kt_31_21.Controllers;

using Andreev_Dobrynya_Kt_31_21.Filters.StudentFilter;
using Andreev_Dobrynya_Kt_31_21.Models;
using Andreev_Dobrynya_Kt_31_21.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
	private readonly ILogger<StudentsController> _logger;
	private readonly IStudentService _studentService;
	
	public StudentsController(ILogger<StudentsController> logger, IStudentService studentService)
	{
		_studentService = studentService;
		_logger = logger;
	}
	[HttpPost(Name = "GetStudentsByGroup")]
	public async Task<IActionResult> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken = default )
	{
		var students = await _studentService.GetStudentsByGroupAsync(filter, cancellationToken);

		return Ok(students);
	}
}
