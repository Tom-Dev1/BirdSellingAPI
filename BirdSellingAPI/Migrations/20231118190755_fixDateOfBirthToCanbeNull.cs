using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixDateOfBirthToCanbeNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "day_of_birth",
                table: "Product",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "day_of_birth",
                table: "Product",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
    }
}
