using Microsoft.EntityFrameworkCore;
using NetCoreRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreRabbit.Banking.Data.Context
{
	public class BankingDbContext : DbContext
	{
		public BankingDbContext(DbContextOptions options): base(options)
		{
		}

		public DbSet<Account> Accounts { get; set; }
	}
}
