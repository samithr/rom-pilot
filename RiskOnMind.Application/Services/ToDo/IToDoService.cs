using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RiskOnMind.Application.Services.ToDo
{
	public interface IToDoService
	{
		Task<Guid> CreateToDo(ToDoDto toDoDto, CancellationToken cancellationToken);
		Task<ToDoDto> GetToDoById(Guid toDoId, CancellationToken cancellationToken);
		IEnumerable<ToDoDto> GetToDoList(CancellationToken cancellationToken);
		Task<bool> UpdateToDo(ToDoDto toDoDto, CancellationToken cancellationToken);
		Task<bool> DeleteToDo(Guid toDoId, CancellationToken cancellationToken);
	}
}
