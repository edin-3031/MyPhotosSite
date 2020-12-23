using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace MyUniqueNature.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uloga",
                table: "Korisnik");

            migrationBuilder.AddColumn<int>(
                name: "Uloga_FK",
                table: "Korisnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Uloga_FK",
                table: "Korisnik",
                column: "Uloga_FK");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Uloga_Uloga_FK",
                table: "Korisnik",
                column: "Uloga_FK",
                principalTable: "Uloga",
                principalColumn: "UlogaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Uloga_Uloga_FK",
                table: "Korisnik");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_Uloga_FK",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Uloga_FK",
                table: "Korisnik");

            migrationBuilder.AddColumn<string>(
                name: "Uloga",
                table: "Korisnik",
                type: "text",
                nullable: true);
        }
    }
}
