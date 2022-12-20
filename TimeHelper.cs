using Mocking_And_TDD.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mocking_And_TDD
{
    public class TimeHelper : ITimeHelper
    {
        public bool ShouldGetCommission()
        {
            if (DateTime.Now.DayOfWeek==DayOfWeek.Monday)
            {
                return true;
            }
            return false;
        }
    }
}
