using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class DeletePaymentType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_ShippingMenthod_shippingMenthod_id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPaymentMenthod_paymentType_paymentType_id",
                table: "UserPaymentMenthod");

            migrationBuilder.DropTable(
                name: "paymentType");

            migrationBuilder.DropTable(
                name: "ShippingMenthod");

            migrationBuilder.DropIndex(
                name: "IX_UserPaymentMenthod_paymentType_id",
                table: "UserPaymentMenthod");

            migrationBuilder.DropIndex(
                name: "IX_Order_shippingMenthod_id",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "account_number",
                table: "UserPaymentMenthod");

            migrationBuilder.DropColumn(
                name: "description",
                table: "UserPaymentMenthod");

            migrationBuilder.DropColumn(
                name: "paymentType_id",
                table: "UserPaymentMenthod");

            migrationBuilder.DropColumn(
                name: "provide",
                table: "UserPaymentMenthod");

            migrationBuilder.DropColumn(
                name: "shippingMenthod_id",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "UserPaymentMenthod",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "paymentMenthod_id",
                table: "Order",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Order_paymentMenthod_id",
                table: "Order",
                column: "paymentMenthod_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_UserPaymentMenthod_paymentMenthod_id",
                table: "Order",
                column: "paymentMenthod_id",
                principalTable: "UserPaymentMenthod",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_UserPaymentMenthod_paymentMenthod_id",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_paymentMenthod_id",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "name",
                table: "UserPaymentMenthod");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "account_number",
                table: "UserPaymentMenthod",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "UserPaymentMenthod",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "paymentType_id",
                table: "UserPaymentMenthod",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "provide",
                table: "UserPaymentMenthod",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "paymentMenthod_id",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "shippingMenthod_id",
                table: "Order",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "paymentType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingMenthod",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingMenthod", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPaymentMenthod_paymentType_id",
                table: "UserPaymentMenthod",
                column: "paymentType_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_shippingMenthod_id",
                table: "Order",
                column: "shippingMenthod_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ShippingMenthod_shippingMenthod_id",
                table: "Order",
                column: "shippingMenthod_id",
                principalTable: "ShippingMenthod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPaymentMenthod_paymentType_paymentType_id",
                table: "UserPaymentMenthod",
                column: "paymentType_id",
                principalTable: "paymentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
