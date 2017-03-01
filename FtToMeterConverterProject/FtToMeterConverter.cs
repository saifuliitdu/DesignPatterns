using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtToMeterConverterProject
{
    public class FtToMeterConverter : IFtToMeterConverter
    {
        IFtStringValidator validator;
        IFtStringEvaluator evaluator;
        public FtToMeterConverter(IFtStringValidator validator, IFtStringEvaluator evaluator)
        {
            this.validator = validator;
            this.evaluator = evaluator;
        }

        public FtToMeterConverter(IFtStringValidator validator)
        {
            this.validator = validator;
        }
        public double Convert(string s)
        {
            if (validator.Validate(s)) return evaluator.Evaluate(s);
            else return 0;
        }
    }

    public class MockFtToMeterConverter : IFtToMeterConverter
    {
        public double Convert(string s)
        {
            int n1 = s.IndexOf("'");
            int n2 = s.IndexOf("\"");
            double d1 = 0;
            double d2 = 0;
            if (n1 != -1)
            {
                d1 = System.Convert.ToDouble(s.Substring(0, n1));
            }

            if (n2 != -1)
            {
                d2 = System.Convert.ToDouble(s.Substring(n1 + 1, n2 - n1 - 1)) / 12;
            }
            return (d1 + d2)/ 3.2808;
        }
    }
}
