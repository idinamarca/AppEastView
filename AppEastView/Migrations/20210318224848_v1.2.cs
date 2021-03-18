using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEastView.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreTarea",
                table: "EstadoTarea",
                newName: "Estado_Tarea");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estado_Tarea",
                table: "EstadoTarea",
                newName: "NombreTarea");
        }
    }
}
