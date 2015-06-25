using FinalTest.Patterns;

namespace FinalTest.Tests
{
    public class SynthèseCompteBancaireProjection
    {
        private readonly CRepository _repository;

        public SynthèseCompteBancaireProjection(CRepository repository)
        {
            _repository = repository;
        }

        public void Handle(IEvenementMetier ev)
        {
            if (ev is RetraitRéalisé)
            {
                foreach (var synt in _repository.Synthèses)
                {
                    if (synt.NuméroDeCompte == ((RetraitRéalisé) ev).NuméroDeCompte)
                    {
                        synt.Debits += ((RetraitRéalisé) ev).MontantRetrait.Value;
                    }
                }
            }   
        }
    }
}