using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace MyUniqueNature.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    LokacijaID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.LokacijaID);
                });

            migrationBuilder.CreateTable(
                name: "Uredjaj",
                columns: table => new
                {
                    UredjajID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uredjaj", x => x.UredjajID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Hash = table.Column<string>(nullable: true),
                    Salt = table.Column<string>(nullable: true),
                    Datum_Rodjenja = table.Column<DateTime>(nullable: false),
                    Uloga = table.Column<string>(nullable: true),
                    Lokacija_FK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK_Korisnik_Lokacija_Lokacija_FK",
                        column: x => x.Lokacija_FK,
                        principalTable: "Lokacija",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slika",
                columns: table => new
                {
                    SlikaID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Lokacija_FK = table.Column<int>(nullable: false),
                    Uredjaj_FK = table.Column<int>(nullable: false),
                    Materijal = table.Column<byte[]>(nullable: true),
                    DatumSlikanja = table.Column<DateTime>(nullable: false),
                    DatumPostavljanja = table.Column<DateTime>(nullable: false),
                    Izmijenjena = table.Column<bool>(nullable: false),
                    Veličina = table.Column<string>(nullable: true),
                    Dimenzije = table.Column<string>(nullable: true),
                    BrojPregleda = table.Column<int>(nullable: false),
                    BrojPreuzimanja = table.Column<int>(nullable: false),
                    SkoroObjavljena = table.Column<bool>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slika", x => x.SlikaID);
                    table.ForeignKey(
                        name: "FK_Slika_Lokacija_Lokacija_FK",
                        column: x => x.Lokacija_FK,
                        principalTable: "Lokacija",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Slika_Uredjaj_Uredjaj_FK",
                        column: x => x.Uredjaj_FK,
                        principalTable: "Uredjaj",
                        principalColumn: "UredjajID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Komentar",
                columns: table => new
                {
                    KomentarID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    slika_FK = table.Column<int>(nullable: false),
                    Sadržaj = table.Column<string>(nullable: true),
                    Pozitivno = table.Column<int>(nullable: false),
                    Negativno = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentar", x => x.KomentarID);
                    table.ForeignKey(
                        name: "FK_Komentar_Slika_slika_FK",
                        column: x => x.slika_FK,
                        principalTable: "Slika",
                        principalColumn: "SlikaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_slika_FK",
                table: "Komentar",
                column: "slika_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Lokacija_FK",
                table: "Korisnik",
                column: "Lokacija_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Slika_Lokacija_FK",
                table: "Slika",
                column: "Lokacija_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Slika_Uredjaj_FK",
                table: "Slika",
                column: "Uredjaj_FK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Komentar");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Slika");

            migrationBuilder.DropTable(
                name: "Lokacija");

            migrationBuilder.DropTable(
                name: "Uredjaj");
        }
    }
}
