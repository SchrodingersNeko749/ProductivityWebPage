using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductivityWebPage.Migrations
{
    public partial class added_start_end_time : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "time",
                table: "TimeTable",
                newName: "start_time");

            migrationBuilder.AddColumn<DateTime>(
                name: "end_time",
                table: "TimeTable",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "end_time",
                table: "TimeTable");

            migrationBuilder.RenameColumn(
                name: "start_time",
                table: "TimeTable",
                newName: "time");
        }
    }
}
