using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoeAirlines.Migrations
{
    public partial class MigrationCelebridade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Pilotos");

            migrationBuilder.AddColumn<string>(
                name: "Jatinho",
                table: "Aeronaves",
                type: "nvarchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Jatinho",
                table: "Aeronaves");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Pilotos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
