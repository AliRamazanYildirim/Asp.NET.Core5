using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NSchicht.Quelle.Migrations
{
    public partial class Initiale_anwendernachricht_revision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BenutzerNachrichten");

            migrationBuilder.DropTable(
                name: "Benutzers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benutzers",
                columns: table => new
                {
                    BenutzerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BenutzerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nachname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Passwort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benutzers", x => x.BenutzerID);
                });

            migrationBuilder.CreateTable(
                name: "BenutzerNachrichten",
                columns: table => new
                {
                    NachrichtID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BenutzerID = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inhalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenutzerNachrichten", x => x.NachrichtID);
                    table.ForeignKey(
                        name: "FK_BenutzerNachrichten_Benutzers_BenutzerID",
                        column: x => x.BenutzerID,
                        principalTable: "Benutzers",
                        principalColumn: "BenutzerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BenutzerNachrichten_BenutzerID",
                table: "BenutzerNachrichten",
                column: "BenutzerID");
        }
    }
}
