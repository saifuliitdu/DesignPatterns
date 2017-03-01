using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtToMeterConverterProject
{
    public class FtStringIntegerPartValidator : IFtStringIntegerPartValidator
    {
        public bool ValidateIntegerPart(string s)
        {
            bool returnResult = false;

            if (string.IsNullOrEmpty(s)) return returnResult;

            int n = s.IndexOf("'");
            if (n > 0)
            {
                long num = Convert.ToInt64(s.Substring(0, n));

                if (num > 0)
                    returnResult = true;
            }
            

            return returnResult;
        }

        public bool ValidateFractionPart(string s)
        {
            bool returnResult = false;

            if (string.IsNullOrEmpty(s)) return returnResult;

            int n1 = s.IndexOf("'");
            int n2 = s.IndexOf("\"");
            
            if (n1 > 0)
            {
                long num = Convert.ToInt64(s.Substring(n1 + 1, n2 - n1 - 1));

                if (num > 0)
                    returnResult = true;
            }


            return returnResult;
        }
    }
}
