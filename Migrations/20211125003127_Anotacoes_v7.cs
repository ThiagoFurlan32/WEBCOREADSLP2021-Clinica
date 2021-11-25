using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBCORELP2021.Migrations
{
    public partial class Anotacoes_v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "total_consultas",
                table: "Medico",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "total_consultas",
                table: "Medico");
        }
    }
}
