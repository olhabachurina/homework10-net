using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class Shark: ISeaCreature
    {
        public string GetInformation()
        {
            return "Information about Shark:\n" +
                "Sharks are a superorder of cartilaginous fish, belonging to the subclass of " +
                "elasmobranchs and having the following distinctive features: an elongated body more or less " +
                "torpedo-shaped, a large heterocercal caudal fin, usually many sharp teeth on each jaw.";
                
        }
    }

}

