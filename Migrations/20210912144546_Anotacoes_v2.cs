using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBCORELP2021.Migrations
{
    public partial class Anotacoes_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Medicos_medicoid",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Pacientes_pacienteid",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanosDeSaude_Pacientes_pacienteid",
                table: "PlanosDeSaude");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanosDeSaude",
                table: "PlanosDeSaude");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicos",
                table: "Medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas");

            migrationBuilder.RenameTable(
                name: "PlanosDeSaude",
                newName: "PlanoDeSaude");

            migrationBuilder.RenameTable(
                name: "Medicos",
                newName: "Medico");

            migrationBuilder.RenameTable(
                name: "Consultas",
                newName: "Consulta");

            migrationBuilder.RenameIndex(
                name: "IX_PlanosDeSaude_pacienteid",
                table: "PlanoDeSaude",
                newName: "IX_PlanoDeSaude_pacienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_pacienteid",
                table: "Consulta",
                newName: "IX_Consulta_pacienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_medicoid",
                table: "Consulta",
                newName: "IX_Consulta_medicoid");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Pacientes",
                type: "nvarchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "endereco",
                table: "Pacientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "Pacientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cpf",
                table: "Pacientes",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Pacientes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numero",
                table: "Pacientes",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "PlanoDeSaude",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "PlanoDeSaude",
                type: "nvarchar(45)",
                maxLength: 45,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "Medico",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Medico",
                type: "nvarchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idade",
                table: "Medico",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "Medico",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cpf",
                table: "Medico",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Medico",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "endereco",
                table: "Medico",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Consulta",
                type: "nvarchar(45)",
                maxLength: 45,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanoDeSaude",
                table: "PlanoDeSaude",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medico",
                table: "Medico",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consulta",
                table: "Consulta",
                column: "id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanoDeSaude",
                table: "PlanoDeSaude");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medico",
                table: "Medico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consulta",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "cpf",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "numero",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "cpf",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "endereco",
                table: "Medico");

            migrationBuilder.RenameTable(
                name: "PlanoDeSaude",
                newName: "PlanosDeSaude");

            migrationBuilder.RenameTable(
                name: "Medico",
                newName: "Medicos");

            migrationBuilder.RenameTable(
                name: "Consulta",
                newName: "Consultas");

            migrationBuilder.RenameIndex(
                name: "IX_PlanoDeSaude_pacienteid",
                table: "PlanosDeSaude",
                newName: "IX_PlanosDeSaude_pacienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_pacienteid",
                table: "Consultas",
                newName: "IX_Consultas_pacienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_medicoid",
                table: "Consultas",
                newName: "IX_Consultas_medicoid");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Pacientes",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<string>(
                name: "endereco",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "PlanosDeSaude",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "PlanosDeSaude",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(45)",
                oldMaxLength: 45,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<string>(
                name: "idade",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(45)",
                oldMaxLength: 45,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanosDeSaude",
                table: "PlanosDeSaude",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicos",
                table: "Medicos",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Medicos_medicoid",
                table: "Consultas",
                column: "medicoid",
                principalTable: "Medicos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Pacientes_pacienteid",
                table: "Consultas",
                column: "pacienteid",
                principalTable: "Pacientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanosDeSaude_Pacientes_pacienteid",
                table: "PlanosDeSaude",
                column: "pacienteid",
                principalTable: "Pacientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
