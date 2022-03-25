using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OROApp.Migrations
{
    public partial class Datum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Datum",
                table: "users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Datum",
                table: "users");
        }
    }
}
