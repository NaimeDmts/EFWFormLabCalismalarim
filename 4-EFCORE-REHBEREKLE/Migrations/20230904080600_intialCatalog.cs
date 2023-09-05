using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4_EFCORE_REHBEREKLE.Migrations
{
    public partial class intialCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisis",
                columns: table => new
                {
                    KisiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisis", x => x.KisiId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kisis_Telefon",
                table: "Kisis",
                column: "Telefon",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kisis");
        }
    }
}
