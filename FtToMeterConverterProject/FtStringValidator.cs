using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtToMeterConverterProject
{
    public class FtStringValidator : IFtStringValidator
    {
        IFtStringIntegerPartValidator integerPartValidator;
        IFtStringFractionPartValidator fractionPartValidator;

        public FtStringValidator(IFtStringIntegerPartValidator integerPartValidator, IFtStringFractionPartValidator fractionPartValidator)
        {
            this.integerPartValidator = integerPartValidator;
            this.fractionPartValidator = fractionPartValidator;
        }
        public bool Validate(string s)
        {
            return integerPartValidator.ValidateIntegerPart(s) && fractionPartValidator.ValidateFractionPart(s);
        }
    }

}
