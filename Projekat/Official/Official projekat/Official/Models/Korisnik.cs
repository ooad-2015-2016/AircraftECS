using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Official.Models
{
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ID { get; set; }

        public Korisnik() { Ime = "Neki"; Prezime = "Korisnik"; ID = "999"; }

    }
}
