using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Official.Models
{
    class Parametri
    {
        public double visina;
        public double brzina;
        public double kurs;
        public double ugaoKrila;
        public double temperatura;
        public double pritisak;

        
        public Parametri() { visina = 0; brzina = 0; kurs = 0; ugaoKrila = 0; }
        public void PostaviVisinu(double v) { visina = v; }
        public double ProcitajVisinu() { return visina; }
        public void PostaviBrzinu(double b) { brzina = b; }
        public double ProcitajBrzinu() { return brzina; }
        public void PostaviKurs(double k) { kurs = k; }
        public double ProcitajKurs() { return kurs; }
        public void PostaviUgaoKrila(int u) { ugaoKrila = u; }
        public double ProcitajUgaoKrila() { return ugaoKrila; }
        public void PostaviTemperaturu(double t) { temperatura = t; }
        public double ProcitajTemperaturu() { return temperatura; }
        public void PostaviPritisak(double p) { pritisak = p; }
        public double ProcitajPritisak() { return pritisak; }
    }
}
