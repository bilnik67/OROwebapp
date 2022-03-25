using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OROApp.Migrations
{
    public partial class achternaam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bestelling",
                table: "users",
                newName: "Bestelling");

            migrationBuilder.RenameColumn(
                name: "naamtest",
                table: "users",
                newName: "Naam");

            migrationBuilder.AddColumn<string>(
                name: "Achternaam",
                table: "users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Achternaam",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "Bestelling",
                table: "users",
                newName: "bestelling");

            migrationBuilder.RenameColumn(
                name: "Naam",
                table: "users",
                newName: "naamtest");
        }
    }
}
