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
                ImageUrl = "src=~/Images/sko-air-huarache-le-7ggQkX",
                InStock = true,
                Sale = true,
                ImageThumbnailUrl = "src=~/Images/sko-air-huarache-le-7ggQkX",
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
                ImageUrl = "~/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "~/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4",
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
                ImageUrl = "~/Images/loparskor-flex-runner-sTBg4T",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "~/Images/loparskor-flex-runner-sTBg4T",
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
                ImageUrl = "../Images/loparskor-flex-runner-sTBg4T",
                InStock = true,
                Sale = false,
                ImageThumbnailUrl = "../Images/loparskor-flex-runner-sTBg4T",
            });



        }
    }

}
