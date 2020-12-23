using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace MyUniqueNature.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oznaka",
                columns: table => new
                {
                    OznakaID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oznaka", x => x.OznakaID);
                });

            migrationBuilder.CreateTable(
                name: "Slika_Oznaka",
                columns: table => new
                {
                    slika_oznakaID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Slika_FK = table.Column<int>(nullable: false),
                    Oznaka_FK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slika_Oznaka", x => x.slika_oznakaID);
                    table.ForeignKey(
                        name: "FK_Slika_Oznaka_Oznaka_Oznaka_FK",
                        column: x => x.Oznaka_FK,
                        principalTable: "Oznaka",
                        principalColumn: "OznakaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Slika_Oznaka_Slika_Slika_FK",
                        column: x => x.Slika_FK,
                        principalTable: "Slika",
                        principalColumn: "SlikaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Slika_Oznaka_Oznaka_FK",
                table: "Slika_Oznaka",
                column: "Oznaka_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Slika_Oznaka_Slika_FK",
                table: "Slika_Oznaka",
                column: "Slika_FK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slika_Oznaka");

            migrationBuilder.DropTable(
                name: "Oznaka");
        }
    }
}
