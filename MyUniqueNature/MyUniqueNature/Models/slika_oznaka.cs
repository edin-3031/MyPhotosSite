using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniqueNature.Models
{
    public class slika_oznaka
    {
        [Key]
        public int slika_oznakaID { get; set; }

        public Slika slika { get; set; }
        [ForeignKey("slika")]
        public int Slika_FK { get; set; }

        public Oznaka oznaka { get; set; }
        [ForeignKey("oznaka")]
        public int Oznaka_FK { get; set; }
    }
}