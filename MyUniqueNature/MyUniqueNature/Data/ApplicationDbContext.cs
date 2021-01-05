using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyUniqueNature.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyUniqueNature.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Komentar> Komentar{ get; set; }
        public DbSet<Korisnik> Korisnik{ get; set; }
        public DbSet<Lokacija> Lokacija{ get; set; }
        public DbSet<Slika> Slika{ get; set; }
        public DbSet<Uredjaj> Uredjaj{ get; set; }
        public DbSet<Oznaka> Oznaka{ get; set; }
        public DbSet<Uloga> Uloga{ get; set; }
        public DbSet<slika_oznaka> Slika_Oznaka{ get; set; }
    }
}
