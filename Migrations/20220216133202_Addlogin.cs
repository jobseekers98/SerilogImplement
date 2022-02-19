﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstCrud.Migrations
{
    public partial class Addlogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "tbl_Student",
                type: "nvarchar(270)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "tbl_Student");
        }
    }
}
