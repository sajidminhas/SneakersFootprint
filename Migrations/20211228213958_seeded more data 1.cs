using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakersFootprint.Migrations
{
    public partial class seededmoredata1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 7,
                column: "ImageThumbnailUrl",
                value: "/Images/sko-flex-advance-L44DwQ.jpg");

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 10,
                column: "ImageThumbnailUrl",
                value: "/Images/skor-air-max-plus-Pc62Zg.jpg");

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 12,
                column: "ImageThumbnailUrl",
                value: "/Images/NMD_R1_Vit_GX1050_06_standard.jpg");

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 13,
                column: "ImageThumbnailUrl",
                value: "/Images/Ultraboost_1.0_DNA_Shoes_Bla_GV7723_06.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 7,
                column: "ImageThumbnailUrl",
                value: "/Images/sko-flex-advance-L44DwQp.jpg");

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 10,
                column: "ImageThumbnailUrl",
                value: "/Images/ skor-air-max-plus-Pc62Zg.jpg");

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 12,
                column: "ImageThumbnailUrl",
                value: "Images/NMD_R1_Vit_GX1050_06_standard.jpg");

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 13,
                column: "ImageThumbnailUrl",
                value: "Images/Ultraboost_1.0_DNA_Shoes_Bla_GV7723_06.jpg");
        }
    }
}
