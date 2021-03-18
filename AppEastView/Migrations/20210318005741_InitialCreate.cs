using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEastView.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudadano",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoCiudadano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudadano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiaTarea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaTarea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoTarea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTarea = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoTarea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrioridadTarea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prioridad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrioridadTarea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTarea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarea = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTarea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CiudadanoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TipoTareaId = table.Column<int>(type: "int", nullable: false),
                    EstadoTareaId = table.Column<int>(type: "int", nullable: false),
                    PrioridadTareaId = table.Column<int>(type: "int", nullable: false),
                    DiaId = table.Column<int>(type: "int", nullable: false),
                    DiaTareaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarea_Ciudadano_CiudadanoId",
                        column: x => x.CiudadanoId,
                        principalTable: "Ciudadano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tarea_DiaTarea_DiaTareaId",
                        column: x => x.DiaTareaId,
                        principalTable: "DiaTarea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tarea_EstadoTarea_EstadoTareaId",
                        column: x => x.EstadoTareaId,
                        principalTable: "EstadoTarea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tarea_PrioridadTarea_PrioridadTareaId",
                        column: x => x.PrioridadTareaId,
                        principalTable: "PrioridadTarea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tarea_TipoTarea_TipoTareaId",
                        column: x => x.TipoTareaId,
                        principalTable: "TipoTarea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_CiudadanoId",
                table: "Tarea",
                column: "CiudadanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_DiaTareaId",
                table: "Tarea",
                column: "DiaTareaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_EstadoTareaId",
                table: "Tarea",
                column: "EstadoTareaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_PrioridadTareaId",
                table: "Tarea",
                column: "PrioridadTareaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_TipoTareaId",
                table: "Tarea",
                column: "TipoTareaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Ciudadano");

            migrationBuilder.DropTable(
                name: "DiaTarea");

            migrationBuilder.DropTable(
                name: "EstadoTarea");

            migrationBuilder.DropTable(
                name: "PrioridadTarea");

            migrationBuilder.DropTable(
                name: "TipoTarea");
        }
    }
}
