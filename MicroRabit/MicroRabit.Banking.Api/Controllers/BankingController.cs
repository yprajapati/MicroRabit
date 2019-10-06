using System;
using System.Collections.Generic;
using MicroRabit.Banking.Application.Interfaces;
using MicroRabit.Banking.Domain.Models;
using MicroRabit.Domain.Core.Bus;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/banking
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return _accountService.GetAccounts();
        }

        // GET api/banking
        [HttpPost]
        public IActionResult Post(AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
