using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixCartProductModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEntityId",
                table: "Cart",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "product_id",
                table: "Cart",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_product_id",
                table: "Cart",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserEntityId",
                table: "Cart",
                column: "UserEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Product_product_id",
                table: "Cart",
                column: "product_id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_UserEntityId",
                table: "Cart",
                column: "UserEntityId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Product_product_id",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_UserEntityId",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_product_id",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_UserEntityId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "Cart");
        }
    }
}
