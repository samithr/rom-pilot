using RiskOnMind.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiskOnMind.Domain.Entities
{
	public class ToDo : BaseEntity
	{
		public Guid ToDoId { get; set; }
		public string Description { get; set; }
		public int Priority { get; set; }
	}
}
