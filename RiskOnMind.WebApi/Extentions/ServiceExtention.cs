using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace RiskOnMind.WebApi.Extentions
{
	public static class ServiceExtention
	{
		public static object Configuration { get; private set; }

		public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
		{
			#region HttpContext
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			#endregion

			#region Swagger
			ConfigureSwagger(services, configuration);
			#endregion

			return services;
		}

		private static void ConfigureSwagger(IServiceCollection services, IConfiguration configuration)
		{
			services.AddSwaggerGen(options =>
			{
				options.SwaggerDoc(configuration.GetValue<string>("Swagger:Version"),
					new OpenApiInfo
					{
						Title = configuration.GetValue<string>("Swagger:Title"),
						Description = configuration.GetValue<string>("Swagger:Description"),
						Version = configuration.GetValue<string>("Swagger:Version")
					});
			});
		}
	}
}
