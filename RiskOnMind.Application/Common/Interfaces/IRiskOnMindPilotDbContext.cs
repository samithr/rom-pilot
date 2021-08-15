using Microsoft.EntityFrameworkCore;
using RiskOnMind.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace RiskOnMind.Application.Common.Interfaces
{
	public interface IRiskOnMindPilotDbContext
	{
		DbSet<ToDo> ToDos { get; set; }
		DbSet<TodoItem> TodoItems { get; set; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
	}
}
