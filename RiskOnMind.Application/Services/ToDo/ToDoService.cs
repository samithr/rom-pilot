using AutoMapper;
using RiskOnMind.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RiskOnMind.Application.Services.ToDo
{
	public class ToDoService : IToDoService
	{
		private IRiskOnMindPilotDbContext dbContext;
		private IMapper mapper;

		public ToDoService(IRiskOnMindPilotDbContext _dbContext, IMapper _mappaer)
		{
			dbContext = _dbContext;
			mapper = _mappaer;
		}

		public async Task<Guid> CreateToDo(ToDoDto toDoDto, CancellationToken cancellationToken)
		{
			var newEntityId = Guid.Empty;
			if (toDoDto != null && toDoDto.Title != null)
			{
				newEntityId = Guid.NewGuid();
				var entity = new Domain.Entities.ToDo
				{
					ToDoId = newEntityId,
					Description = toDoDto.Title,
					Created = DateTime.Now
				};

				dbContext.ToDos.Add(entity);
				await dbContext.SaveChangesAsync(cancellationToken);
			}
			return newEntityId;
		}

		public async Task<bool> DeleteToDo(Guid toDoId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public async Task<ToDoDto> GetToDoById(Guid toDoId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ToDoDto> GetToDoList(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateToDo(ToDoDto toDoDto, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
