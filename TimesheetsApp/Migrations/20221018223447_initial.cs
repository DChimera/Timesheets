using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimesheetsApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Timesheets",
                columns: table => new
                {
                    TimesheetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timesheets", x => x.TimesheetId);
                });

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "TimesheetId", "Date", "Hours", "ProjectName" },
                values: new object[] { 1, new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "New Build" });

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "TimesheetId", "Date", "Hours", "ProjectName" },
                values: new object[] { 2, new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Bug Fix" });

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "TimesheetId", "Date", "Hours", "ProjectName" },
                values: new object[] { 3, new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "New Build" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Timesheets");
        }
    }
}
