using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NSchicht.Quelle.Migrations
{
    public partial class Initiale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aktenmappen",
                columns: table => new
                {
                    PortfolioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktenmappen", x => x.PortfolioID);
                });

            migrationBuilder.CreateTable(
                name: "Dienste",
                columns: table => new
                {
                    DienstID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dienste", x => x.DienstID);
                });

            migrationBuilder.CreateTable(
                name: "Eigenschaften",
                columns: table => new
                {
                    EigenschaftID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eigenschaften", x => x.EigenschaftID);
                });

            migrationBuilder.CreateTable(
                name: "Erfahrungen",
                columns: table => new
                {
                    ErfahrungID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BildUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Erfahrungen", x => x.ErfahrungID);
                });

            migrationBuilder.CreateTable(
                name: "Faehigkeiten",
                columns: table => new
                {
                    FaehigkeitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wert = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faehigkeiten", x => x.FaehigkeitID);
                });

            migrationBuilder.CreateTable(
                name: "Kontakte",
                columns: table => new
                {
                    KontaktID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonNummer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontakte", x => x.KontaktID);
                });

            migrationBuilder.CreateTable(
                name: "Nachrichten",
                columns: table => new
                {
                    NachrichtID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inhalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nachrichten", x => x.NachrichtID);
                });

            migrationBuilder.CreateTable(
                name: "Referenze",
                columns: table => new
                {
                    ReferenzID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unternehmen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referenze", x => x.ReferenzID);
                });

            migrationBuilder.CreateTable(
                name: "SozialeKontakte",
                columns: table => new
                {
                    SozialerKontaktID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ikon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SozialeKontakte", x => x.SozialerKontaktID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aktenmappen");

            migrationBuilder.DropTable(
                name: "Dienste");

            migrationBuilder.DropTable(
                name: "Eigenschaften");

            migrationBuilder.DropTable(
                name: "Erfahrungen");

            migrationBuilder.DropTable(
                name: "Faehigkeiten");

            migrationBuilder.DropTable(
                name: "Kontakte");

            migrationBuilder.DropTable(
                name: "Nachrichten");

            migrationBuilder.DropTable(
                name: "Referenze");

            migrationBuilder.DropTable(
                name: "SozialeKontakte");
        }
    }
}
