using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakersFootprint.Migrations
{
    public partial class correcturlfromdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/Images/sko-air-huarache-le-7ggQkX.jpg", "/Images/sko-air-huarache-le-7ggQkX.jpg" });

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4.jpg", "/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4.jpg" });

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/Images/loparskor-flex-runner-sTBg4T.jpg", "/Images/loparskor-flex-runner-sTBg4T.jpg" });

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/Images/Ultraboost_4.0_DNA_Shoes_black.jpg", "/Images/Ultraboost_4.0_DNA_Shoes_black.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "src=~/Images/sko-air-huarache-le-7ggQkX.jpg", "src=~/Images/sko-air-huarache-le-7ggQkX.jpg" });

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4.jpg", "~/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4.jpg" });

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~/Images/loparskor-flex-runner-sTBg4T.jpg", "~/Images/loparskor-flex-runner-sTBg4T.jpg" });

            migrationBuilder.UpdateData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~/Images/Ultraboost_4.0_DNA_Shoes_black.jpg", "~/Images/Ultraboost_4.0_DNA_Shoes_black.jpg" });
        }
    }
}
