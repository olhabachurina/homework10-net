using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class Turtle : ISeaCreature
    {
        public string GetInformation()
        {
            return "Information about Turtle:\n" +
                "The main feature that distinguishes this type of reptile from other animals" +
                "is the presence of a shell. This strong and" +
                "“practical” armor consists of a lower part - the plastron and an upper part - the carapace." +
                "The shape, size, number of scutes and shell pattern " +
                "are important species characteristics of turtles.";
        }
    }
}
