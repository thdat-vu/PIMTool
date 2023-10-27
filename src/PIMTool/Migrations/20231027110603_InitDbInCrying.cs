using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIMTool.Migrations
{
    public partial class InitDbInCrying : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GROUP_EMPLOYEE_EmployeeId",
                table: "GROUP");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_GROUP_GroupId",
                table: "PROJECT");

            migrationBuilder.AlterColumn<byte[]>(
                name: "VERSION",
                table: "PROJECT",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "VERSION",
                table: "GROUP",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "GROUP",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "VISA",
                table: "EMPLOYEE",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "VERSION",
                table: "EMPLOYEE",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LASTNAME",
                table: "EMPLOYEE",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FIRSTNAME",
                table: "EMPLOYEE",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_GROUP_EMPLOYEE_EmployeeId",
                table: "GROUP",
                column: "EmployeeId",
                principalTable: "EMPLOYEE",
                principalColumn: "ID");

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
                name: "FK_GROUP_EMPLOYEE_EmployeeId",
                table: "GROUP");

            migrationBuilder.DropForeignKey(
                name: "FK_PROJECT_GROUP_GroupId",
                table: "PROJECT");

            migrationBuilder.AlterColumn<byte[]>(
                name: "VERSION",
                table: "PROJECT",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "VERSION",
                table: "GROUP",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "GROUP",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VISA",
                table: "EMPLOYEE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "VERSION",
                table: "EMPLOYEE",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LASTNAME",
                table: "EMPLOYEE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FIRSTNAME",
                table: "EMPLOYEE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GROUP_EMPLOYEE_EmployeeId",
                table: "GROUP",
                column: "EmployeeId",
                principalTable: "EMPLOYEE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PROJECT_GROUP_GroupId",
                table: "PROJECT",
                column: "GroupId",
                principalTable: "GROUP",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
