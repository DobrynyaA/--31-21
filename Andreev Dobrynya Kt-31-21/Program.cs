using Andreev_Dobrynya_Kt_31_21.Database;
using Andreev_Dobrynya_Kt_31_21.ServiceExtensions;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
// Add services to the container.

try
{
	builder.Logging.ClearProviders();
	builder.Host.UseNLog();

	builder.Services.AddControllers();
	// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
	builder.Services.AddEndpointsApiExplorer();
	builder.Services.AddSwaggerGen();

	builder.Services.AddDbContext<StudentDbContext>(option =>
		option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

	builder.Services.AddServices();

	builder.Services.AddControllersWithViews()
				.AddNewtonsoftJson(options =>
				options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
			);

	var app = builder.Build();

	// Configure the HTTP request pipeline.
	if (app.Environment.IsDevelopment())
	{
		app.UseSwagger();
		app.UseSwaggerUI();
	}

	app.UseAuthorization();

	app.MapControllers();

	app.Run();
}
catch(Exception ex)
{
	logger.Error(ex, "Stopped program because of exeption");
}
finally
{
	LogManager.Shutdown();
}

