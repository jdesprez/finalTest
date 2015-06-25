using System.Collections.Generic;
using System.Linq;

namespace FinalTest.Linq
{
    public class Nombres
    {
        private IEnumerable<KeyValuePair<string, int>> keyValuePairs;

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            this.keyValuePairs = keyValuePairs;
        }
        // getter seulement qui retourne un IEnumerable<int> en utilisant Linq
        // (i.e sans utiliser de boucles) -> Where + Select
        public IEnumerable<int> NombresPairs {
            get { return keyValuePairs.Where(s => s.Value%2 == 0).Select(x => x.Value); }
        }
    }
}