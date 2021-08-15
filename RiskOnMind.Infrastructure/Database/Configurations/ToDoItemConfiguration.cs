using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiskOnMind.Domain.Entities;

namespace RiskOnMind.Infrastructure.Database.Configurations
{
	public class ToDoItemConfiguration : IEntityTypeConfiguration<TodoItem>
	{
		public void Configure(EntityTypeBuilder<TodoItem> builder)
		{
			builder.Property(t => t.Title)
				.HasMaxLength(280)
				.IsRequired();

			builder.Property(t => t.Description)
				.HasMaxLength(1000);
		}
	}
}
