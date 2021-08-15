using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiskOnMind.Domain.Entities;

namespace RiskOnMind.Infrastructure.Database.Configurations
{
	public class ToDoConfiguration : IEntityTypeConfiguration<ToDo>
	{
		public void Configure(EntityTypeBuilder<ToDo> builder)
		{
			builder.Property(p => p.Description)
				.HasMaxLength(500);
			builder.Property(p => p.Priority)
				.HasMaxLength(3);
		}
	}
}
