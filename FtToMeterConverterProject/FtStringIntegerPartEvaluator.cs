using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtToMeterConverterProject
{
    public class FtStringIntegerPartEvaluator : IFtStringIntegerPartEvaluator
    {
        public double EvaluateIntegerPart(string s)
        {
            double returnValue = 0;

            if (string.IsNullOrEmpty(s)) return returnValue;

            int n = s.IndexOf("'");
            
            if (n > 0)
            {
                returnValue = System.Convert.ToDouble(s.Substring(0, n));
            }
            
            return returnValue / 3.2808;
        }
    }
}
