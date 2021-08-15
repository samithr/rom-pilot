using AutoMapper;
using RiskOnMind.Domain.Entities;

namespace RiskOnMind.Application.Services.ToDo
{
	public class TodoItemDto
	{
		public long Id { get; set; }
		public int ListId { get; set; }
		public string Title { get; set; }
		public bool Done { get; set; }
		public string Description { get; set; }
		public int Status { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<TodoItem, TodoItemDto>()
				.ForMember(d => d.Status, opt =>
					opt.MapFrom(s => (int)s.Status));
		}
	}
}
