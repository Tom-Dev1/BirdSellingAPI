using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddGetSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_UserEntityId",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_UserEntityId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "Cart");

            migrationBuilder.AddColumn<string>(
                name: "paymentMenthod_id",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "order_id",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "Cart",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "quantity",
                table: "Cart",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_id",
                table: "Cart",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_user_id",
                table: "Cart",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_user_id",
                table: "Cart",
                column: "user_id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_user_id",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_user_id",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "paymentMenthod_id",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "order_id",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Cart");

            migrationBuilder.AddColumn<string>(
                name: "UserEntityId",
                table: "Cart",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserEntityId",
                table: "Cart",
                column: "UserEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_UserEntityId",
                table: "Cart",
                column: "UserEntityId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
