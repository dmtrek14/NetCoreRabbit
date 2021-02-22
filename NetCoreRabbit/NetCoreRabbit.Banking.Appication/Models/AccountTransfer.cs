﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreRabbit.Banking.Application.Models
{
	public class AccountTransfer
	{
		public int FromAccount { get; set; }
		public int ToAccount { get; set; }
		public decimal TransferAmount { get; set; }
	}
}
