using System;
using FinalTest.Patterns;

namespace FinalTest.Patterns
{
    public struct RetraitRéalisé : IEvenementMetier
    {
        public string NuméroDeCompte { get; private set; }
        public Montant MontantRetrait { get; private set; }
        public DateTime DateRetrait { get; private set; }

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait) : this()
        {
            NuméroDeCompte = numéroDeCompte;
            MontantRetrait = montantRetrait;
            DateRetrait = dateRetrait;
        }
    }
}