using NetCoreRabbit.Banking.Application.Interfaces;
using NetCoreRabbit.Banking.Application.Models;
using NetCoreRabbit.Banking.Domain.Commands;
using NetCoreRabbit.Banking.Domain.Interfaces;
using NetCoreRabbit.Banking.Domain.Models;
using NetCoreRabbit.Domain.Core.Bus;
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
		private readonly IEventBus _bus;
		public AccountService(IAccountRepository accountRespoitory, IEventBus bus)
		{
			_accountRepository = accountRespoitory;
			_bus = bus;
		}
		public IEnumerable<Account> GetAccounts()
		{
			return _accountRepository.GetAccounts();
		}

		public void Transfer(AccountTransfer accountTransfer)
		{
			var createTransferCommand = new CreateTransferCommand(
				accountTransfer.FromAccount,
				accountTransfer.ToAccount,
				accountTransfer.TransferAmount
				);
			_bus.SendCommand(createTransferCommand);
		}
	}
}
