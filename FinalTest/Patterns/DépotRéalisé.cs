using System;

namespace FinalTest.Patterns
{
    public struct DépotRéalisé : IEvenementMetier
    {
        private readonly string _numéroDeCompte;
        private readonly Montant _montantDepot;
        private readonly DateTime _dateDepot;

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            _numéroDeCompte = numéroDeCompte;
            _montantDepot = montantDepot;
            _dateDepot = dateDepot;
        }
    }
}