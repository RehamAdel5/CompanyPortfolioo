using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyPortfolioo.Migrations
{
    /// <inheritdoc />
    public partial class AddImageToProjectCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "ProjectCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "ProjectCategories");
        }
    }
}
