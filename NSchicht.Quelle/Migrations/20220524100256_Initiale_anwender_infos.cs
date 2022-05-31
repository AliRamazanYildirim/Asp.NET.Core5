using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NSchicht.Quelle.Migrations
{
    public partial class Initiale_anwender_infos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnwenderNachrichten",
                columns: table => new
                {
                    AnwenderNachrichtID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Absender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empfaenger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gegenstand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inhalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnwenderNachrichten", x => x.AnwenderNachrichtID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnwenderNachrichten");
        }
    }
}
