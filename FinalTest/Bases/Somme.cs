using System;

namespace FinalTest.Bases
{
    public class Somme : IOperation
    {
        public bool PeutCalculer(string sCalc)
        {
            bool bRet = true;

            if (sCalc.Contains("+"))
            {
                bRet = bRet && true;
            }
            else if (sCalc.Contains("*"))
            {
                bRet = bRet && false;
            }

            return bRet;
        }

        public int Calculer(string sCalc)
        {
            int iRet = 0;

            string[] split = sCalc.Split(new Char[] { '+' });

            foreach (var s in split)
            {
                iRet = iRet + int.Parse(s);
            }

            return iRet;
        }
    }
}