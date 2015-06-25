using System;
using System.Collections.Generic;

namespace FinalTest.Patterns
{
    public class CompteBancaire

    {
        private List<IEvenementMetier> listEvents; 

        private string numéroDeCompte ;
        private int autorisationDeCrédit;

        public CompteBancaire(IEvenementMetier compteCréé)
        {
            listEvents = new List<IEvenementMetier>();

            if (compteCréé is CompteCréé)
            {
                numéroDeCompte = ((CompteCréé)compteCréé).NuméroDeCompte;
                autorisationDeCrédit = ((CompteCréé)compteCréé).AutorisationDeCrédit;
            }
            listEvents.Add(compteCréé);
        }

        public CompteBancaire(params IEvenementMetier[] events)
        {
            listEvents = new List<IEvenementMetier>();

            foreach (var ev in events)
            {
                if (ev is CompteCréé)
                {
                    numéroDeCompte = ((CompteCréé)ev).NuméroDeCompte;
                    autorisationDeCrédit = ((CompteCréé)ev).AutorisationDeCrédit;
                }

                listEvents.Add(ev);
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

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            return new List<IEvenementMetier> { new RetraitRéalisé(numéroDeCompte, montantRetrait, dateRetrait)};
        }
    }
}