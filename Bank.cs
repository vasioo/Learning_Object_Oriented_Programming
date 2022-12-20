using Mocking_And_TDD.Contracts;
using Mocking_And_TDD.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mocking_And_TDD
{
    public class Bank
    {
        private IBankRepository database;
        private ITimeHelper time;
        public List<User> Users { get; set; }
        public Bank(IBankRepository db,ITimeHelper time)
        {
            database = db;
            this.time = time;
            Users = db.ReadUsers();
        }
        public void TransferMoney(User from, User to, decimal amount)
        {
            from.Account.WithdrawMoney(amount);
            to.Account.DepositMoney(amount);

            database.Update(this);
        }
        public void TransferMoney(string fromName, string toName, decimal amount)
        {
            User from = Users.First(u => u.Name == fromName);
            User to = Users.First(u => u.Name==toName);
            if (time.ShouldGetCommission())
            {
                from.Account.WithdrawMoney(1);
                to.Account.WithdrawMoney(1);
            }
            from.Account.WithdrawMoney(amount);
            to.Account.DepositMoney(amount);
            database.Update(this);
        }
        public void AddUser(User user)
        {
            Users.Add(user);
            database.Update(this);
        }
        public void RemoveUser(User user)
        {
            Users.Remove(user);
            database.Update(this);
        }
    }
}
