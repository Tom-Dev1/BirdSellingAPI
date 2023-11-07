using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixCartOrderV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Order_OrderEntity",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_OrderEntity",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "OrderEntity",
                table: "Cart");

            migrationBuilder.AlterColumn<string>(
                name: "order_id",
                table: "Cart",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_order_id",
                table: "Cart",
                column: "order_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Order_order_id",
                table: "Cart",
                column: "order_id",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Order_order_id",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_order_id",
                table: "Cart");

            migrationBuilder.AlterColumn<string>(
                name: "order_id",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "OrderEntity",
                table: "Cart",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_OrderEntity",
                table: "Cart",
                column: "OrderEntity");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Order_OrderEntity",
                table: "Cart",
                column: "OrderEntity",
                principalTable: "Order",
                principalColumn: "Id");
        }
    }
}
