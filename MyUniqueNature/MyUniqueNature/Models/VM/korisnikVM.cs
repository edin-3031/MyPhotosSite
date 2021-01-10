using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniqueNature.Models.VM
{
    public class korisnikVM
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datum_rodjenja { get; set; }
        public string lokacija { get; set; }
        public int lokacija_fk { get; set; }
        public string uloga { get; set; }
        public int uloga_fk { get; set; }
        public string korisnicko_ime { get; set; }
        public string mail { get; set; }
        public int godine { get; set; }
        public string hash{ get; set; }
    }

    public class lista_korisnikVM
    {
        public List<korisnikVM> lista { get; set; }
    }
}
