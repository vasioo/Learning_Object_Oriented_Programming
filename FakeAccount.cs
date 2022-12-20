using Mocking_And_TDD;
using Mocking_And_TDD.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankSoftware.Test.Fakes
{
    public class FakeAccount : IAccount
    {
        private decimal amount = 100;
        public decimal Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public void DepositMoney(decimal amount) { Amount += amount; }
        public void WithdrawMoney(decimal amount) { Amount -= amount; }
    }
}
