using System;

namespace RiskOnMind.Domain.Common
{
	public class BaseEntity
	{
		public Guid CreatedBy { get; set; }

		public DateTime Created { get; set; }

		public Guid ModifiedBy { get; set; }

		public DateTime? Modified { get; set; }
	}
}
