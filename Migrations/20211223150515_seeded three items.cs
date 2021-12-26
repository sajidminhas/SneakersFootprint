using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakersFootprint.Migrations
{
    public partial class seededthreeitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Men's Sneakers", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Women's Sneakers", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Kid's Sneakers", null });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "SneakerId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "Sale", "ShortDescription" },
                values: new object[] { 1, 1, "~/Images/sko-air-huarache-le-7ggQkX", "~/Images/sko-air-huarache-le-7ggQkX", true, "The Nike Air Huarache LE is a favorite with a street feel. A comfortable shoe with an excellent fit. The upper combines elegant leather details with a super airy, glossy neoprene-like material that provides many styling options. Classic heel clip and stripped-down brand details give a look from the early 90's.Color shown: Shadow/Black/Midnight Navy. Style: DH8143 - 400", "Nike", 129.95m, true, "Air Huarache LE!" });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "SneakerId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "Sale", "ShortDescription" },
                values: new object[] { 2, 2, "~/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4", "~/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4", true, "Get ready to reach your next personal best in this road shoe that's made for fast movement. It gives you the best energy reproduction of all our race shoes with a forward feel all the way across the finish line. The design is lightweight, breathable and designed using scientific data to give you a comfortable fit. The details celebrate our shared ability to take on tough challenges.Color shown: White/Black/Pink. Style: DJ5456-100", "Nike", 79.95m, false, "Air Zoom Alphafly!" });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "SneakerId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "Sale", "ShortDescription" },
                values: new object[] { 3, 3, "~/Images/loparskor-flex-runner-sTBg4T", "~/Images/loparskor-flex-runner-sTBg4T", true, "Forget the lacing – you can just pull these on. Run around the block or compete with your friends – Nike Flex Runner makes everything easy. The foam sole is super flexible so that each step and jump is as easy as 1, 2, 3.Color shown: Medium Ash/Siren Red/Black. Style: AT4662-200", "Nike", 49.95m, false, "Flex Runner!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
