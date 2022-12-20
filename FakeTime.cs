using Mocking_And_TDD.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankSoftware.Test.Fakes
{
    class FakeCommissionTime : ITimeHelper
    {
        public bool ShouldGetCommission()
        {
            return true;
        }
    }
    public class FakeTime : ITimeHelper
    {
        public bool ShouldGetCommission()
        {
            return false;
        }
    }
}
