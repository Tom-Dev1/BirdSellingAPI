using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyForCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "order_id",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
