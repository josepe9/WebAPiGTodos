using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPiGTodos.WebT.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deptos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(maxLength: 2, nullable: false),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deptos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    DeptoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudades_Deptos_DeptoId",
                        column: x => x.DeptoId,
                        principalTable: "Deptos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Terceros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<string>(maxLength: 15, nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    FechaNac = table.Column<DateTime>(nullable: true),
                    CiudadID = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terceros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Terceros_Ciudades_CiudadID",
                        column: x => x.CiudadID,
                        principalTable: "Ciudades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_DeptoId",
                table: "Ciudades",
                column: "DeptoId");

            migrationBuilder.CreateIndex(
                name: "IX_Terceros_CiudadID",
                table: "Terceros",
                column: "CiudadID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Terceros");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Deptos");
        }
    }
}
