using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakersFootprint.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sneakers",
                columns: table => new
                {
                    SneakerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sale = table.Column<bool>(type: "bit", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sneakers", x => x.SneakerId);
                    table.ForeignKey(
                        name: "FK_Sneakers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    SneakerId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Sneakers_SneakerId",
                        column: x => x.SneakerId,
                        principalTable: "Sneakers",
                        principalColumn: "SneakerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SneakerId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Sneakers_SneakerId",
                        column: x => x.SneakerId,
                        principalTable: "Sneakers",
                        principalColumn: "SneakerId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                values: new object[,]
                {
                    { 1, 1, "/Images/sko-air-huarache-le-7ggQkX.jpg", "/Images/sko-air-huarache-le-7ggQkX.jpg", true, "The Nike Air Huarache LE is a favorite with a street feel. A comfortable shoe with an excellent fit. The upper combines elegant leather details with a super airy, glossy neoprene-like material that provides many styling options. Classic heel clip and stripped-down brand details give a look from the early 90's.Color shown: Shadow/Black/Midnight Navy. Style: DH8143 - 400", "Nike Air Huarache LE", 1199.95m, true, "Size. EU 42" },
                    { 7, 3, "/Images/sko-flex-advance-L44DwQ.jpg", "/Images/sko-flex-advance-L44DwQ.jpg", true, "The Nike Flex Advance is as simple as counting to three. Nike FlyEase technology provides an extra wide opening so small feet can slide in effortlessly (seriously, it's as easy as it gets). Cross the ribbons (to prepare the kids for real shoelaces) and then it's done. They are super flexible, comfortable and durable – perfect for the little ones to walk, run and play in.Color shown: Black/Siren Red/Medium Ash/White. Product code: CZ0186-005", "Nike Flex Advance", 649m, true, "Size. EU 36" },
                    { 6, 3, "/Images/sko-huarache-run-zsL2zh.jpg", "/Images/sko-huarache-run-zsL2zh.jpg", true, "The Nike Huarache Run has an unmistakable style. The shoe is equipped with the famous Huarache heel strap that allows you to easily stick your foot in it. An inner shoe that sits comfortably around the foot and provides safety and support when running, climbing and playing.Color shown: White/Off Noir/Mint Foam. Product code: 704949-116", "Nike Huarache Run", 949m, false, "Size. EU 31" },
                    { 5, 3, "/Images/sko-air-max-90-ltr-BpFdfH.jpg", "/Images/sko-air-max-90-ltr-BpFdfH.jpg", true, "In the past, it was revolutionary. Today? Today it is iconic. The Nike Air Max 90 LTR SE is back with a design that's more suited for kids than the original. The update has a softer cushioning, more flexibility and a more comfortable feel. This special edition is inspired by medals that celebrate us all as winners.Color shown: Off Noir/Black/Summit White/Metallic Pewte. Product code: CD6864-117", "Nike Air Max 90 LTR", 1249m, false, "Size. EU 29.5" },
                    { 3, 3, "/Images/loparskor-flex-runner-sTBg4T.jpg", "/Images/loparskor-flex-runner-sTBg4T.jpg", true, "Forget the lacing – you can just pull these on. Run around the block or compete with your friends – Nike Flex Runner makes everything easy. The foam sole is super flexible so that each step and jump is as easy as 1, 2, 3.Color shown: Medium Ash/Siren Red/Black. Style: AT4662-200", "Nike Flex Runner", 499.95m, false, "Size. EU 35.5" },
                    { 18, 2, "/Images/basketsko-lebron-19-jFVxZC.jpg", "/Images/basketsko-lebron-19-jFVxZC.jpg", true, "LeBron likes when the stakes are high and the pressure is hard. LeBron 19 harnesses that energy with a molded fit and an updated cushioning system. The tight inner shoe is held together by a molded top layer. The shoelaces go through the top layer and prevent the foot from moving inside the shoe. Embedded cushions in the tongue and heel cap provide lower weight and support for the ankle. It gives the player a confident feeling and the confidence to give everything to decide the match.Color shown: Mantra Orange/University Gold/University Red/Light Blue Fury. Style: DC9338-800", "Nike LeBron 19", 1699m, true, "Size. EU 41" },
                    { 17, 2, "/Images/golfsko-air-max-270-g-qdKfmN.jpg", "/Images/golfsko-air-max-270-g-qdKfmN.jpg", true, "Get a legendary look with the Nike Air Max 270 G. The silhouette is an accurate reconstruction of the classic Air model but has been updated with airy mesh material and an innovative grip for top-level gaming.Color shown: Black/Hot Punch/White. Style: CK6483-001", "Nike Air Max 270 G", 1699m, true, "Size. EU 40" },
                    { 16, 2, "/Images/sko-dunk-low-se-GpdDGH.jpg", "/Images/sko-dunk-low-se-GpdDGH.jpg", true, "It was created for the basketball court but became an icon of street fashion. Now the basketball icon is back with metallic animal patterns and details that show off your wild side. The classic Nike Dunk Low SE basketball look gives you vintage-inspired style and the padded, low heel cap makes this model extra comfortable.Color shown: Fossil Stone/Fossil Stone/Multicolored. Style: DD7099-200", "Nike Dunk Low SE", 1249m, true, "Size. EU 39" },
                    { 15, 2, "/Images/sko-air-max-270-WM5Xd6.jpg", "/Images/sko-air-max-270-WM5Xd6.jpg", true, "Nike's first lifestyle Air Max gives you style, a comfortable feel and the right attitude in the Nike Air Max 270. Inspired by Air Max icons, the design showcases Nike's greatest innovation with its large window and new colors.Color shown: White/White/Black. Style: AH6789-100", "Nike Air Max 270", 1699m, false, "Size. EU 42" },
                    { 14, 2, "/Images/loparskor-hart-underlag-air-zoom-pegasus-38-rPC6SB.jpg", "/Images/loparskor-hart-underlag-air-zoom-pegasus-38-rPC6SB.jpg", true, "Your workhorse with wings is back in colors and shapes inspired by your winter favorites. The Nike Air Zoom Pegasus 38 Premium continues to give you extra weight in the step, with the same responsive foam material as its predecessor. Airy mesh combines the comfortable feel and durability you want with a wider fit at the toes. Get out with a running classic with a winter-inspired twist.Color shown: Blue Tint/Regal Pink/Light Smoke Grey/Multicolored. Product code: DC8796-400", "Nike Air Zoom Pegasus 38 Premium", 1399m, false, "Size. EU 41.5" },
                    { 2, 2, "/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4.jpg", "/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4.jpg", true, "Get ready to reach your next personal best in this road shoe that's made for fast movement. It gives you the best energy reproduction of all our race shoes with a forward feel all the way across the finish line. The design is lightweight, breathable and designed using scientific data to give you a comfortable fit. The details celebrate our shared ability to take on tough challenges.Color shown: White/Black/Pink. Style: DJ5456-100", "Nike Air Zoom Alphafly", 779.95m, false, "Size. EU 39" },
                    { 13, 1, "/Images/Ultraboost_1.0_DNA_Shoes_Bla_GV7723_06.jpg", "/Images/Ultraboost_1.0_DNA_Shoes_Bla_GV7723_06.jpg", true, "You are responsible for the energy. These running shoes from adidas give it back. That's the magic behind the legendary Ultraboost design. This pair brings the OG adidas Primeknit pattern from 2015 to life as a tribute to the beloved shoe. Lace up and experience comfort all day long. Plus style, of course.Color shown: Blue / Navy Blue / Wonder White. Product code: GV7723", "Adidas ULTRABOOST 1.0 DNA", 1949m, false, "Size. EU 39" },
                    { 12, 1, "/Images/NMD_R1_Vit_GX1050_06_standard.jpg", "/Images/NMD_R1_Vit_GX1050_06_standard.jpg", true, "Pack your bag, lace up your shoes and get out. City adventures call when you have these NMD_R1 shoes on your feet. These modern sneakers are an update to an acclaimed 80s running shoe from the adidas archive, with a soft and stretchy knitted upper as well as energy-restoring Boost cushioning for all-day comfort. The strong colors and distinctive plugs in the midsole serve as a statement and max out the style level wherever you go. This product is made of Primeblue, a recycled functional material partly created with Parley Ocean Plastic. 50% of the upper is made of textile, 75% of the textile is Primeblue yarn. No newly produced polyester.Color shown: Kumquat/Photon Dust/White/Pomegranate. Product code: GZ7925", "Adidas NMD_R1", 1499m, true, "Size. EU 40" },
                    { 11, 1, "/Images/sko-air-max-pre-day-W67m0w.jpg", "/Images/sko-air-max-pre-day-W67m0w.jpg", true, "Inspired by Nike's classic running shoes, the Nike Air Max Pre-Day features a design that creates a modern sense of speed. The shoe is a true tribute to history and is made of at least 20% recycled material in relation to its weight and has a running-inspired retro design. A new Air window attracts the eye along with an incredibly soft cushioning.Color shown: Kumquat/Photon Dust/White/Pomegranate. Product code: DC9402-800", "Nike Air Max Pre-Day", 1449m, true, "Size. EU 43" },
                    { 10, 1, "/Images/skor-air-max-plus-Pc62Zg.jpg", "/Images/skor-air-max-plus-Pc62Zg.jpg", true, "These sneakers are loaded with extra stability and cushioning. The top layers have stood the test of time since the original made an impression in '98.The design of the mesh material is inspired by crushed ice, creating a cool nod to outdoor activities in winter.Color shown: Black/White/Dark Smoke Grey/Black. Product code: DO6384-001", "Nike Air Max Plus", 1899m, false, "Size. EU 40.5" },
                    { 4, 1, "/Images/Ultraboost_4.0_DNA_Shoes_black.jpg", "/Images/Ultraboost_4.0_DNA_Shoes_black.jpg", true, "Precision-made, seamless zones combine strength and function with smooth comfort to ensure interference-free movements.Color shown: Core Black. Product code: FY9121", "Adidas ULTRABOOST 4.0 DNA", 1299.95m, false, "Size. EU 42" },
                    { 8, 3, "/Images/sko-blazer-mid-77-2jP7Bp.jpg", "/Images/sko-blazer-mid-77-2jP7Bp.jpg", true, "Your little basketball player can own the court in the Nike Blazer Mid '77. The vintage look and comfortable feel make this classic a legendary street shoe even off the pitch..Color shown: Vit/Pecan/Vivid Sulfur. Product code: DA4087-103", "Nike Blazer Mid 77", 749m, false, "Size. EU 31" },
                    { 9, 3, "/Images/sko-air-max-270-xK8g2Z.jpg", "/Images/sko-air-max-270-xK8g2Z.jpg", true, "The Nike Air Max 270 shoe combines the long Nike Air Max 180 tongue with classic elements from the Air Max 93. The model has the largest Air unit ever from Nike on its heel and is as comfortable as it looks.Color shown: Black/Black. Product code: BQ5776-001", "Nike Air Max 270", 749m, false, "Size. EU 39" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SneakerId",
                table: "OrderDetails",
                column: "SneakerId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_SneakerId",
                table: "ShoppingCartItems",
                column: "SneakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sneakers_CategoryId",
                table: "Sneakers",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Sneakers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
