﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyPortfolioo.Migrations
{
    /// <inheritdoc />
    public partial class EditingAbout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OurAchievements",
                table: "AboutUs");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "OurAchievements",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
