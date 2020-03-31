using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace FtToMeterConverterProject
{
    public class InitApp
    {
        public static UnityContainer container { get; set; }
        static InitApp()
        {
            container = new UnityContainer();

            //container.RegisterType<IFtStringEvaluator, FtStringEvaluator>();
            //container.RegisterType<IFtStringValidator, FtStringValidator>();
            container.RegisterType<IFtToMeterConverter, MockFtToMeterConverter>();
        }
    }
}
