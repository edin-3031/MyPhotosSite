using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniqueNature.Models
{
    public class Komentar
    {
        [Key]
        public int KomentarID { get; set; }

        public Slika slika { get; set; }
        [ForeignKey("slika")]
        public int slika_FK { get; set; }

        public string Sadržaj { get; set; }

        public int Pozitivno { get; set; }
        public int Negativno { get; set; }
    }
}