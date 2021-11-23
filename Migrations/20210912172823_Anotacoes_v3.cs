using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBCORELP2021.Migrations
{
    public partial class Anotacoes_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Medico_medicoid",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Pacientes_pacienteid",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanoDeSaude_Pacientes_pacienteid",
                table: "PlanoDeSaude");

            migrationBuilder.RenameColumn(
                name: "pacienteid",
                table: "PlanoDeSaude",
                newName: "pacienteID");

            migrationBuilder.RenameIndex(
                name: "IX_PlanoDeSaude_pacienteid",
                table: "PlanoDeSaude",
                newName: "IX_PlanoDeSaude_pacienteID");

            migrationBuilder.RenameColumn(
                name: "pacienteid",
                table: "Consulta",
                newName: "pacienteID");

            migrationBuilder.RenameColumn(
                name: "medicoid",
                table: "Consulta",
                newName: "medicoID");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_pacienteid",
                table: "Consulta",
                newName: "IX_Consulta_pacienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_medicoid",
                table: "Consulta",
                newName: "IX_Consulta_medicoID");

            migrationBuilder.AlterColumn<int>(
                name: "pacienteID",
                table: "PlanoDeSaude",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pacienteID",
                table: "Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "medicoID",
                table: "Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Medico_medicoID",
                table: "Consulta",
                column: "medicoID",
                principalTable: "Medico",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Pacientes_pacienteID",
                table: "Consulta",
                column: "pacienteID",
                principalTable: "Pacientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanoDeSaude_Pacientes_pacienteID",
                table: "PlanoDeSaude",
                column: "pacienteID",
                principalTable: "Pacientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Medico_medicoID",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Pacientes_pacienteID",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanoDeSaude_Pacientes_pacienteID",
                table: "PlanoDeSaude");

            migrationBuilder.RenameColumn(
                name: "pacienteID",
                table: "PlanoDeSaude",
                newName: "pacienteid");

            migrationBuilder.RenameIndex(
                name: "IX_PlanoDeSaude_pacienteID",
                table: "PlanoDeSaude",
                newName: "IX_PlanoDeSaude_pacienteid");

            migrationBuilder.RenameColumn(
                name: "pacienteID",
                table: "Consulta",
                newName: "pacienteid");

            migrationBuilder.RenameColumn(
                name: "medicoID",
                table: "Consulta",
                newName: "medicoid");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_pacienteID",
                table: "Consulta",
                newName: "IX_Consulta_pacienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_medicoID",
                table: "Consulta",
                newName: "IX_Consulta_medicoid");

            migrationBuilder.AlterColumn<int>(
                name: "pacienteid",
                table: "PlanoDeSaude",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "pacienteid",
                table: "Consulta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "medicoid",
                table: "Consulta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Medico_medicoid",
                table: "Consulta",
                column: "medicoid",
                principalTable: "Medico",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Pacientes_pacienteid",
                table: "Consulta",
                column: "pacienteid",
                principalTable: "Pacientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanoDeSaude_Pacientes_pacienteid",
                table: "PlanoDeSaude",
                column: "pacienteid",
                principalTable: "Pacientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
