using Microsoft.EntityFrameworkCore.Migrations;

namespace FACILITIES.Migrations
{
    public partial class Item : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SupplierOptions",
                table: "Supplier",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Office_CompanyID",
                table: "Office",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Office_ManagerID",
                table: "Office",
                column: "ManagerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Office_Company_CompanyID",
                table: "Office",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Office_Manager_ManagerID",
                table: "Office",
                column: "ManagerID",
                principalTable: "Manager",
                principalColumn: "ManagerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Office_Manager_ManagerID",
                table: "Office");

            migrationBuilder.DropIndex(
                name: "IX_Office_CompanyID",
                table: "Office");

            migrationBuilder.DropIndex(
                name: "IX_Office_ManagerID",
                table: "Office");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierOptions",
                table: "Supplier",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
