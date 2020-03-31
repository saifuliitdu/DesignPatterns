using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtToMeterConverterProject
{

    public interface IFtStringEvaluator
    {
        double Evaluate(string s);
    }
}
