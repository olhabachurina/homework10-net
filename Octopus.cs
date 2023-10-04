using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class Octopus:ISeaCreature
    {
        public string GetInformation()
        {
            return "Information about Octopus:\n" +
                "The octopus is an active predator, feeding on crabs, " +
                "lobsters and small fish. The length of the sac-like body," +
                "which is called the mantle, is about 25 cm.";
                
        }
    }
}
