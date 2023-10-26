using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormApp
{
    public class SmsOdeme : IOdemeTipi
    {
        public string Ode(double tutar)
        {
            return tutar + " TL SMS ile ödeme yapıldı.";
        }
    }
}
