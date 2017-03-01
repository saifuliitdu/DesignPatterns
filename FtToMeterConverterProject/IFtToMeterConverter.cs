using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtToMeterConverterProject
{
    public interface IFtToMeterConverter
    {
        double Convert(string s);
    }

    public interface IFtToMeterConverter2
    {

        double Converttwo(string s);
    }
}
