using Microsoft.EntityFrameworkCore.Migrations;

namespace NSchicht.Quelle.Migrations
{
    public partial class Initiale_anwender_infos_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AbsenderName",
                table: "AnwenderNachrichten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpfaengerName",
                table: "AnwenderNachrichten",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbsenderName",
                table: "AnwenderNachrichten");

            migrationBuilder.DropColumn(
                name: "EmpfaengerName",
                table: "AnwenderNachrichten");
        }
    }
}
