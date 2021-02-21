using NetCoreRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreRabbit.Banking.Domain.Interfaces
{
	public interface IAccountRepository
	{
		IEnumerable<Account> GetAccounts();
	}
}
