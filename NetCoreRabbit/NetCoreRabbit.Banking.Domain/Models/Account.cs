﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreRabbit.Banking.Domain.Models
{
	public class Account
	{
		public int Id { get; set; }
		public string AccountType { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal AccountBalance { get; set; }
	}
}
