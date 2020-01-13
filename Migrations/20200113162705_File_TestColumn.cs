using Microsoft.EntityFrameworkCore.Migrations;

namespace FACILITIES.Migrations
{
    public partial class File_TestColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Company",
                newName: "County");

            migrationBuilder.AddColumn<string>(
                name: "TestColumn",
                table: "File",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestColumn",
                table: "File");

            migrationBuilder.RenameColumn(
                name: "County",
                table: "Company",
                newName: "Country");
        }
    }
}
