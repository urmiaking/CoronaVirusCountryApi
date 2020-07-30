using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaVirusCountryApi.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    InfectedNo = table.Column<int>(nullable: false),
                    RecoveredNo = table.Column<int>(nullable: false),
                    DeathNo = table.Column<int>(nullable: false),
                    RefreshDate = table.Column<DateTime>(nullable: false),
                    ContinentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "ContinentId", "DeathNo", "InfectedNo", "Name", "RecoveredNo", "RefreshDate" },
                values: new object[,]
                {
                    { 1, 1, 13500, 300000, "ایران", 250000, new DateTime(2020, 7, 29, 17, 51, 38, 483, DateTimeKind.Utc).AddTicks(1996) },
                    { 2, 2, 13500, 300000, "ایالات متحده آمریکا", 250000, new DateTime(2020, 7, 29, 17, 51, 38, 483, DateTimeKind.Utc).AddTicks(2701) },
                    { 3, 5, 100000, 2000000, "انگلیس", 1100000, new DateTime(2020, 7, 29, 17, 51, 38, 483, DateTimeKind.Utc).AddTicks(2716) },
                    { 4, 4, 5000, 30000, "سیدنی", 20000, new DateTime(2020, 7, 29, 17, 51, 38, 483, DateTimeKind.Utc).AddTicks(2718) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
