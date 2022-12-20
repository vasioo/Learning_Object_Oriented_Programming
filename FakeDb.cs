using Mocking_And_TDD;
using Mocking_And_TDD.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankSoftware.Test.Fakes
{
    class FakeDb : IBankRepository
    {
        public List<User> ReadUsers()
        {
            return new List<User>();
        }
        public void Update(Bank bank){}
    }
}
