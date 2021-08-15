using RiskOnMind.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiskOnMind.Domain.Entities
{
	public class TodoItem : BaseEntity
	{
        public long Id { get; set; }
        public int ToDoListId { get; set; }
        public string Title { get; set; }
        public ToDoStatus Status { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public DateTime? Reminder { get; set; }

        public ToDo List { get; set; }
    }
}
