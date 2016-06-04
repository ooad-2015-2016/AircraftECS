using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Official.ViewModels
{
    class UnosParametaraViewModel
    {
        public static double DajBrzinu() { return Official.Models.BazaParametara.DajSveParametre()[0].brzina; }
        public static double DajVisinu() { return Official.Models.BazaParametara.DajSveParametre()[0].visina; }
        public static double DajKurs() { return Official.Models.BazaParametara.DajSveParametre()[0].kurs; }
        public static double DajUgaoKrila() { return Official.Models.BazaParametara.DajSveParametre()[0].ugaoKrila; }
        public static double DajTemperaturu() { return Official.Models.BazaParametara.DajSveParametre()[0].temperatura; }
        public static double DajPritisak() { return Official.Models.BazaParametara.DajSveParametre()[0].pritisak; }

        public static void Dodaj(double vis, double br, double ku, double uK, double tem, double pri)
        {
                Official.Models.BazaParametara.DodajParametre(vis, br, ku, uK, tem, pri);
            
        }
    }
}
