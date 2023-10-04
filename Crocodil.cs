using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class Crocodil :ISeaCreature
    {
        public string GetInformation()
        {
            return "Infomation about Crocodile :\n" +
                "Crocodiles have a large, dense, lizard-like body," +
                "an elongated and flattened muzzle," +
                "tails elongated on the sides, as well as eyes," +
                "ears and nostrils located on the top of the head." +
                "They swim well and can move quite quickly on land." +
                "Their skin is very thick and covered with non-overlapping scales.";
        }
    }
}
