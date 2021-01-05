using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyUniqueNature.Data;
using MyUniqueNature.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyUniqueNature.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext db;

        public AuthController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Home()
        {
            return View();
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

        public IActionResult AuthProcess(string mail_username, string pass)
        {
            LoginVM log = null;
            string _salt,_hash;

            if (mail_username != null && pass != null)
            {

                if (mail_username.Contains('@'))
                {
                    _salt = db.Korisnik.Where(a => a.Mail == mail_username).Select(o => o.Salt).FirstOrDefault();

                    _hash = GenerateHash(_salt, pass);

                    log = db.Korisnik.Where(a => a.Mail == mail_username && a.Hash == _hash).Include(a => a.uloga).Select(x => new LoginVM
                    {
                        KorisnikId = x.KorisnikID,
                        ime_prezime = x.Ime.ToString() + " " + x.Prezime.ToString(),
                        korisnicko_ime = x.KorisnickoIme.ToString(),
                        uloga = x.uloga.Naziv,
                        ulogaId = x.uloga.UlogaID,
                        hash = x.Hash,
                        salt = x.Salt
                    }).FirstOrDefault();

                    if (log != null)
                    {
                        HttpContext.Session.SetInt32("UserID", log.KorisnikId);
                        HttpContext.Session.SetString("Username", log.korisnicko_ime);
                        HttpContext.Session.SetString("Name", log.ime_prezime);
                    }
                }
                else
                {
                    _salt = db.Korisnik.Where(a => a.KorisnickoIme == mail_username).Select(o => o.Salt).FirstOrDefault();

                    if (_salt != null)
                    {
                        _hash = GenerateHash(_salt, pass);

                        log = db.Korisnik.Where(a => a.KorisnickoIme == mail_username && a.Hash == _hash).Include(a => a.uloga).Select(x => new LoginVM
                        {
                            KorisnikId = x.KorisnikID,
                            ime_prezime = x.Ime.ToString() + " " + x.Prezime.ToString(),
                            korisnicko_ime = x.KorisnickoIme.ToString(),
                            uloga = x.uloga.Naziv,
                            ulogaId = x.uloga.UlogaID,
                            hash = x.Hash,
                            salt = x.Salt
                        }).FirstOrDefault();

                        if (log != null)
                        {
                            HttpContext.Session.SetInt32("UserID", log.KorisnikId);
                            HttpContext.Session.SetString("Username", log.korisnicko_ime);
                            HttpContext.Session.SetString("Name", log.ime_prezime);
                        }
                    }
                }

                if (log == null)
                {
                    TempData["Poruka_Greška"] = "You Entered Invalid Data";

                    return Redirect("/Home/Index");
                }

                switch (log.uloga)
                {
                    case "Admin": return Redirect("/Admin/Home/Index");
                    case "User": return Redirect("/User/Home/Index");
                }

                return Redirect("/Auth/Home");
            }
            else
            {
                TempData["Poruka_Greška"] = "Enter All Required Data";
                return Redirect("/Home/Index");
            }
        }
    }
}
