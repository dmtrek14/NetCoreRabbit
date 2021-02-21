using NetCoreRabbit.Banking.Data.Context;
using NetCoreRabbit.Banking.Domain.Interfaces;
using NetCoreRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreRabbit.Banking.Data.Repository
{
	public class AccountRepository : IAccountRepository
	{
		private BankingDbContext _ctx;

		public AccountRepository(BankingDbContext ctx)
		{
			_ctx = ctx;
		}
		public IEnumerable<Account> GetAccounts()
		{
			return _ctx.Accounts;
		}
	}
}
