using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixDB1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_roleEntities_roleEntities_RoleEntityId",
                table: "roleEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_User_roleEntities_role_id",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_roleEntities",
                table: "roleEntities");

            migrationBuilder.DropIndex(
                name: "IX_roleEntities_RoleEntityId",
                table: "roleEntities");

            migrationBuilder.DropColumn(
                name: "RoleEntityId",
                table: "roleEntities");

            migrationBuilder.RenameTable(
                name: "roleEntities",
                newName: "Role");

            migrationBuilder.AddColumn<string>(
                name: "address_id",
                table: "User",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_address_id",
                table: "User",
                column: "address_id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_address_id",
                table: "User",
                column: "address_id",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_role_id",
                table: "User",
                column: "role_id",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_address_id",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_role_id",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_address_id",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "address_id",
                table: "User");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "roleEntities");

            migrationBuilder.AddColumn<string>(
                name: "RoleEntityId",
                table: "roleEntities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_roleEntities",
                table: "roleEntities",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_roleEntities_RoleEntityId",
                table: "roleEntities",
                column: "RoleEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_roleEntities_roleEntities_RoleEntityId",
                table: "roleEntities",
                column: "RoleEntityId",
                principalTable: "roleEntities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_roleEntities_role_id",
                table: "User",
                column: "role_id",
                principalTable: "roleEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
