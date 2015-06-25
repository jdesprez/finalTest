using System.Collections.Generic;

namespace FinalTest.Tests
{
    public class CompteBancaire

    {
        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            return new List<IEvenementMetier> {new CompteCréé(numéroDeCompte, autorisationDeCrédit)};
        }
    }
}