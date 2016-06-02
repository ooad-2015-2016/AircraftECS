using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Official.PosadaBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(ClanPosadeDbContext context)
        {
            if (!context.Clanovi.Any())
            {
                context.Clanovi.AddRange(
                new ClanPosade()
                {
                    Ime = "Dino",
                    Prezime = "Zivojevic",
                }
                );
                context.SaveChanges();
            }
        }
    }
}
