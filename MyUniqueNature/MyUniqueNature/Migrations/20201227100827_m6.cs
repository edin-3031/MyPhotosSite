using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyUniqueNature.Migrations
{
    public partial class m6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Datum_Vrijeme",
                table: "Komentar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "korisnik_FK",
                table: "Komentar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_korisnik_FK",
                table: "Komentar",
                column: "korisnik_FK");

            migrationBuilder.AddForeignKey(
                name: "FK_Komentar_Korisnik_korisnik_FK",
                table: "Komentar",
                column: "korisnik_FK",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Komentar_Korisnik_korisnik_FK",
                table: "Komentar");

            migrationBuilder.DropIndex(
                name: "IX_Komentar_korisnik_FK",
                table: "Komentar");

            migrationBuilder.DropColumn(
                name: "Datum_Vrijeme",
                table: "Komentar");

            migrationBuilder.DropColumn(
                name: "korisnik_FK",
                table: "Komentar");
        }
    }
}
