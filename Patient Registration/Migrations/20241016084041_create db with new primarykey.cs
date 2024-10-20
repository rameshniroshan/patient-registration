﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patient_Registration.Migrations
{
    /// <inheritdoc />
    public partial class createdbwithnewprimarykey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Call_Patients",
                table: "Call_Patients");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "Call_Patients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Call_Patients",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Call_Patients",
                table: "Call_Patients",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Call_Patients",
                table: "Call_Patients");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Call_Patients");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "Call_Patients",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Call_Patients",
                table: "Call_Patients",
                column: "MobileNo");
        }
    }
}
