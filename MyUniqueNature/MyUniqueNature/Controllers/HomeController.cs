using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using MyUniqueNature.Data;
using MyUniqueNature.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyUniqueNature.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _db)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult Index()
        {
            List<Lokacija> lokacija = db.Lokacija.ToList();


            ViewData["lokacije"] = lokacija;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

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

        public IActionResult Register(string ime, string prezime, string mail, string password, DateTime datum, int lokacija)
        {
            Korisnik k = new Korisnik
            {
                Aktivirano = true,
                Datum_Rodjenja = datum,
                Ime = ime,
                Prezime = prezime,
                KorisnickoIme = ime.ToLower() + "." + prezime.ToLower(),
                Lokacija_FK = lokacija,
                Mail = mail,
                Salt=GenerateSalt()
            };

            k.Hash = GenerateHash(k.Salt, password);

            Uloga uloga = db.Uloga.Where(a => a.Naziv == "User").FirstOrDefault();
            k.Uloga_FK = uloga.UlogaID;

            bool postoji=CheckExistance(k.KorisnickoIme);

            if (postoji)
            {
                do
                {
                    k.KorisnickoIme = AddNumber(k.KorisnickoIme);
                    postoji=CheckExistance(k.KorisnickoIme);
                } while (postoji);
            }

            db.Add(k);
            db.SaveChanges();

            TempData["Poruka_Greška"] = "Check Your Mail";

            Mail(k, password);

            return Redirect("/Home/Index");
        }

        public string AddNumber(string username)
        {
            Random rnd = new Random();

           return username += rnd.Next(1,99).ToString();

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

        public void Mail(Korisnik k, string pass)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("MyUniqueNature", "myuniquenatur@gmail.com"));
            message.To.Add(new MailboxAddress(k.KorisnickoIme,k.Mail));
            message.Subject = "Welcome To My Unique Nature";
            message.Body = new TextPart("plain")
            {
                Text = "Hello " + k.Ime + " " + k.Prezime + ",\n\n We wanna welcome You to our site and further in this message is your log in data. Enjoy :)\n\n\nUsername: " + k.KorisnickoIme + "\nPassword: " + pass
            };

            using(var client=new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("myuniquenatur@gmail.com", "Maglaj2021");

                client.Send(message);

                client.Disconnect(true);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
