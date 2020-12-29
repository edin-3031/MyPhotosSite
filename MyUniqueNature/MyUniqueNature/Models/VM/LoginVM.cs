using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniqueNature.Models.VM
{
    public class LoginVM
    {
        public int KorisnikId { get; set; }
        public string ime_prezime { get; set; }
        public int ulogaId { get; set; }
        public string uloga { get; set; }
        public string korisnicko_ime { get; set; }
        public string salt { get; set; }
        public string hash { get; set; }
    }
}
