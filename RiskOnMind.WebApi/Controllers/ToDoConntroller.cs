using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiskOnMind.Application.Services.ToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RiskOnMind.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ToDoConntroller : ControllerBase
	{
		private readonly IToDoService toDoService;
		private readonly CancellationToken cancellationToken;

		public ToDoConntroller(IToDoService _toDoService, CancellationToken _cancellationToken)
		{
			toDoService = _toDoService;
			cancellationToken = _cancellationToken;
		}

		[HttpGet]
		public IEnumerable<ToDoDto> Get()
		{
			return toDoService.GetToDoList(cancellationToken);
		}

		[HttpGet("{id}")]
		public async Task<ToDoDto> GetById(Guid Id)
		{
			return await toDoService.GetToDoById(Id, cancellationToken);
		}

		[HttpPost]
		public async Task<Guid> Create(ToDoDto toDoDto)
		{
			return await toDoService.CreateToDo(toDoDto, cancellationToken);
		}

		[HttpPatch]
		public async Task<bool> Update(ToDoDto toDoDto)
		{
			return await toDoService.UpdateToDo(toDoDto, cancellationToken);
		}

		[HttpDelete("{Id}")]
		public async Task<bool> Delete(Guid Id)
		{
			return await toDoService.DeleteToDo(Id, cancellationToken);
		}
	}
}
