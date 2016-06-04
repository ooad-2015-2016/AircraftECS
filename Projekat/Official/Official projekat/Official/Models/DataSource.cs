using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Official.Models
{
   public class DataSource
    {
        private static List<Korisnik> Korisnici = new List<Korisnik>()
        {
            new Korisnik()
            {
                Ime = "Dino",
                Prezime = "Zivojevic",
                ID = "1",
            },

           new Korisnik()
           {
            Ime = "Bilal",
            Prezime = "Sehovic",
            ID = "2",
           },

           new Korisnik()
           {
               Ime = "Harun",
               Prezime = "Dizdar",
               ID = "3",
           },

           new Korisnik()
           {
               Ime = "Meliha",
               Prezime = "Mesanovic",
               ID = "4",
           }
        };

        public static IList<Korisnik> DajSveKorisnike()
        {
            return Korisnici;
        }

        public static Korisnik DajKorisnikaPoId(string ID)
        {
            return Korisnici.Where(k => k.ID.Equals(ID)).FirstOrDefault();
        }

        public static Korisnik ProvjeraKorisnika(string korisnickoIme, string Prezime, string ID)
        {
            Korisnik rezultat = new Korisnik();
            foreach (var k in DajSveKorisnike())
            {
                if (k.Ime == korisnickoIme && k.Prezime == Prezime && k.ID == ID) rezultat = k;
            }
            return rezultat;
        }

        public static void DodajKorisnika(string ime, string prezime, string id)
        {
            DajSveKorisnike().Add(new Korisnik());
            int i = DajSveKorisnike().Count;

            DajSveKorisnike()[i - 1].Ime = ime;
            DajSveKorisnike()[i - 1].Prezime = prezime;
            DajSveKorisnike()[i - 1].ID = id;
        }

    }
}
