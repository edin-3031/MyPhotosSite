using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MyUniqueNature.Data;
using MyUniqueNature.Models;
using MyUniqueNature.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyUniqueNature.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KorisnikController : Controller
    {
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        private readonly ApplicationDbContext db;

        public KorisnikController(ApplicationDbContext _db)
        {
            db = _db;
        }

        static public int CalculateYears(DateTime datum)
        {
            int g,m,d;
            DateTime now = DateTime.UtcNow;

            g = now.Date.Year - datum.Date.Year;
            m = now.Date.Month - datum.Date.Month;
            d = now.Date.Day - datum.Date.Day;

            if (g > 0 && (m < 0 || d < 0))
                return g - 1;
            else
                return g;

        }

        public bool CheckExistance(string username)
        {
            List<Korisnik> korisnici = db.Korisnik.ToList();

            foreach (var x in korisnici)
            {
                if (x.KorisnickoIme == username)
                {
                    return true;
                }
            }
            return false;
        }

        public string AddNumber(string username)
        {
            Random rnd = new Random();

            return username += rnd.Next(1, 99).ToString();

        }

        public IActionResult Index()
        {
            List<korisnikVM> lista_k = db.Korisnik.Include(a => a.uloga).Include(a => a.lokacija).Select(x => new korisnikVM
            {
                datum_rodjenja=x.Datum_Rodjenja.Date,
                id=x.KorisnikID,
                ime=x.Ime,
                korisnicko_ime=x.KorisnickoIme,
                lokacija=x.lokacija.Naziv,
                mail=x.Mail,
                prezime=x.Prezime,
                uloga=x.uloga.Naziv,
                godine=CalculateYears(x.Datum_Rodjenja.Date)
            }).ToList();

            lista_korisnikVM model = new lista_korisnikVM
            {
                lista = lista_k
            };

            return View(model);
        }

        public void Mail(Korisnik k, string pass)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("MyUniqueNature", "myuniquenatur@gmail.com"));
            message.To.Add(new MailboxAddress(k.KorisnickoIme, k.Mail));
            message.Subject = "Welcome To My Unique Nature";
            message.Body = new TextPart("plain")
            {
                Text = "Hello " + k.Ime + " " + k.Prezime + ",\n\n We wanna welcome You to our site and further in this message is your log in data. Enjoy :)\n\n\nUsername: " + k.KorisnickoIme + "\nPassword: " + pass
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("myuniquenatur@gmail.com", "Maglaj2021");

                client.Send(message);

                client.Disconnect(true);
            }
        }
        public IActionResult Delete(int id)
        {
            Korisnik k = db.Korisnik.Where(a => a.KorisnikID == id).First();
            db.Remove(k);
            db.SaveChanges();

            return Redirect("/Admin/Korisnik/Index");
        }
        public IActionResult Add()
        {
            List<Uloga> u = db.Uloga.ToList();
            List<Lokacija> l = db.Lokacija.ToList();

            ViewData["uloge"] = u;
            ViewData["lokacije"] = l;

            return View();
        }
        public IActionResult AddSave(string ime, string prezime, string lozinka, DateTime datum, string mail, int lokacija, int uloga)
        {
            Korisnik k = new Korisnik
            {
                Aktivirano = true,
                Datum_Rodjenja = datum,
                Ime = ime,
                KorisnickoIme = ime.ToLower() + "." + prezime.ToLower(),
                Lokacija_FK = lokacija,
                Mail = mail,
                Prezime = prezime,
                Salt = GenerateSalt(),
                Uloga_FK = uloga
            };

            k.Hash = GenerateHash(k.Salt, lozinka);

            bool postoji = CheckExistance(k.KorisnickoIme);

            if (postoji)
            {
                do
                {
                    k.KorisnickoIme = AddNumber(k.KorisnickoIme);
                    postoji = CheckExistance(k.KorisnickoIme);
                } while (postoji);
            }

            db.Add(k);
            db.SaveChanges();

            Mail(k, lozinka);

            return Redirect("/Admin/Korisnik/Index");
        }
        public IActionResult Edit(int id)
        {
            korisnikVM k = db.Korisnik.Include(a => a.lokacija).Include(a => a.uloga).Where(a => a.KorisnikID == id).Select(x => new korisnikVM
            {
                datum_rodjenja=x.Datum_Rodjenja,
                hash=x.Hash,
                ime=x.Ime,
                korisnicko_ime=x.KorisnickoIme,
                id=x.KorisnikID,
                lokacija=x.lokacija.Naziv,
                lokacija_fk=x.lokacija.LokacijaID,
                mail=x.Mail,
                prezime=x.Prezime,
                uloga=x.uloga.Naziv,
                uloga_fk=x.uloga.UlogaID                
            }).FirstOrDefault();

            ViewData["korisnik"] = k;

            List<Uloga> u = db.Uloga.ToList();
            List<Lokacija> l = db.Lokacija.ToList();

            ViewData["uloge"] = u;
            ViewData["lokacije"] = l;

            return View();
        }
        public IActionResult EditSave(int id, string ime, string prezime, DateTime datum, int lokacija, string mail, int uloga)
        {
            Korisnik k = db.Korisnik.Where(a => a.KorisnikID == id).FirstOrDefault();

            k.Ime = ime;
            k.Prezime = prezime;
            k.Datum_Rodjenja = datum;
            k.Lokacija_FK = lokacija;
            k.Mail = mail;
            k.Uloga_FK = uloga;

            db.SaveChanges();

            return Redirect("/Admin/Korisnik/Index");
        }
        public IActionResult EditPass(int id)
        {
            Korisnik k = db.Korisnik.Where(a => a.KorisnikID == id).FirstOrDefault();
            ViewData["korisnik"] = k;

            return View();
        }
    }
}
