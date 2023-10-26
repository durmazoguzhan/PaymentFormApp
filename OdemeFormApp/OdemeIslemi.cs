using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormApp
{
    public class OdemeIslemi
    {
        private IOdemeTipi odemeTipi;

        public OdemeIslemi(IOdemeTipi odemeTipi)
        {
            this.odemeTipi = odemeTipi;
        }

        public string OdemeYap(double tutar)
        {
            return odemeTipi.Ode(tutar);
        }
    }
}
