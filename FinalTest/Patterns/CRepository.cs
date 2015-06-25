using System.Collections.Generic;

namespace FinalTest.Tests
{
    public class CRepository
    {
        public List<SynthèseCompteBancaire> Synthèses { get; set; }

        public CRepository()
        {
            Synthèses = new List<SynthèseCompteBancaire>();
        }
    }
}