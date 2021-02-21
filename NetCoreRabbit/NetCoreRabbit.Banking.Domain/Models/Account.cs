﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreRabbit.Banking.Domain.Models
{
	public class Account
	{
		public int Id { get; set; }
		public string AccountType { get; set; }
		public decimal AccountBalance { get; set; }
	}
}
