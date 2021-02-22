using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreRabbit.Banking.Application.Interfaces;
using NetCoreRabbit.Banking.Application.Models;
using NetCoreRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreRabbit.Banking.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BankingController : ControllerBase
	{
		private readonly IAccountService _accountService;
		public BankingController(IAccountService accountService)
		{
			_accountService = accountService;
		}
		//GET api/banking
		[HttpGet]
		public ActionResult<IEnumerable<Account>> Get()
		{
			return Ok(_accountService.GetAccounts());
		}

		[HttpPost]
		public IActionResult Post([FromBody] AccountTransfer accountTransfer)
		{

			return Ok(accountTransfer);
		}
	}
}
