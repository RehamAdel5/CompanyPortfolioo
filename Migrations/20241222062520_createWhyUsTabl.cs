using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyPortfolioo.Migrations
{
    /// <inheritdoc />
    public partial class createWhyUsTabl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AskedQuestions",
                table: "AskedQuestions");

            migrationBuilder.RenameTable(
                name: "AskedQuestions",
                newName: "WhyUs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WhyUs",
                table: "WhyUs",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WhyUs",
                table: "WhyUs");

            migrationBuilder.RenameTable(
                name: "WhyUs",
                newName: "AskedQuestions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AskedQuestions",
                table: "AskedQuestions",
                column: "Id");
        }
    }
}
