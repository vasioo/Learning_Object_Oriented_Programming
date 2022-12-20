using Mocking_And_TDD.Contracts;

namespace Mocking_And_TDD
{
    public class User
    {
        private ILogger logger;
        public User()
        {

        }
        public User(ILogger logger)
        {
            this.logger = logger;
        }
        public string Name { get; set; }
        public Account Account { get; set; }
        public override string ToString()
        {
            if (logger!=null)
            {
                logger.Log($"{Name} : {Account.Amount} lv");
            }
            return $"{Name} : {Account.Amount} lv";
        }
    }
}