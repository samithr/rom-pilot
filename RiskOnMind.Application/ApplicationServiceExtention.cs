using Microsoft.Extensions.DependencyInjection;
using RiskOnMind.Application.Common.Interfaces;
using RiskOnMind.Application.Services.Auth;
using RiskOnMind.Application.Services.ToDo;
using System.Reflection;

namespace RiskOnMind.Application
{
	public static class ApplicationServiceExtention
	{
		public static IServiceCollection ConfigureApplication(this IServiceCollection services)
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			#region Register application services

			services.AddScoped<IToDoService, ToDoService>();
			services.AddScoped<IUserService, UserService>();

			#endregion

			return services;
		}
	}
}
