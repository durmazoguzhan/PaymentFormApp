using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormApp
{
    public class KrediKarti : IOdemeTipi
    {
        public string Ode(double tutar)
        {
            return tutar + " TL Kredi Kartı ile ödeme yapıldı.";
        }
    }
}
