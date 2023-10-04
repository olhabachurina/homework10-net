using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class Jellyfish : ISeaCreature
    {
        public string GetInformation()
        {
            return "Information about Jellyfish:\n" +
                "Jellyfish is an invertebrate marine animal with a transparent gelatinous body," +
                "along the edges, equipped with tentacles. She is a " +
                "lower multicellular creature, belongs to the type of coelenterates.";
                
        }
    }
}
    

