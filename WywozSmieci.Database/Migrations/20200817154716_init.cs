using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WywozSmieci.Database.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rejons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Miejsce = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rejons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wywozs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    rejonId = table.Column<int>(nullable: true),
                    Typ = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wywozs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wywozs_Rejons_rejonId",
                        column: x => x.rejonId,
                        principalTable: "Rejons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wywozs_rejonId",
                table: "Wywozs",
                column: "rejonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wywozs");

            migrationBuilder.DropTable(
                name: "Rejons");
        }
    }
}
