using Microsoft.EntityFrameworkCore.Migrations;

namespace EsFinaleMeteo.Migrations.AppDb
{
    public partial class pref : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UtentiCitta",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idUt = table.Column<int>(type: "INTEGER", nullable: false),
                    idCit = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtentiCitta", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UtentiCitta");
        }
    }
}
