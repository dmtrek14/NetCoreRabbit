using NetCoreRabbit.Banking.Application.Interfaces;
using NetCoreRabbit.Banking.Application.Models;
using NetCoreRabbit.Banking.Domain.Interfaces;
using NetCoreRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreRabbit.Banking.Application.Services
{
	public class AccountService : IAccountService
	{
		private readonly IAccountRepository _accountRepository;
		public AccountService(IAccountRepository accountRespoitory)
		{
			_accountRepository = accountRespoitory;
		}
		public IEnumerable<Account> GetAccounts()
		{
			return _accountRepository.GetAccounts();
		}

		public void Transfer(AccountTransfer accountTransfer)
		{
			throw new NotImplementedException();
		}
	}
}
