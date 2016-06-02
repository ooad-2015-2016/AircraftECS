using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Official.PosadaBaza.Models
{
    class ClanPosade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }//primary key u bazi
        public string fourSqaureId { get; set; }//trebati ce za sihronizaciju kasnije
        public string Ime { get; set; } //Ime clana posade u bazu podataka
        public string Prezime { get; set; } //Prezime clana posade u bazi podataka
    }
}
