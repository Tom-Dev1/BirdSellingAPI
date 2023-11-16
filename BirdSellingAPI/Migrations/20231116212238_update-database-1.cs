using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bird_mother_id",
                table: "phoiGiongEntities",
                newName: "bird_Shop_id");

            migrationBuilder.RenameColumn(
                name: "bird_father_id",
                table: "phoiGiongEntities",
                newName: "bird_KH_id");

            migrationBuilder.AddColumn<string>(
                name: "userID",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ConLai",
                table: "phoiGiongEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DaThanhToan",
                table: "phoiGiongEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GiaTien",
                table: "phoiGiongEntities",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ConLai",
                table: "phoiGiongEntities");

            migrationBuilder.DropColumn(
                name: "DaThanhToan",
                table: "phoiGiongEntities");

            migrationBuilder.DropColumn(
                name: "GiaTien",
                table: "phoiGiongEntities");

            migrationBuilder.RenameColumn(
                name: "bird_Shop_id",
                table: "phoiGiongEntities",
                newName: "bird_mother_id");

            migrationBuilder.RenameColumn(
                name: "bird_KH_id",
                table: "phoiGiongEntities",
                newName: "bird_father_id");
        }
    }
}
