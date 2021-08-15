using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RiskOnMind.Application.Common.Interfaces;
using RiskOnMind.Infrastructure.Database;

namespace RiskOnMind.Infrastructure
{
	public static class ServiceExtention
	{
		public static IServiceCollection ConfigureInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			#region DbContext

			services.AddDbContext<IRiskOnMindPilotDbContext, RiskOnMindPilotDbContext >(oprions =>
			{
				oprions.UseNpgsql(configuration["ConnectionString:DefaultConnection"]);
			});

			#endregion

			#region Infrastrcuture Services


			#endregion

			return services;
		}
	}
}
