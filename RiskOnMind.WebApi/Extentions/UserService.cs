using Microsoft.AspNetCore.Http;
using RiskOnMind.Application.Common.Interfaces;
using System.Security.Claims;

namespace RiskOnMind.WebApi.Extentions
{
	public class UserService : IUserService
	{
		public string UserId { get; }
		public UserService(IHttpContextAccessor httpContextAccessor)
		{
			UserId = httpContextAccessor
				   .HttpContext?
				   .User?
				   .FindFirstValue(ClaimTypes.NameIdentifier);
		}
	}
}
