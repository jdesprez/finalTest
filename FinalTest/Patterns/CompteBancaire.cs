using System;
using System.Collections.Generic;

namespace FinalTest.Patterns
{
    public class CompteBancaire

    {
        private string numéroDeCompte ;
        private int autorisationDeCrédit;

        public CompteBancaire(IEvenementMetier compteCréé)
        {
            if (compteCréé is CompteCréé)
            {
                numéroDeCompte = ((CompteCréé)compteCréé).NuméroDeCompte;
                autorisationDeCrédit = ((CompteCréé)compteCréé).AutorisationDeCrédit;
            }
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            return new List<IEvenementMetier> {new CompteCréé(numéroDeCompte, autorisationDeCrédit)};
        }

        // retourne un IEnumerable<IEvenementMetier> contenant l'événement DepotRealisé
        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            return new List<IEvenementMetier> { new DépotRéalisé(numéroDeCompte, montantDepot, dateDepot) };
        }
    }
}