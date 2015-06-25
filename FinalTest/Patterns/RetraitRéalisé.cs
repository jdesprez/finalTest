using System;
using FinalTest.Patterns;

namespace FinalTest.Patterns
{
    public struct RetraitRéalisé : IEvenementMetier
    {
        private readonly string _numéroDeCompte;
        private readonly Montant _montantRetrait;
        private readonly DateTime _dateRetrait;

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            _numéroDeCompte = numéroDeCompte;
            _montantRetrait = montantRetrait;
            _dateRetrait = dateRetrait;
        }
    }
}