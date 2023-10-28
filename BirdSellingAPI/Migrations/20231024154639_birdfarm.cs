using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class birdfarm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Nest_nest_id",
                table: "OrderDetail");

            migrationBuilder.AlterColumn<string>(
                name: "nest_id",
                table: "OrderDetail",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Nest_nest_id",
                table: "OrderDetail",
                column: "nest_id",
                principalTable: "Nest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Nest_nest_id",
                table: "OrderDetail");

            migrationBuilder.AlterColumn<string>(
                name: "nest_id",
                table: "OrderDetail",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Nest_nest_id",
                table: "OrderDetail",
                column: "nest_id",
                principalTable: "Nest",
                principalColumn: "Id");
        }
    }
}
