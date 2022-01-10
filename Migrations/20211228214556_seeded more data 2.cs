using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakersFootprint.Migrations
{
    public partial class seededmoredata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "/Images/sko-air-max-pre-day-W67m0w.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "Images/sko-air-max-pre-day-W67m0w.jpg");
        }
    }
}
