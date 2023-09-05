using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KisiRehberProject.DAL.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adreses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sehir = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AdresDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KisiId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adreses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adreses_Kisis_KisiId",
                        column: x => x.KisiId,
                        principalTable: "Kisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kisis",
                columns: new[] { "Id", "Ad", "CreateDate", "DeletedDate", "Soyad", "Status", "Telefon", "UpdateDate" },
                values: new object[] { 1, "Sefa", new DateTime(2023, 9, 5, 11, 42, 14, 962, DateTimeKind.Local).AddTicks(5635), null, "Attila", 0, "552 828 1903", null });

            migrationBuilder.InsertData(
                table: "Kisis",
                columns: new[] { "Id", "Ad", "CreateDate", "DeletedDate", "Soyad", "Status", "Telefon", "UpdateDate" },
                values: new object[] { 2, "Ahmet", new DateTime(2023, 9, 5, 11, 42, 14, 962, DateTimeKind.Local).AddTicks(5652), null, "Yılmaz", 0, "552 828 1903", null });

            migrationBuilder.InsertData(
                table: "Adreses",
                columns: new[] { "Id", "AdresDetay", "CreateDate", "DeletedDate", "Ilce", "KisiId", "Sehir", "Status", "UpdateDate" },
                values: new object[] { 1, "YeşilYurt", new DateTime(2023, 9, 5, 11, 42, 14, 962, DateTimeKind.Local).AddTicks(6380), null, "Tosya", 1, "Kastamonu", 0, null });

            migrationBuilder.InsertData(
                table: "Adreses",
                columns: new[] { "Id", "AdresDetay", "CreateDate", "DeletedDate", "Ilce", "KisiId", "Sehir", "Status", "UpdateDate" },
                values: new object[] { 2, "Karanfil", new DateTime(2023, 9, 5, 11, 42, 14, 962, DateTimeKind.Local).AddTicks(6386), null, "Gölbaşı", 1, "Ankara", 0, null });

            migrationBuilder.InsertData(
                table: "Adreses",
                columns: new[] { "Id", "AdresDetay", "CreateDate", "DeletedDate", "Ilce", "KisiId", "Sehir", "Status", "UpdateDate" },
                values: new object[] { 3, "Taşyaka", new DateTime(2023, 9, 5, 11, 42, 14, 962, DateTimeKind.Local).AddTicks(6387), null, "Fethiye", 2, "Muğla", 0, null });

            migrationBuilder.CreateIndex(
                name: "IX_Adreses_KisiId",
                table: "Adreses",
                column: "KisiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adreses");

            migrationBuilder.DropTable(
                name: "Kisis");
        }
    }
}
