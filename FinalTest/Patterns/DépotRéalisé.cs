using System;

namespace FinalTest.Patterns
{
    public struct DépotRéalisé : IEvenementMetier
    {
        public string NuméroDeCompte { get; private set; }
        public Montant MontantDepot { get; private set; }
        public DateTime DateDepot { get; private set; }

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot) : this()
        {
            NuméroDeCompte = numéroDeCompte;
            MontantDepot = montantDepot;
            DateDepot = dateDepot;
        }
    }
}