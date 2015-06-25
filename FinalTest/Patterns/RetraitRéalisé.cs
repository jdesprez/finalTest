using System;
using FinalTest.Patterns;

namespace FinalTest.Patterns
{
    public struct RetraitR�alis� : IEvenementMetier
    {
        private readonly string _num�roDeCompte;
        private readonly Montant _montantRetrait;
        private readonly DateTime _dateRetrait;

        public RetraitR�alis�(string num�roDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            _num�roDeCompte = num�roDeCompte;
            _montantRetrait = montantRetrait;
            _dateRetrait = dateRetrait;
        }
    }
}