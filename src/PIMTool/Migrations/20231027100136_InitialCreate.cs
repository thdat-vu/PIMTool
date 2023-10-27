using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIMTool.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "PROJECT");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PROJECT",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PROJECT",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "NAME",
                table: "PROJECT",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "CUSTOMER",
                table: "PROJECT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "END_DATE",
                table: "PROJECT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GROUP_ID",
                table: "PROJECT",
                type: "int",
                maxLength: 255,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PROJECT_NUMBER",
                table: "PROJECT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "START_DATE",
                table: "PROJECT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "STATUS",
                table: "PROJECT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "VERSION",
                table: "PROJECT",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PROJECT",
                table: "PROJECT",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "EMPLOYEE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VISA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LASTNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BIRTH_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VERSION = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GROUP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GROUP_LEADER_ID = table.Column<int>(type: "int", nullable: false),
                    VERSION = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GROUP", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GROUP_EMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMPLOYEE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PROJECT_EMPLOYEE",
                columns: table => new
                {
                    PROJECT_ID = table.Column<int>(type: "int", nullable: false),
                    EMPLOYEE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROJECT_EMPLOYEE", x => new { x.PROJECT_ID, x.EMPLOYEE_ID });
                    table.ForeignKey(
                        name: "FK_PROJECT_EMPLOYEE_EMPLOYEE_EMPLOYEE_ID",
                        column: x => x.EMPLOYEE_ID,
                        principalTable: "EMPLOYEE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PROJECT_EMPLOYEE_PROJECT_PROJECT_ID",
                        column: x => x.PROJECT_ID,
                        principalTable: "PROJECT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PROJECT_GROUP_ID",
                table: "PROJECT",
                column: "GROUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_GroupId",
                table: "EMPLOYEE",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GROUP_EmployeeId",
                table: "GROUP",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PROJECT_EMPLOYEE_EMPLOYEE_ID",
                table: "PROJECT_EMPLOYEE",
                column: "EMPLOYEE_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_GROUP_GROUP_ID",
                table: "PROJECT",
                column: "GROUP_ID",
                principalTable: "GROUP",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EMPLOYEE_GROUP_GroupId",
                table: "EMPLOYEE",
                column: "GroupId",
                principalTable: "GROUP",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_GROUP_GROUP_ID",
                table: "PROJECT");

            migrationBuilder.DropForeignKey(
                name: "FK_EMPLOYEE_GROUP_GroupId",
                table: "EMPLOYEE");

            migrationBuilder.DropTable(
                name: "PROJECT_EMPLOYEE");

            migrationBuilder.DropTable(
                name: "GROUP");

            migrationBuilder.DropTable(
                name: "EMPLOYEE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PROJECT",
                table: "PROJECT");

            migrationBuilder.DropIndex(
                name: "IX_PROJECT_GROUP_ID",
                table: "PROJECT");

            migrationBuilder.DropColumn(
                name: "CUSTOMER",
                table: "PROJECT");

            migrationBuilder.DropColumn(
                name: "END_DATE",
                table: "PROJECT");

            migrationBuilder.DropColumn(
                name: "GROUP_ID",
                table: "PROJECT");

            migrationBuilder.DropColumn(
                name: "PROJECT_NUMBER",
                table: "PROJECT");

            migrationBuilder.DropColumn(
                name: "START_DATE",
                table: "PROJECT");

            migrationBuilder.DropColumn(
                name: "STATUS",
                table: "PROJECT");

            migrationBuilder.DropColumn(
                name: "VERSION",
                table: "PROJECT");

            migrationBuilder.RenameTable(
                name: "PROJECT",
                newName: "Projects");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "Projects",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Projects",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Projects",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");
        }
    }
}
