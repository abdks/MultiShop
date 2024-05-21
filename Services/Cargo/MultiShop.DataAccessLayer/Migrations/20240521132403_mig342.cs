﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiShop.DataAccessLayer.Migrations
{
    public partial class mig342 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserCustomerId",
                table: "CargoCustomers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCustomerId",
                table: "CargoCustomers");
        }
    }
}
