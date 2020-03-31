using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtToMeterConverterProject
{
    public class FtStringFractionPartEvaluator : IFtStringFractionPartEvaluator
    {
        public double EvaluateFractionPart(string s)
        {
            double returnValue = 0;

            if (string.IsNullOrEmpty(s)) return returnValue;

            int n1 = s.IndexOf("'");
            int n2 = s.IndexOf("\"");

            if (n2 > 0)
            {
                returnValue = System.Convert.ToDouble(s.Substring(n1 + 1, n2 - n1 - 1)) / 12;
            }
            return returnValue / 3.2808;
        }
    }
}
