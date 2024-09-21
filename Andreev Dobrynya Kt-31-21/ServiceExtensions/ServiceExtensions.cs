using Andreev_Dobrynya_Kt_31_21.Services;
using System.Runtime.CompilerServices;

namespace Andreev_Dobrynya_Kt_31_21.ServiceExtensions
{
	public static class ServiceExtensions
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			services.AddScoped<IStudentService, StudentService>();
			services.AddScoped<IGroupService, GroupsService>();
			return services;
		}
	}
}
