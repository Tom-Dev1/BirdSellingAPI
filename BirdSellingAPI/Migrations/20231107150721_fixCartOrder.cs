using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixCartOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderEntityId",
                table: "Order",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderEntityId",
                table: "Order",
                column: "OrderEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Order_OrderEntityId",
                table: "Order",
                column: "OrderEntityId",
                principalTable: "Order",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Order_OrderEntityId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_OrderEntityId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderEntityId",
                table: "Order");
        }
    }
}
