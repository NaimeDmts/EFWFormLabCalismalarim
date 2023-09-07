using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KisiNot.Repository.Migrations
{
    public partial class intialCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kullaniciAdi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip = table.Column<int>(type: "int", nullable: false),
                    Statu = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotIcerigi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    Statu = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nots_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kullanicis",
                columns: new[] { "Id", "Ad", "CreateDate", "DeleteDate", "Sifre", "Soyad", "Statu", "Tip", "UpdateDate", "kullaniciAdi" },
                values: new object[] { 1, "Naime", new DateTime(2023, 9, 7, 9, 55, 22, 28, DateTimeKind.Local).AddTicks(9454), null, "1*Naime", "Damataşı", 0, 1, null, "ndmts" });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_kullaniciAdi",
                table: "Kullanicis",
                column: "kullaniciAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nots_KullaniciId",
                table: "Nots",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nots");

            migrationBuilder.DropTable(
                name: "Kullanicis");
        }
    }
}
