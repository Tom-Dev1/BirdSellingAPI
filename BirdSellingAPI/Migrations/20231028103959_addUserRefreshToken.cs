using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUserRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "promotionCategory_id",
                table: "PromotionCategory",
                newName: "promotion_id");

            migrationBuilder.RenameColumn(
                name: "promotionCategory",
                table: "PromotionCategory",
                newName: "promotion");

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "paymentType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "UserRefreshToken",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JwtId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isUsed = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRefreshToken_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRefreshToken_User_Id",
                table: "UserRefreshToken",
                column: "User_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRefreshToken");

            migrationBuilder.RenameColumn(
                name: "promotion_id",
                table: "PromotionCategory",
                newName: "promotionCategory_id");

            migrationBuilder.RenameColumn(
                name: "promotion",
                table: "PromotionCategory",
                newName: "promotionCategory");

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "paymentType",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
