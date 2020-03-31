using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtToMeterConverterProject
{

    public interface IFtStringFractionPartEvaluator
    {
        double EvaluateFractionPart(string s);
    }
}
