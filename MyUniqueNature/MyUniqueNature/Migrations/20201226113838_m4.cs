using Microsoft.EntityFrameworkCore.Migrations;

namespace MyUniqueNature.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KorisnickoIme",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Korisnik",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KorisnickoIme",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Korisnik");
        }
    }
}
