using Microsoft.AspNetCore.Mvc;
using MyUniqueNature.Data;
using MyUniqueNature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniqueNature.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UlogaController : Controller
    {
        private readonly ApplicationDbContext db;

        public UlogaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            List<Uloga> uloge = db.Uloga.ToList();

            ViewData["uloge"] = uloge;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult AddSave(string naziv)
        {
            Uloga u = new Uloga
            {
                Naziv = naziv
            };

            db.Add(u);
            db.SaveChanges();

            return Redirect("/Admin/Uloga/index");
        }

        public IActionResult Edit(int id)
        {
            ViewData["uloga"] = db.Uloga.Where(a => a.UlogaID == id).FirstOrDefault();

            return View();
        }

        public IActionResult EditSave(int id, string naziv)
        {
            Uloga u=db.Uloga.Where(a => a.UlogaID == id).FirstOrDefault();
            u.Naziv = naziv;

            db.SaveChanges();

            return Redirect("/Admin/Uloga/Index");
        }

        public IActionResult Delete(int id)
        {
            Uloga u = db.Uloga.Where(a => a.UlogaID == id).FirstOrDefault();
            db.Remove(u);
            db.SaveChanges();

            return Redirect("/Admin/Uloga/Index");

        }
    }
}
