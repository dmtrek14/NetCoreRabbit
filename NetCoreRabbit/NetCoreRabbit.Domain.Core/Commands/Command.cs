using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreRabbit.Domain.Core.Commands
{
	public abstract class Command: Message
	{
		public DateTime Timestap { get; protected set; }

		protected Command()
		{
			Timestamp = DateTime.Now;
		}
	}
}
