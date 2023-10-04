using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class FootballPlayer
    {
        public int Number { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public FootballPlayer(int number, string firstName, string lastName)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInformation()
        {
            return $"{Number}. {FirstName} {LastName}";
        }
    }
}