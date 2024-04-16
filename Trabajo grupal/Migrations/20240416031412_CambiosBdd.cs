using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trabajo_grupal.Migrations
{
    /// <inheritdoc />
    public partial class CambiosBdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recinto_Vacuanción",
                columns: table => new
                {
                    Direccion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recinto_Vacuanción", x => x.Direccion);
                });

            migrationBuilder.CreateTable(
                name: "Vacuna",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisOrigen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacuna", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    IdBanner = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaVacunacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    vacunaid = table.Column<int>(type: "int", nullable: false),
                    recintoDireccion = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.IdBanner);
                    table.ForeignKey(
                        name: "FK_Estudiante_Recinto_Vacuanción_recintoDireccion",
                        column: x => x.recintoDireccion,
                        principalTable: "Recinto_Vacuanción",
                        principalColumn: "Direccion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estudiante_Vacuna_vacunaid",
                        column: x => x.vacunaid,
                        principalTable: "Vacuna",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_recintoDireccion",
                table: "Estudiante",
                column: "recintoDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_vacunaid",
                table: "Estudiante",
                column: "vacunaid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "Recinto_Vacuanción");

            migrationBuilder.DropTable(
                name: "Vacuna");
        }
    }
}
