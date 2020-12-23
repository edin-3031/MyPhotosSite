using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniqueNature.Models
{
    public class Slika
    {
        [Key]
        public int SlikaID { get; set; }

        public Lokacija lokacija { get; set; }
        [ForeignKey("lokacija")]
        public int Lokacija_FK { get; set; }

        public Uredjaj uredjaj { get; set; }
        [ForeignKey("uredjaj")]
        public int Uredjaj_FK { get; set; }

        public byte[] Materijal { get; set; }
        public DateTime DatumSlikanja { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public bool Izmijenjena { get; set; }
        public string Veličina { get; set; }
        public string Dimenzije { get; set; }
        public int BrojPregleda { get; set; }
        public int BrojPreuzimanja { get; set; }
        public bool SkoroObjavljena { get; set; }
        public int Ocjena { get; set; }
    }
}