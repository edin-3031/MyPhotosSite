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
    public class AjaxController : Controller
    {
        private readonly ApplicationDbContext db;

        public AjaxController(ApplicationDbContext _db)
        {
            db = _db;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditPass(int id)
        {
            korisnikVM k = db.Korisnik.Include(a => a.lokacija).Include(a => a.uloga).Where(a => a.KorisnikID == id).Select(x => new korisnikVM
            {                
                hash = x.Hash,
                id=x.KorisnikID
            }).FirstOrDefault();

            ViewData["korisnik"] = k;

            return PartialView();
        }

        public void Mail(Korisnik k, string pass)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("MyUniqueNature", "myuniquenatur@gmail.com"));
            message.To.Add(new MailboxAddress(k.KorisnickoIme, k.Mail));
            message.Subject = "Welcome To My Unique Nature";
            message.Body = new TextPart("plain")
            {
                Text = "Hello " + k.Ime + " " + k.Prezime + ",\n\n Your password has been successfuly changed. The new password is: " + pass
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("myuniquenatur@gmail.com", "Maglaj2021");

                client.Send(message);

                client.Disconnect(true);
            }
        }

        public IActionResult EditPassSave(int id, string psw, string psw2, string psw2_confirm)
        {
            Korisnik k = db.Korisnik.Where(a => a.KorisnikID == id).FirstOrDefault();

            var hash_psw = GenerateHash(k.Salt, psw);

            if (k.Hash == hash_psw)
            {
                var hash_psw2 = GenerateHash(k.Salt, psw2);

                if (hash_psw2 != k.Hash)
                {
                    if (psw2 == psw2_confirm)
                    {
                        k.Hash = GenerateHash(k.Salt, psw2_confirm);
                        db.SaveChanges();
                        TempData["pass_poruka"] = "Uspješno ste promijenili šifru";

                        Mail(k, psw2_confirm);
                    }
                    else
                    {
                        TempData["pass_poruka"] = "Neispravno potvrđena nova šifra";
                    }
                }
                else
                {
                    TempData["pass_poruka"] = "Nova šifra ne može biti kao postojeća";
                }
            }
            else
            {
                TempData["pass_poruka"] = "Neispravno unesena trenutna šifra";
            }

            return Redirect("/Admin/Korisnik/Edit?id=" + id);
        }
    }
}