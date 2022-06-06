using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.Net_Core_API.Migrations
{
    public partial class Initiale_neu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "kategorien",
                newName: "KategorieName");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "kategorien",
                newName: "KategorieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KategorieName",
                table: "kategorien",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "KategorieID",
                table: "kategorien",
                newName: "CategoryID");
        }
    }
}
