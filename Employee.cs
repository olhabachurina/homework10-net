using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class Employee
    {
        public string Position { get; set; }
        public string Name { get; set; }
        public string Responsibilities { get; set; }

        public Employee(string position, string name, string responsibilities)
        {
            Position = position;
            Name = name;
            Responsibilities = responsibilities;
        }

        public string GetInformation()
        {
            return $"{Position}: {Name}\nresponsibilities: {Responsibilities}";
        }
    }
}