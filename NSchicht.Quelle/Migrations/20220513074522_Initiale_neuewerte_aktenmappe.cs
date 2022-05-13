using Microsoft.EntityFrameworkCore.Migrations;

namespace NSchicht.Quelle.Migrations
{
    public partial class Initiale_neuewerte_aktenmappe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Preis",
                table: "Aktenmappen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Projekt",
                table: "Aktenmappen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjektBild1",
                table: "Aktenmappen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjektBild2",
                table: "Aktenmappen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjektBild3",
                table: "Aktenmappen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjektBild4",
                table: "Aktenmappen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Proportion",
                table: "Aktenmappen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Aktenmappen",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preis",
                table: "Aktenmappen");

            migrationBuilder.DropColumn(
                name: "Projekt",
                table: "Aktenmappen");

            migrationBuilder.DropColumn(
                name: "ProjektBild1",
                table: "Aktenmappen");

            migrationBuilder.DropColumn(
                name: "ProjektBild2",
                table: "Aktenmappen");

            migrationBuilder.DropColumn(
                name: "ProjektBild3",
                table: "Aktenmappen");

            migrationBuilder.DropColumn(
                name: "ProjektBild4",
                table: "Aktenmappen");

            migrationBuilder.DropColumn(
                name: "Proportion",
                table: "Aktenmappen");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Aktenmappen");
        }
    }
}
