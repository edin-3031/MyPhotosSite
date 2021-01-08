using Microsoft.AspNetCore.Mvc;
using MyUniqueNature.Data;
using MyUniqueNature.Models;
using MyUniqueNature.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniqueNature.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LokacijaController : Controller
    {
        private readonly ApplicationDbContext db;

        public LokacijaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index(string sortBy)
        {
            ViewBag.SortNameParameter = string.IsNullOrEmpty(sortBy) ? "Name decs" : "";

            List<Lokacija> locations = db.Lokacija.AsQueryable().ToList();

            switch (sortBy)
            {
                case "Name decs":locations = locations.OrderByDescending(x => x.Naziv).ToList();break;
                default: locations = locations.OrderBy(x => x.Naziv).ToList(); break;
            }

            lista_lokacijaVM model = new lista_lokacijaVM
            {
                lista_lokacija = locations
            };

            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult AddSave(string naziv)
        {
            Lokacija l = new Lokacija
            {
                Naziv = naziv
            };

            db.Add(l);
            db.SaveChanges();

            return Redirect("/Admin/Lokacija/Index");
        }
        public IActionResult Delete(int id)
        {
            Lokacija l = db.Lokacija.Where(a => a.LokacijaID == id).FirstOrDefault();

            if (l != null)
            {
                db.Remove(l);
                db.SaveChanges();
            }

            return Redirect("/Admin/Lokacija/Index");
        }
        public IActionResult Edit(int id)
        {
            Lokacija l = db.Lokacija.Where(a => a.LokacijaID == id).FirstOrDefault();

            ViewData["lokacija"] = l;

            return View();
        }
        public IActionResult EditSave(int id, string naziv)
        {
            Lokacija l = db.Lokacija.Where(a => a.LokacijaID == id).FirstOrDefault();

            l.Naziv = naziv;

            db.SaveChanges();

            return Redirect("/Admin/Lokacija/Index");
        }
    }
}