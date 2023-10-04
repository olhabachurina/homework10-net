using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class Starfish:ISeaCreature
    {
        public string GetInformation()
        {
            return "Information about Starfish:\n" +
                "Starfish are animals. Their flat body is usually the size of a palm and the thickness of a finger;" +
                "it is round or pentagonal and along the outskirts is seated with processes that diverge in the form of rays." +
                "There are usually five of these processes, but sometimes more: ten or even thirty.";
        }
    }
}
