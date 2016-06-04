using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Official.ViewModels
{
    class ProvjeritiKorisnika
    {
        //Ovo treba da bude klasa koja vrsi manipulaciju nad bazom u paketu Models
        public static Boolean PostojiLi (string ime, string prezime, string id)
        {
            for (int i=0; i< Official.Models.DataSource.DajSveKorisnike().Count; i++)
            {
                if(Official.Models.DataSource.DajSveKorisnike()[i].Ime == ime && Official.Models.DataSource.DajSveKorisnike()[i].Prezime == prezime && Official.Models.DataSource.DajSveKorisnike()[i].ID == id)
                {
                    return true;
                }

            }
            return false;
        }

        public static void Dodaj (string ime, string prezime, string id)
        {
            if(!PostojiLi(ime, prezime, id))
            {
                Official.Models.DataSource.DodajKorisnika(ime, prezime, id);
            }
           }
    }
}
