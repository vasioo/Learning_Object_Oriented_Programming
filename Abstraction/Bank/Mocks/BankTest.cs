using BankSoftware.Test.Fakes;
using Mocking_And_TDD;
using Mocking_And_TDD.Contracts;
using Mocking_And_TDD.IRepository;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace BankSoftware.Test
{
    public class Tests
    {
        private List<User> fakeUsers;
        private int calls=0;
        [SetUp]
        public void Setup()
        {
            Mock<IAccount> accountMock = new Mock<IAccount>();
            accountMock.Setup(a => a.Amount).Returns(100).Callback(()=>
            {
                calls++;
            });
            fakeUsers = new List<User>()
            {
                new User()
                {
                    Name = "Peshkata",
                    Account = (Account)accountMock.Object
                },new User()
                {
                    Name = "Georgi",
                    Account = (Account)accountMock.Object
                }
            };
        }
        [Test]
        public void Test_Transfer_Money_Should_Work_Normal_Hours()
        {
            Mock<ITimeHelper> timeMock = new Mock<ITimeHelper>();
            Mock<IBankRepository> dbMock = new Mock<IBankRepository>();
            dbMock.Setup(db => db.ReadUsers())
                .Returns(fakeUsers);
            Bank bank = new Bank(dbMock.Object, timeMock.Object);

            bank.TransferMoney("Peshkata", "Georgi", 30);

            Assert.AreEqual(70, bank.Users[0].Account.Amount);
            Assert.AreEqual(130, bank.Users[1].Account.Amount);
        }
        [Test]
        public void Test_Transfer_Money_Should_Work_Commission_Hours()
        {
            Bank bank = new Bank(new FakeDb(), new FakeCommissionTime());

            bank.TransferMoney("Peshkata", "Georgi", 30);

            Assert.AreEqual(69, bank.Users[0].Account.Amount);
            Assert.AreEqual(129, bank.Users[1].Account.Amount);
        }
        [Test]
        public void Test_User_Override_TOSTRING()
        {
            Mock<ILogger> loggerMock = new Mock<ILogger>();
            loggerMock.Setup(l => l.Log(It.IsAny<string>()))
                .Callback(() =>
                {
                    System.Console.WriteLine("Get");
                });
            loggerMock.Setup(l => l.Log(" : 0 lv"))
               .Callback(() =>
               {
                   System.Console.WriteLine("Get");
               });
            Mock<IAccount> accountMock = new Mock<IAccount>();
            accountMock.Setup(a => a.Amount).Returns(50);
            User user = new User(loggerMock.Object);
            user.Account = (Account)accountMock.Object;
            string result = user.ToString();
            Assert.AreEqual(": 0 lv",result);
        }
    }
}