using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniqueNature.Models
{
    public class Korisnik
    {
        [Key]
        public int KorisnikID { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public string KorisnickoIme { get; set; }
        public string Mail { get; set; }
        public DateTime Datum_Rodjenja { get; set; }
        public bool Aktivirano { get; set; }

        public Uloga uloga { get; set; }
        [ForeignKey("uloga")]
        public int Uloga_FK { get; set; }

        public Lokacija lokacija{ get; set; }
        [ForeignKey("lokacija")]
        public int Lokacija_FK { get; set; }
    }
}
