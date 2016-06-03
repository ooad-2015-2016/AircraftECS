using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Official.Models
{
    class Pilot
    {
        private string ime;
        private string prezime;
        private int ID;

        public void UnesiIme(string i) { ime = i; }
        public string DajIme() { return ime; }
        public void UnesiPrezime(string p) { prezime = p; }
        public string DajPrezime() { return prezime; }
        public void PostaviID(int id) { ID = id; }
        public int DajID() { return ID; }
        
    }
}
