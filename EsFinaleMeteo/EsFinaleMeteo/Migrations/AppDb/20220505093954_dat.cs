using Microsoft.EntityFrameworkCore.Migrations;

namespace EsFinaleMeteo.Migrations.AppDb
{
    public partial class dat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatiCittà",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    country = table.Column<string>(type: "TEXT", nullable: true),
                    timezone = table.Column<string>(type: "TEXT", nullable: true),
                    adminArea = table.Column<string>(type: "TEXT", nullable: true),
                    lon = table.Column<double>(type: "REAL", nullable: false),
                    lat = table.Column<double>(type: "REAL", nullable: false),
                    state = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatiCittà", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DatiMeteo",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    date = table.Column<string>(type: "TEXT", nullable: true),
                    symbol = table.Column<string>(type: "TEXT", nullable: true),
                    symbolPhrase = table.Column<string>(type: "TEXT", nullable: true),
                    maxTemp = table.Column<int>(type: "INTEGER", nullable: false),
                    minTemp = table.Column<int>(type: "INTEGER", nullable: false),
                    maxFeelsLikeTemp = table.Column<int>(type: "INTEGER", nullable: false),
                    minFeelsLikeTemp = table.Column<int>(type: "INTEGER", nullable: false),
                    maxRelHumidity = table.Column<int>(type: "INTEGER", nullable: false),
                    minRelHumidity = table.Column<int>(type: "INTEGER", nullable: false),
                    maxDewPoint = table.Column<int>(type: "INTEGER", nullable: false),
                    minDewPoint = table.Column<int>(type: "INTEGER", nullable: false),
                    precipAccum = table.Column<double>(type: "REAL", nullable: false),
                    snowAccum = table.Column<int>(type: "INTEGER", nullable: false),
                    maxWindSpeed = table.Column<int>(type: "INTEGER", nullable: false),
                    windDir = table.Column<int>(type: "INTEGER", nullable: false),
                    maxWindGust = table.Column<int>(type: "INTEGER", nullable: false),
                    precipProb = table.Column<int>(type: "INTEGER", nullable: false),
                    cloudiness = table.Column<int>(type: "INTEGER", nullable: false),
                    sunrise = table.Column<string>(type: "TEXT", nullable: true),
                    sunset = table.Column<string>(type: "TEXT", nullable: true),
                    sunriseEpoch = table.Column<int>(type: "INTEGER", nullable: false),
                    sunsetEpoch = table.Column<int>(type: "INTEGER", nullable: false),
                    moonrise = table.Column<string>(type: "TEXT", nullable: true),
                    moonset = table.Column<string>(type: "TEXT", nullable: true),
                    moonPhase = table.Column<int>(type: "INTEGER", nullable: false),
                    uvIndex = table.Column<int>(type: "INTEGER", nullable: false),
                    minVisibility = table.Column<int>(type: "INTEGER", nullable: false),
                    pressure = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatiMeteo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MetCitta",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idCitta = table.Column<int>(type: "INTEGER", nullable: false),
                    idMeteo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetCitta", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatiCittà");

            migrationBuilder.DropTable(
                name: "DatiMeteo");

            migrationBuilder.DropTable(
                name: "MetCitta");
        }
    }
}
