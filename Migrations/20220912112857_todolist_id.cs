using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductivityWebPage.Migrations
{
    public partial class todolist_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_Projects_Projectid",
                table: "TodoItems");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_Projectid",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "Projectid",
                table: "TodoItems");

            migrationBuilder.AddColumn<int>(
                name: "chore_id",
                table: "Projects",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "chore_id",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "Projectid",
                table: "TodoItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_Projectid",
                table: "TodoItems",
                column: "Projectid");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_Projects_Projectid",
                table: "TodoItems",
                column: "Projectid",
                principalTable: "Projects",
                principalColumn: "id");
        }
    }
}
