using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnocaAssignment.Application.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilmModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmHallModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HallName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmHallModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmHallModels_FilmModels_FilmModelId",
                        column: x => x.FilmModelId,
                        principalTable: "FilmModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmSeassionModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmHallModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmSeassionModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmSeassionModels_FilmHallModels_FilmHallModelId",
                        column: x => x.FilmHallModelId,
                        principalTable: "FilmHallModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmHallModels_FilmModelId",
                table: "FilmHallModels",
                column: "FilmModelId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmSeassionModels_FilmHallModelId",
                table: "FilmSeassionModels",
                column: "FilmHallModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmSeassionModels");

            migrationBuilder.DropTable(
                name: "FilmHallModels");

            migrationBuilder.DropTable(
                name: "FilmModels");
        }
    }
}
