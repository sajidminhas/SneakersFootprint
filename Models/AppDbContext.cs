using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersFootprint.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Sneaker> Sneakers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Men's Sneakers" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Women's Sneakers" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Kid's Sneakers" });

            //seed Sneakers

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 1,
                Name = "Nike",
                Price = 1199.95M,
                ShortDescription = "Air Huarache LE!",
                LongDescription =
                    "The Nike Air Huarache LE is a favorite with a street feel. A comfortable shoe with an excellent fit. The upper combines elegant" +
                    " leather details with a super airy, glossy neoprene-like material that provides many styling options. Classic heel clip and " +
                    "stripped-down brand details give a look from the early 90's." +
                    "Color shown: Shadow/Black/Midnight Navy. Style: DH8143 - 400",
                CategoryId = 1,
                ImageUrl = "/Images/sko-air-huarache-le-7ggQkX.jpg",
                InStock = true,
                Sale = true,
                ImageThumbnailUrl = "/Images/sko-air-huarache-le-7ggQkX.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 2,
                Name = "Nike",
                Price = 779.95M,
                ShortDescription = "Air Zoom Alphafly!",
                LongDescription =
                    "Get ready to reach your next personal best in this road shoe that's made for fast movement. It gives you the best energy reproduction of all our race shoes with a forward feel all the way across the finish line. The design is lightweight, breathable and designed using scientific data to give you a comfortable fit. The details celebrate our shared ability to take on tough challenges." +
                    "Color shown: White/Black/Pink. Style: DJ5456-100",
                CategoryId = 2,
                ImageUrl = "/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4.jpg",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 3,
                Name = "Nike",
                Price = 499.95M,
                ShortDescription = "Flex Runner!",
                LongDescription =
                    "Forget the lacing – you can just pull these on. Run around the block or compete with your friends – Nike Flex Runner makes everything easy. The foam sole is super flexible so that each step and jump is as easy as 1, 2, 3." +
                    "Color shown: Medium Ash/Siren Red/Black. Style: AT4662-200",
                CategoryId = 3,
                ImageUrl = "/Images/loparskor-flex-runner-sTBg4T.jpg",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "/Images/loparskor-flex-runner-sTBg4T.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 4,
                Name = "Adidas",
                Price = 1299.95M,
                ShortDescription = "ULTRABOOST 4.0 DNA!",
                LongDescription =
                    "Precision-made, seamless zones combine strength and function with smooth comfort to ensure interference-free movements." +
                    "Color shown: Core Black. Product code: FY9121",
                CategoryId = 1,
                ImageUrl = "/Images/Ultraboost_4.0_DNA_Shoes_black.jpg",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "/Images/Ultraboost_4.0_DNA_Shoes_black.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 5,
                Name = "Nike",
                Price = 1249M,
                ShortDescription = "Nike Air Max 90 LTR!",
                LongDescription =
                   "In the past, it was revolutionary. Today? Today it is iconic. The Nike Air Max 90 LTR SE is back with a design that's more suited for kids than the original. The update has a softer cushioning, more flexibility and a more comfortable feel. This special edition is inspired by medals that celebrate us all as winners." +
                   "Color shown: Off Noir/Black/Summit White/Metallic Pewte. Product code: CD6864-117",
                CategoryId = 3,
                ImageUrl = "/Images/sko-air-max-90-ltr-BpFdfH.jpg",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "/Images/sko-air-max-90-ltr-BpFdfH.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 6,
                Name = "Nike",
                Price = 949M,
                ShortDescription = "Huarache Run!",
                LongDescription =
                   "The Nike Huarache Run has an unmistakable style. The shoe is equipped with the famous Huarache heel strap that allows you to easily stick your foot in it. An inner shoe that sits comfortably around the foot and provides safety and support when running, climbing and playing." +
                   "Color shown: White/Off Noir/Mint Foam. Product code: 704949-116",
                CategoryId = 3,
                ImageUrl = "/Images/sko-huarache-run-zsL2zh.jpg",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "/Images/sko-huarache-run-zsL2zh.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 7,
                Name = "Nike",
                Price = 649M,
                ShortDescription = "Flex Advance!",
                LongDescription =
                  "The Nike Flex Advance is as simple as counting to three. Nike FlyEase technology provides an extra wide opening so small feet can slide in effortlessly (seriously, it's as easy as it gets). Cross the ribbons (to prepare the kids for real shoelaces) and then it's done. They are super flexible, comfortable and durable – perfect for the little ones to walk, run and play in." +
                  "Color shown: Black/Siren Red/Medium Ash/White. Product code: CZ0186-005",
                CategoryId = 3,
                ImageUrl = "/Images/sko-flex-advance-L44DwQ.jpg",
                InStock = true,
                Sale = true,
                ImageThumbnailUrl = "/Images/sko-flex-advance-L44DwQ.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 8,
                Name = "Nike",
                Price = 749M,
                ShortDescription = "Blazer Mid '77!",
                LongDescription =
                 "Your little basketball player can own the court in the Nike Blazer Mid '77. The vintage look and comfortable feel make this classic a legendary street shoe even off the pitch.." +
                 "Color shown: Vit/Pecan/Vivid Sulfur. Product code: DA4087-103",
                CategoryId = 3,
                ImageUrl = "/Images/sko-blazer-mid-77-2jP7Bp.jpg",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "/Images/sko-blazer-mid-77-2jP7Bp.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 9,
                Name = "Nike",
                Price = 749M,
                ShortDescription = "Air Max 270!",
                LongDescription =
                 "The Nike Air Max 270 shoe combines the long Nike Air Max 180 tongue with classic elements from the Air Max 93. The model has the largest Air unit ever from Nike on its heel and is as comfortable as it looks." +
                 "Color shown: Black/Black. Product code: BQ5776-001",
                CategoryId = 3,
                ImageUrl = "/Images/sko-air-max-270-xK8g2Z.jpg",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "/Images/sko-air-max-270-xK8g2Z.jpg",
            });

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 10,
                Name = "Nike",
                Price = 1899M,
                ShortDescription = "Air Max Plus!",
                LongDescription =
                 "These sneakers are loaded with extra stability and cushioning. The top layers have stood the test of time since the original made an impression in '98.The design of the mesh material is inspired by crushed ice, creating a cool nod to outdoor activities in winter." +
                 "Color shown: Black/White/Dark Smoke Grey/Black. Product code: DO6384-001",
                CategoryId = 1,
                ImageUrl = "/Images/skor-air-max-plus-Pc62Zg.jpg",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "/Images/skor-air-max-plus-Pc62Zg.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 11,
                Name = "Nike",
                Price = 1449M,
                ShortDescription = "Air Max Pre-Day!",
                LongDescription =
                 "Inspired by Nike's classic running shoes, the Nike Air Max Pre-Day features a design that creates a modern sense of speed. The shoe is a true tribute to history and is made of at least 20% recycled material in relation to its weight and has a running-inspired retro design. A new Air window attracts the eye along with an incredibly soft cushioning." +
                 "Color shown: Kumquat/Photon Dust/White/Pomegranate. Product code: DC9402-800",
                CategoryId = 1,
                ImageUrl = "/Images/sko-air-max-pre-day-W67m0w.jpg",
                InStock = true,
                Sale = true,
                ImageThumbnailUrl = "/Images/sko-air-max-pre-day-W67m0w.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 12,
                Name = "Adidas",
                Price = 1499M,
                ShortDescription = "NMD_R1!",
                LongDescription =
                 "Pack your bag, lace up your shoes and get out. City adventures call when you have these NMD_R1 shoes on your feet. These modern sneakers are an update to an acclaimed 80s running shoe from the adidas archive, with a soft and stretchy knitted upper as well as energy-restoring Boost cushioning for all-day comfort. The strong colors and distinctive plugs in the midsole serve as a statement and max out the style level wherever you go. This product is made of Primeblue, a recycled functional material partly created with Parley Ocean Plastic. 50% of the upper is made of textile, 75% of the textile is Primeblue yarn. No newly produced polyester." +
                 "Color shown: Kumquat/Photon Dust/White/Pomegranate. Product code: GZ7925",
                CategoryId = 1,
                ImageUrl = "/Images/NMD_R1_Vit_GX1050_06_standard.jpg",
                InStock = true,
                Sale = true,
                ImageThumbnailUrl = "/Images/NMD_R1_Vit_GX1050_06_standard.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 13,
                Name = "Adidas",
                Price = 1949M,
                ShortDescription = "ULTRABOOST 1.0 DNA!",
                LongDescription =
                 "You are responsible for the energy. These running shoes from adidas give it back. That's the magic behind the legendary Ultraboost design. This pair brings the OG adidas Primeknit pattern from 2015 to life as a tribute to the beloved shoe. Lace up and experience comfort all day long. Plus style, of course." +
                 "Color shown: Blue / Navy Blue / Wonder White. Product code: GV7723",
                CategoryId = 1,
                ImageUrl = "/Images/Ultraboost_1.0_DNA_Shoes_Bla_GV7723_06.jpg",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "/Images/Ultraboost_1.0_DNA_Shoes_Bla_GV7723_06.jpg",

            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 14,
                Name = "Nike",
                Price = 1399M,
                ShortDescription = "Air Zoom Pegasus 38 Premium!",
                LongDescription =
                 "Your workhorse with wings is back in colors and shapes inspired by your winter favorites. The Nike Air Zoom Pegasus 38 Premium continues to give you extra weight in the step, with the same responsive foam material as its predecessor. Airy mesh combines the comfortable feel and durability you want with a wider fit at the toes. Get out with a running classic with a winter-inspired twist." +
                 "Color shown: Blue Tint/Regal Pink/Light Smoke Grey/Multicolored. Product code: DC8796-400",
                CategoryId = 2,
                ImageUrl = "/Images/loparskor-hart-underlag-air-zoom-pegasus-38-rPC6SB.jpg",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "/Images/loparskor-hart-underlag-air-zoom-pegasus-38-rPC6SB.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 15,
                Name = "Nike",
                Price = 1699M,
                ShortDescription = "Air Max 270!",
                LongDescription =
                    "Nike's first lifestyle Air Max gives you style, a comfortable feel and the right attitude in the Nike Air Max 270. Inspired by Air Max icons, the design showcases Nike's greatest innovation with its large window and new colors." +
                    "Color shown: White/White/Black. Style: AH6789-100",
                CategoryId = 2,
                ImageUrl = "/Images/sko-air-max-270-WM5Xd6.jpg",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "/Images/sko-air-max-270-WM5Xd6.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 16,
                Name = "Nike",
                Price = 1249M,
                ShortDescription = "Dunk Low SE!",
                LongDescription =
                    "It was created for the basketball court but became an icon of street fashion. Now the basketball icon is back with metallic animal patterns and details that show off your wild side. The classic Nike Dunk Low SE basketball look gives you vintage-inspired style and the padded, low heel cap makes this model extra comfortable." +
                    "Color shown: Fossil Stone/Fossil Stone/Multicolored. Style: DD7099-200",
                CategoryId = 2,
                ImageUrl = "/Images/sko-dunk-low-se-GpdDGH.jpg",
                InStock = true,
                Sale = true,
                ImageThumbnailUrl = "/Images/sko-dunk-low-se-GpdDGH.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 17,
                Name = "Nike",
                Price = 1699M,
                ShortDescription = "Air Max 270 G!",
                LongDescription =
                    "Get a legendary look with the Nike Air Max 270 G. The silhouette is an accurate reconstruction of the classic Air model but has been updated with airy mesh material and an innovative grip for top-level gaming." +
                    "Color shown: Black/Hot Punch/White. Style: CK6483-001",
                CategoryId = 2,
                ImageUrl = "/Images/golfsko-air-max-270-g-qdKfmN.jpg",
                InStock = true,
                Sale = true,
                ImageThumbnailUrl = "/Images/golfsko-air-max-270-g-qdKfmN.jpg",
            });
            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 18,
                Name = "Nike",
                Price = 1699M,
                ShortDescription = "LeBron 19!",
                LongDescription =
                    "LeBron likes when the stakes are high and the pressure is hard. LeBron 19 harnesses that energy with a molded fit and an updated cushioning system. The tight inner shoe is held together by a molded top layer. The shoelaces go through the top layer and prevent the foot from moving inside the shoe. Embedded cushions in the tongue and heel cap provide lower weight and support for the ankle. It gives the player a confident feeling and the confidence to give everything to decide the match." +
                    "Color shown: Mantra Orange/University Gold/University Red/Light Blue Fury. Style: DC9338-800",
                CategoryId = 2,
                ImageUrl = "/Images/basketsko-lebron-19-jFVxZC.jpg",
                InStock = true,
                Sale = true,
                ImageThumbnailUrl = "/Images/basketsko-lebron-19-jFVxZC.jpg",
            });
        }
    }

}
