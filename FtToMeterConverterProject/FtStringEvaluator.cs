using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtToMeterConverterProject
{

    public class FtStringEvaluator : IFtStringEvaluator
    {
        IFtStringIntegerPartEvaluator integerPartEvaluator;
        IFtStringFractionPartEvaluator fractionPartEvaluator;

        public FtStringEvaluator(IFtStringIntegerPartEvaluator integerPartEvaluator, IFtStringFractionPartEvaluator fractionPartEvaluator)
        {
            this.integerPartEvaluator = integerPartEvaluator;
            this.fractionPartEvaluator = fractionPartEvaluator;
        }
        public double Evaluate(string s)
        {
            return integerPartEvaluator.EvaluateIntegerPart(s) + fractionPartEvaluator.EvaluateFractionPart(s);
        }
    }
}
