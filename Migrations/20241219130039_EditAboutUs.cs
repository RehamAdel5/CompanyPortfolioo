using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyPortfolioo.Migrations
{
    /// <inheritdoc />
    public partial class EditAboutUs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OurAchievements",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OurAchievements",
                table: "AboutUs");
        }
    }
}
