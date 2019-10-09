using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FACILITIES.Migrations
{
    public partial class Setting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    SettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfficeID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    NextDate = table.Column<DateTime>(nullable: false),
                    FrequencyID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    ResponsibilityID = table.Column<int>(nullable: false),
                    StatusID = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.SettingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Setting");
        }
    }
}
