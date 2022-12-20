using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        public int Level { get; set; }
        public string Username { get; set; }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
        }
    }
}
