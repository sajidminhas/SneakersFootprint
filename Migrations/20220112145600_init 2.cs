using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakersFootprint.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 14,
                column: "Name",
                value: "Nike Air Zoom Pegasus 38");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 14,
                column: "Name",
                value: "Nike Air Zoom Pegasus 38 Premium");
        }
    }
}
