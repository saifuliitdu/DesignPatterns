using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtToMeterConverterProject
{
    public interface IFtStringIntegerPartEvaluator
    {
        double EvaluateIntegerPart(string s);
    }

    public interface IFtStringFractionPartEvaluator
    {
        double EvaluateFractionPart(string s);
    }
}
