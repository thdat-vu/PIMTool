using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIMTool.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EMPLOYEE_GROUP_GroupId",
                table: "EMPLOYEE");

            migrationBuilder.DropIndex(
                name: "IX_EMPLOYEE_GroupId",
                table: "EMPLOYEE");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "EMPLOYEE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "EMPLOYEE",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_GroupId",
                table: "EMPLOYEE",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_EMPLOYEE_GROUP_GroupId",
                table: "EMPLOYEE",
                column: "GroupId",
                principalTable: "GROUP",
                principalColumn: "ID");
        }
    }
}
