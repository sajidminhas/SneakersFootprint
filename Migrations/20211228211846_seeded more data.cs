using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakersFootprint.Migrations
{
    public partial class seededmoredata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "SneakerId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "Sale", "ShortDescription" },
                values: new object[,]
                {
                    { 5, 3, "/Images/sko-air-max-90-ltr-BpFdfH.jpg", "/Images/sko-air-max-90-ltr-BpFdfH.jpg", true, "In the past, it was revolutionary. Today? Today it is iconic. The Nike Air Max 90 LTR SE is back with a design that's more suited for kids than the original. The update has a softer cushioning, more flexibility and a more comfortable feel. This special edition is inspired by medals that celebrate us all as winners.Color shown: Off Noir/Black/Summit White/Metallic Pewte. Product code: CD6864-117", "Nike", 1249m, false, "Nike Air Max 90 LTR!" },
                    { 6, 3, "/Images/sko-huarache-run-zsL2zh.jpg", "/Images/sko-huarache-run-zsL2zh.jpg", true, "The Nike Huarache Run has an unmistakable style. The shoe is equipped with the famous Huarache heel strap that allows you to easily stick your foot in it. An inner shoe that sits comfortably around the foot and provides safety and support when running, climbing and playing.Color shown: White/Off Noir/Mint Foam. Product code: 704949-116", "Nike", 949m, false, "Huarache Run!" },
                    { 7, 3, "/Images/sko-flex-advance-L44DwQp.jpg", "/Images/sko-flex-advance-L44DwQ.jpg", true, "The Nike Flex Advance is as simple as counting to three. Nike FlyEase technology provides an extra wide opening so small feet can slide in effortlessly (seriously, it's as easy as it gets). Cross the ribbons (to prepare the kids for real shoelaces) and then it's done. They are super flexible, comfortable and durable – perfect for the little ones to walk, run and play in.Color shown: Black/Siren Red/Medium Ash/White. Product code: CZ0186-005", "Nike", 649m, true, "Flex Advance!" },
                    { 8, 3, "/Images/sko-blazer-mid-77-2jP7Bp.jpg", "/Images/sko-blazer-mid-77-2jP7Bp.jpg", true, "Your little basketball player can own the court in the Nike Blazer Mid '77. The vintage look and comfortable feel make this classic a legendary street shoe even off the pitch..Color shown: Vit/Pecan/Vivid Sulfur. Product code: DA4087-103", "Nike", 749m, false, "Blazer Mid '77!" },
                    { 9, 3, "/Images/sko-air-max-270-xK8g2Z.jpg", "/Images/sko-air-max-270-xK8g2Z.jpg", true, "The Nike Air Max 270 shoe combines the long Nike Air Max 180 tongue with classic elements from the Air Max 93. The model has the largest Air unit ever from Nike on its heel and is as comfortable as it looks.Color shown: Black/Black. Product code: BQ5776-001", "Nike", 749m, false, "Air Max 270!" },
                    { 10, 1, "/Images/ skor-air-max-plus-Pc62Zg.jpg", "/Images/skor-air-max-plus-Pc62Zg.jpg", true, "These sneakers are loaded with extra stability and cushioning. The top layers have stood the test of time since the original made an impression in '98.The design of the mesh material is inspired by crushed ice, creating a cool nod to outdoor activities in winter.Color shown: Black/White/Dark Smoke Grey/Black. Product code: DO6384-001", "Nike", 1899m, false, "Air Max Plus!" },
                    { 11, 1, "Images/sko-air-max-pre-day-W67m0w.jpg", "/Images/sko-air-max-pre-day-W67m0w.jpg", true, "Inspired by Nike's classic running shoes, the Nike Air Max Pre-Day features a design that creates a modern sense of speed. The shoe is a true tribute to history and is made of at least 20% recycled material in relation to its weight and has a running-inspired retro design. A new Air window attracts the eye along with an incredibly soft cushioning.Color shown: Kumquat/Photon Dust/White/Pomegranate. Product code: DC9402-800", "Nike", 1449m, true, "Air Max Pre-Day!" },
                    { 12, 1, "Images/NMD_R1_Vit_GX1050_06_standard.jpg", "/Images/NMD_R1_Vit_GX1050_06_standard.jpg", true, "Pack your bag, lace up your shoes and get out. City adventures call when you have these NMD_R1 shoes on your feet. These modern sneakers are an update to an acclaimed 80s running shoe from the adidas archive, with a soft and stretchy knitted upper as well as energy-restoring Boost cushioning for all-day comfort. The strong colors and distinctive plugs in the midsole serve as a statement and max out the style level wherever you go. This product is made of Primeblue, a recycled functional material partly created with Parley Ocean Plastic. 50% of the upper is made of textile, 75% of the textile is Primeblue yarn. No newly produced polyester.Color shown: Kumquat/Photon Dust/White/Pomegranate. Product code: GZ7925", "Adidas", 1499m, true, "NMD_R1!" },
                    { 13, 1, "Images/Ultraboost_1.0_DNA_Shoes_Bla_GV7723_06.jpg", "/Images/Ultraboost_1.0_DNA_Shoes_Bla_GV7723_06.jpg", true, "You are responsible for the energy. These running shoes from adidas give it back. That's the magic behind the legendary Ultraboost design. This pair brings the OG adidas Primeknit pattern from 2015 to life as a tribute to the beloved shoe. Lace up and experience comfort all day long. Plus style, of course.Color shown: Blue / Navy Blue / Wonder White. Product code: GV7723", "Adidas", 1949m, false, "ULTRABOOST 1.0 DNA!" },
                    { 14, 2, "/Images/loparskor-hart-underlag-air-zoom-pegasus-38-rPC6SB.jpg", "/Images/loparskor-hart-underlag-air-zoom-pegasus-38-rPC6SB.jpg", true, "Your workhorse with wings is back in colors and shapes inspired by your winter favorites. The Nike Air Zoom Pegasus 38 Premium continues to give you extra weight in the step, with the same responsive foam material as its predecessor. Airy mesh combines the comfortable feel and durability you want with a wider fit at the toes. Get out with a running classic with a winter-inspired twist.Color shown: Blue Tint/Regal Pink/Light Smoke Grey/Multicolored. Product code: DC8796-400", "Nike", 1399m, false, "Air Zoom Pegasus 38 Premium!" },
                    { 15, 2, "/Images/sko-air-max-270-WM5Xd6.jpg", "/Images/sko-air-max-270-WM5Xd6.jpg", true, "Nike's first lifestyle Air Max gives you style, a comfortable feel and the right attitude in the Nike Air Max 270. Inspired by Air Max icons, the design showcases Nike's greatest innovation with its large window and new colors.Color shown: White/White/Black. Style: AH6789-100", "Nike", 1699m, false, "Air Max 270!" },
                    { 16, 2, "/Images/sko-dunk-low-se-GpdDGH.jpg", "/Images/sko-dunk-low-se-GpdDGH.jpg", true, "It was created for the basketball court but became an icon of street fashion. Now the basketball icon is back with metallic animal patterns and details that show off your wild side. The classic Nike Dunk Low SE basketball look gives you vintage-inspired style and the padded, low heel cap makes this model extra comfortable.Color shown: Fossil Stone/Fossil Stone/Multicolored. Style: DD7099-200", "Nike", 1249m, true, "Dunk Low SE!" },
                    { 17, 2, "/Images/golfsko-air-max-270-g-qdKfmN.jpg", "/Images/golfsko-air-max-270-g-qdKfmN.jpg", true, "Get a legendary look with the Nike Air Max 270 G. The silhouette is an accurate reconstruction of the classic Air model but has been updated with airy mesh material and an innovative grip for top-level gaming.Color shown: Black/Hot Punch/White. Style: CK6483-001", "Nike", 1699m, true, "Air Max 270 G!" },
                    { 18, 2, "/Images/basketsko-lebron-19-jFVxZC.jpg", "/Images/basketsko-lebron-19-jFVxZC.jpg", true, "LeBron likes when the stakes are high and the pressure is hard. LeBron 19 harnesses that energy with a molded fit and an updated cushioning system. The tight inner shoe is held together by a molded top layer. The shoelaces go through the top layer and prevent the foot from moving inside the shoe. Embedded cushions in the tongue and heel cap provide lower weight and support for the ankle. It gives the player a confident feeling and the confidence to give everything to decide the match.Color shown: Mantra Orange/University Gold/University Red/Light Blue Fury. Style: DC9338-800", "Nike", 1699m, true, "LeBron 19!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 18);
        }
    }
}
