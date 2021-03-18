using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEastView.Migrations
{
    public partial class cf2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_DiaTarea_DiaTareaId",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "DiaId",
                table: "Tarea");

            migrationBuilder.AlterColumn<int>(
                name: "DiaTareaId",
                table: "Tarea",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_DiaTarea_DiaTareaId",
                table: "Tarea",
                column: "DiaTareaId",
                principalTable: "DiaTarea",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_DiaTarea_DiaTareaId",
                table: "Tarea");

            migrationBuilder.AlterColumn<int>(
                name: "DiaTareaId",
                table: "Tarea",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DiaId",
                table: "Tarea",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_DiaTarea_DiaTareaId",
                table: "Tarea",
                column: "DiaTareaId",
                principalTable: "DiaTarea",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
