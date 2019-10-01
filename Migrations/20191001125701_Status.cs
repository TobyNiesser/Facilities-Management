using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FACILITIES.Migrations
{
    public partial class Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    OfficeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Addr1 = table.Column<string>(nullable: true),
                    Addr2 = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    CompanyID = table.Column<int>(nullable: false),
                    ManagerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.OfficeID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatusIndicator = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
