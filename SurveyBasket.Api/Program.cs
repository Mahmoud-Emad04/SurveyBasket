using Hangfire;
using HangfireBasicAuthenticationFilter;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Serilog;
using SurveyBasket;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddIdentityApiEndpoints<ApplicationUser>()
//	.AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddOpenApi();

builder.Services.AddDependencies(builder.Configuration);

builder.Host.UseSerilog((context, configuration) =>
	configuration.ReadFrom.Configuration(context.Configuration)
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
	app.UseSwaggerUI(options=> options.SwaggerEndpoint("/openapi/v1.json","v1"));
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseHangfireDashboard("/jobs", new DashboardOptions
{
	Authorization =
	[
		new HangfireCustomBasicAuthenticationFilter
		{
			User = app.Configuration.GetValue<string>("HangfireSettings:Username"),
			Pass = app.Configuration.GetValue<string>("HangfireSettings:Password")
		}
	],
	DashboardTitle = "Survey Basket Dashboard",
	//IsReadOnlyFunc = (DashboardContext conext) => true
});

//var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
//using var scope = scopeFactory.CreateScope();
//var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

//RecurringJob.AddOrUpdate("SendNewPollsNotification", () => notificationService.SendNewPollsNotification(null), Cron.Daily);

app.UseCors();

app.UseAuthorization();

//app.MapIdentityApi<ApplicationUser>();

app.MapControllers();

app.UseExceptionHandler();

app.MapHealthChecks("health", new HealthCheckOptions
{
	ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

app.Run();
