using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyListingsApi.Migrations
{
    /// <inheritdoc />
    public partial class ListingPropertySize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Listings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Listings");
        }
    }
}
