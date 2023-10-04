using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class Stingray : ISeaCreature
    {
        public string GetInformation()
        {
            return "Information about Stingray:\n" +
                "Stingrays are characterized by a strongly flattened body and large pectoral " +
                "fins fused to the head. The mouth, " +
                "nostrils and five pairs of gills are located on the flat and usually light-colored underside.";
        }
    }
}
