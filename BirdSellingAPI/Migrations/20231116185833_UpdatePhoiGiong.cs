using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhoiGiong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhoiGiongStatus",
                table: "phoiGiongEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoChimGiao",
                table: "phoiGiongEntities",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoiGiongStatus",
                table: "phoiGiongEntities");

            migrationBuilder.DropColumn(
                name: "SoChimGiao",
                table: "phoiGiongEntities");
        }
    }
}
