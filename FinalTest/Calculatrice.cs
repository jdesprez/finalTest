namespace FinalTest.Tests
{
    public class Calculatrice
    {
        private IOperation[] operations;
        
        public Calculatrice(IOperation[] operations)
        {

            this.operations = operations;

        }

        public int Calculer(string sCalc)
        {
            int iRet = -1;
            
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i].PeutCalculer(sCalc))
                {
                    iRet = operations[i].Calculer(sCalc);
                    break;
                }
            }

            return iRet;
        }
    }
}