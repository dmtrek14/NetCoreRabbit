using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NetCoreRabbit.Banking.Application.Interfaces;
using NetCoreRabbit.Banking.Application.Services;
using NetCoreRabbit.Banking.Data.Context;
using NetCoreRabbit.Banking.Data.Repository;
using NetCoreRabbit.Banking.Domain.Interfaces;
using NetCoreRabbit.Domain.Core.Bus;
using NetCoreRabbit.Infra.Bus;

namespace NetCoreRabbit.Infra.IoC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			//Domain Bus
			services.AddTransient<IEventBus, RabbitMQBus>();

			//Application services
			services.AddTransient<IAccountService, AccountService>();

			//Data
			services.AddTransient<IAccountRepository, AccountRepository>();
			services.AddTransient<BankingDbContext>();
		}
	}
}
