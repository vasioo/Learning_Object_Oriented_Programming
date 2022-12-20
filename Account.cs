using Mocking_And_TDD.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mocking_And_TDD
{
    public class Account : IAccount
    {
        public decimal Amount { get; set; }
        public User User { get; set; }
        public string History { get; set; }
        public void DepositMoney(decimal amount)
        {
            Amount += amount;
        }
        public void WithdrawMoney(decimal amount)
        {
            if (Amount < amount)
            {
                throw new ArgumentException("No money left");
            }
            Amount -= amount;
        }
    }
}
