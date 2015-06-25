using System;

namespace FinalTest
{
    public class Multiplication : IOperation
    {
        public bool PeutCalculer(string sCalc)
        {
            bool bRet = true;

            if (sCalc.Contains("+"))
            {
                bRet = bRet && false;
            }
            else if (sCalc.Contains("*"))
            {
                bRet = bRet && true;
            }

            return bRet;
        }

        public int Calculer(string sCalc)
        {
            int iRet = 1;

            string[] split = sCalc.Split(new Char[] { '*' });

            foreach (var s in split)
            {
                iRet = iRet * int.Parse(s);
            }

            return iRet;
        }
    }
}