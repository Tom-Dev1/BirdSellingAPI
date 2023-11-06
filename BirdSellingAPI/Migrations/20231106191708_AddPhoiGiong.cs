using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPhoiGiong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "phoiGiongEntities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bird_mother_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bird_father_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayChoPhoi = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NgayCoTrung = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NgayTrungNo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    SoTrung = table.Column<int>(type: "int", nullable: true),
                    SoTrungNo = table.Column<int>(type: "int", nullable: true),
                    SoTrungHong = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phoiGiongEntities", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "phoiGiongEntities");
        }
    }
}
