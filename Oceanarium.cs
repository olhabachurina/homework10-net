using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class Oceanarium : IEnumerable<ISeaCreature>
    {
        private List<ISeaCreature> Inhabitants = new List<ISeaCreature>();

        public void AddInhabitant(ISeaCreature seaCreature)
        {
            Inhabitants.Add(seaCreature);
        }

        public IEnumerator<ISeaCreature> GetEnumerator()
        {
            return Inhabitants.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}