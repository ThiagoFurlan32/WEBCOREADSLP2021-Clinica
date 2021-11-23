using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBCORELP2021.Migrations
{
    public partial class Anotacoes_v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanoDeSaude_Pacientes_pacienteID",
                table: "PlanoDeSaude");

            migrationBuilder.DropIndex(
                name: "IX_PlanoDeSaude_pacienteID",
                table: "PlanoDeSaude");

            migrationBuilder.DropColumn(
                name: "pacienteID",
                table: "PlanoDeSaude");

            migrationBuilder.AddColumn<int>(
                name: "planoDeSaudeID",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_planoDeSaudeID",
                table: "Pacientes",
                column: "planoDeSaudeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_PlanoDeSaude_planoDeSaudeID",
                table: "Pacientes",
                column: "planoDeSaudeID",
                principalTable: "PlanoDeSaude",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_PlanoDeSaude_planoDeSaudeID",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_planoDeSaudeID",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "planoDeSaudeID",
                table: "Pacientes");

            migrationBuilder.AddColumn<int>(
                name: "pacienteID",
                table: "PlanoDeSaude",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlanoDeSaude_pacienteID",
                table: "PlanoDeSaude",
                column: "pacienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanoDeSaude_Pacientes_pacienteID",
                table: "PlanoDeSaude",
                column: "pacienteID",
                principalTable: "Pacientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
