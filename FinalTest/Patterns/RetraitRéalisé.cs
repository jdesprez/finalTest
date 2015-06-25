using System;
using FinalTest.Patterns;

namespace FinalTest.Patterns
{
    public struct RetraitR�alis� : IEvenementMetier
    {
        public string Num�roDeCompte { get; private set; }
        public Montant MontantRetrait { get; private set; }
        public DateTime DateRetrait { get; private set; }

        public RetraitR�alis�(string num�roDeCompte, Montant montantRetrait, DateTime dateRetrait) : this()
        {
            Num�roDeCompte = num�roDeCompte;
            MontantRetrait = montantRetrait;
            DateRetrait = dateRetrait;
        }
    }
}