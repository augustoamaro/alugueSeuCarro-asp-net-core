using Microsoft.EntityFrameworkCore.Migrations;

namespace AlugueSeuCarro.Migrations
{
    public partial class MigrationTeste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Saldo",
                table: "Contas",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Saldo",
                table: "Contas",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
