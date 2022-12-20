using System;
using System.Collections.Generic;
using System.Text;

namespace Mocking_And_TDD.IRepository
{
    public interface IBankRepository
    {
        void Update(Bank bank);
        List<User> ReadUsers();
    }
}
