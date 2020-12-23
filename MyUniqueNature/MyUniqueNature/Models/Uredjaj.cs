using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniqueNature.Models
{
    public class Uredjaj
    {
        [Key]
        public int UredjajID { get; set; }

        public string Naziv { get; set; }
    }
}
