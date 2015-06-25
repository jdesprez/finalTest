using FinalTest.Patterns;

namespace FinalTest.Patterns
{
    public class SynthèseCompteBancaireProjection
    {
        private readonly ISynthèseCompteBancaireRepository _repository;

        public SynthèseCompteBancaireProjection(ISynthèseCompteBancaireRepository repository)
        {
            _repository = repository;
        }

        public void Handle(IEvenementMetier ev)
        {
            if (ev is RetraitRéalisé)
            {
                _repository.Get(((RetraitRéalisé)ev).NuméroDeCompte).Debits += ((RetraitRéalisé)ev).MontantRetrait.Value;
            }
        }
    }
}