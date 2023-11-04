using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class dbfix3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_egg",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "TypeProduct",
                table: "Product",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeProduct",
                table: "Product");

            migrationBuilder.AddColumn<bool>(
                name: "is_egg",
                table: "Product",
                type: "bit",
                nullable: true);
        }
    }
}
