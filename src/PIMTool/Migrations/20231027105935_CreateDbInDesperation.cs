using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIMTool.Migrations
{
    public partial class CreateDbInDesperation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_GROUP_GroupId",
                table: "PROJECT");

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_GROUP_GroupId",
                table: "PROJECT",
                column: "GroupId",
                principalTable: "GROUP",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_GROUP_GroupId",
                table: "PROJECT");

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_GROUP_GroupId",
                table: "PROJECT",
                column: "GroupId",
                principalTable: "GROUP",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
