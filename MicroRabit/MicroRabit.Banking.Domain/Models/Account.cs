using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabit.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
    }
}
