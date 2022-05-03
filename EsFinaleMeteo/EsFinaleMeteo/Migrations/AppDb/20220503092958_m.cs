using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EsFinaleMeteo.Migrations.AppDb
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCittà",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Stato = table.Column<string>(type: "TEXT", nullable: true),
                    Long = table.Column<double>(type: "REAL", nullable: false),
                    Lat = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCittà", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DatiMeteo",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    luogoid = table.Column<int>(type: "INTEGER", nullable: true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MinT = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxT = table.Column<int>(type: "INTEGER", nullable: false),
                    AvgT = table.Column<int>(type: "INTEGER", nullable: false),
                    PercP = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatiMeteo", x => x.id);
                    table.ForeignKey(
                        name: "FK_DatiMeteo_DCittà_luogoid",
                        column: x => x.luogoid,
                        principalTable: "DCittà",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatiMeteo_luogoid",
                table: "DatiMeteo",
                column: "luogoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatiMeteo");

            migrationBuilder.DropTable(
                name: "DCittà");
        }
    }
}
