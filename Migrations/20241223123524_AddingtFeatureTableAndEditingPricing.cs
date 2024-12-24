using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyPortfolioo.Migrations
{
    /// <inheritdoc />
    public partial class AddingtFeatureTableAndEditingPricing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Features",
                table: "Pricings");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Pricings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActiveFeature = table.Column<bool>(type: "bit", nullable: false),
                    PricingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Features_Pricings_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Features_PricingId",
                table: "Features",
                column: "PricingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Pricings");

            migrationBuilder.AddColumn<string>(
                name: "Features",
                table: "Pricings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
