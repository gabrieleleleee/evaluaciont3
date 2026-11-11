using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EVALUACION_T3.Migrations
{
    /// <inheritdoc />
    public partial class migra1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aventureros",
                columns: table => new
                {
                    IdAventurero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEspecialidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aventureros", x => x.IdAventurero);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    IdEspecialidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AventureroIdAventurero = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.IdEspecialidad);
                    table.ForeignKey(
                        name: "FK_Especialidades_Aventureros_AventureroIdAventurero",
                        column: x => x.AventureroIdAventurero,
                        principalTable: "Aventureros",
                        principalColumn: "IdAventurero");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aventureros_IdEspecialidad",
                table: "Aventureros",
                column: "IdEspecialidad");

            migrationBuilder.CreateIndex(
                name: "IX_Especialidades_AventureroIdAventurero",
                table: "Especialidades",
                column: "AventureroIdAventurero");

            migrationBuilder.AddForeignKey(
                name: "FK_Aventureros_Especialidades_IdEspecialidad",
                table: "Aventureros",
                column: "IdEspecialidad",
                principalTable: "Especialidades",
                principalColumn: "IdEspecialidad",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aventureros_Especialidades_IdEspecialidad",
                table: "Aventureros");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Aventureros");
        }
    }
}
