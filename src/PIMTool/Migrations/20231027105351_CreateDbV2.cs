using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIMTool.Migrations
{
    public partial class CreateDbV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_GROUP_GROUP_ID",
                table: "PROJECT");

            migrationBuilder.RenameColumn(
                name: "GROUP_ID",
                table: "PROJECT",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_PROJECT_GROUP_ID",
                table: "PROJECT",
                newName: "IX_PROJECT_GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_GROUP_GroupId",
                table: "PROJECT",
                column: "GroupId",
                principalTable: "GROUP",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_GROUP_GroupId",
                table: "PROJECT");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "PROJECT",
                newName: "GROUP_ID");

            migrationBuilder.RenameIndex(
                name: "IX_PROJECT_GroupId",
                table: "PROJECT",
                newName: "IX_PROJECT_GROUP_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_GROUP_GROUP_ID",
                table: "PROJECT",
                column: "GROUP_ID",
                principalTable: "GROUP",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
