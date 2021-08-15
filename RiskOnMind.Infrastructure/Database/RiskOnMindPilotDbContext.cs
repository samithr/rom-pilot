using Microsoft.EntityFrameworkCore;
using RiskOnMind.Application.Common.Interfaces;
using RiskOnMind.Domain.Common;
using RiskOnMind.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RiskOnMind.Infrastructure.Database
{
	public class RiskOnMindPilotDbContext : DbContext, IRiskOnMindPilotDbContext
	{
        private readonly IUserService userService;

        public RiskOnMindPilotDbContext(
            IUserService _userService,
            DbContextOptions<RiskOnMindPilotDbContext> options) : base(options)
		{
            _userService = userService;
        }

		public DbSet<ToDo> ToDos { get; set; }
		public DbSet<TodoItem> TodoItems { get ; set ; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var userId = Guid.Parse(userService.UserId);
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = userId;
                        entry.Entity.Created = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = userId;
                        entry.Entity.Modified = DateTime.UtcNow;
                        break;
                }
            }

            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(RiskOnMindPilotDbContext).Assembly);
		}
	}
}
