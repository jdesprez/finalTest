namespace FinalTest.Tests
{
    public class SynthèseCompteBancaire
    {
        public string NuméroDeCompte { get; private set; }
        public int Debits { get; set; }
        public int Credits { get; private set; }

        public SynthèseCompteBancaire(string numéroDeCompte, int debits, int credits)
        {
            NuméroDeCompte = numéroDeCompte;
            Debits = debits;
            Credits = credits;

        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var syntcb = obj as SynthèseCompteBancaire;

            return (syntcb.Credits == this.Credits
                    &&syntcb.Debits == this.Debits
                    && syntcb.NuméroDeCompte == this.NuméroDeCompte);
        }
    }
}