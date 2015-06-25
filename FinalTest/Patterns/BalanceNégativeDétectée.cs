using System;
using FinalTest.Patterns;

namespace FinalTest.Patterns
{
    public struct BalanceNégativeDétectée : IEvenementMetier
    {
        private readonly string _numéroDeCompte;
        private readonly Montant _montant;
        private readonly DateTime _dateRetrait;

        public BalanceNégativeDétectée(string numéroDeCompte, Montant montant, DateTime dateRetrait)
        {
            _numéroDeCompte = numéroDeCompte;
            _montant = montant;
            _dateRetrait = dateRetrait;
        }
    }
}