using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Official.Models
{
    class BazaParametara
    {
        private static List<Parametri> parametri = new List<Parametri>();

        public static IList<Parametri> DajSveParametre()
        {
            return parametri;
        }

        public static void DodajParametre(double vis, double brz, double kur, double uK, double tem, double pri)
        {
            DajSveParametre().Add(new Parametri());
            //int i = DajSveParametre().Count;

            DajSveParametre()[0].visina = vis;
            DajSveParametre()[0].brzina = brz;
            DajSveParametre()[0].kurs = kur;
            DajSveParametre()[0].ugaoKrila = uK;
            DajSveParametre()[0].temperatura = tem;
            DajSveParametre()[0].pritisak = pri;
        }
    }
}
