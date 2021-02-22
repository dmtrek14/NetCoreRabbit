﻿using NetCoreRabbit.Banking.Application.Models;
using NetCoreRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreRabbit.Banking.Application.Interfaces
{
	public interface IAccountService
	{
		IEnumerable<Account> GetAccounts();
		void Transfer(AccountTransfer accountTransfer);
	}
}
