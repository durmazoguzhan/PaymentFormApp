using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection; //Reflection

namespace OdemeFormApp
{
    public class OdemeIslemiFactory
    {
        public IOdemeTipi GetInstance(string className)
        {
            var yeniClass = Assembly.GetAssembly(typeof(IOdemeTipi)).CreateInstance("OdemeFormApp." + className);
            return (IOdemeTipi)yeniClass;
        }
    }
}
