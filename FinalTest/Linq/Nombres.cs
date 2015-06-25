using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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

        // retourne une string en utilisant Linq (i.e sans utiliser de boucles) 
        // -> Aggregate + OrderBy
        public string TexteNombresImpairs
        {
            get { return keyValuePairs.OrderBy(x => x.Value).Aggregate(String.Empty, (cur, next) => cur + ((next.Value % 2 == 1) ? (", " + next.Key) : "")).Substring(2); }
        }

        public string PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get { return keyValuePairs.Select(x => x.Key).First(x => x.Length > 5); }
        }

        // retourne un IEnumerable<int> en utilisant Linq (i.e sans utiliser de boucles) -> OrderBy + Skip + Take
        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get { return keyValuePairs.OrderBy(x => x.Value).Skip(3).Take(4).Select(x => x.Value); }
        }
    }
}