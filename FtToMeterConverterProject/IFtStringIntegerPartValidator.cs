using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtToMeterConverterProject
{
    public interface IFtStringIntegerPartValidator
    {
        bool ValidateIntegerPart(string s);
    }

    public interface IFtStringFractionPartValidator
    {
        bool ValidateFractionPart(string s);
    }
}
