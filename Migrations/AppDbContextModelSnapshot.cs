﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SneakersFootprint.Models;

namespace SneakersFootprint.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SneakersFootprint.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Men's Sneakers"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Women's Sneakers"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Kid's Sneakers"
                        });
                });

            modelBuilder.Entity("SneakersFootprint.Models.Sneaker", b =>
                {
                    b.Property<int>("SneakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Sale")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SneakerId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Sneakers");

                    b.HasData(
                        new
                        {
                            SneakerId = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "src=~/Images/sko-air-huarache-le-7ggQkX.jpg",
                            ImageUrl = "src=~/Images/sko-air-huarache-le-7ggQkX.jpg",
                            InStock = true,
                            LongDescription = "The Nike Air Huarache LE is a favorite with a street feel. A comfortable shoe with an excellent fit. The upper combines elegant leather details with a super airy, glossy neoprene-like material that provides many styling options. Classic heel clip and stripped-down brand details give a look from the early 90's.Color shown: Shadow/Black/Midnight Navy. Style: DH8143 - 400",
                            Name = "Nike",
                            Price = 1199.95m,
                            Sale = true,
                            ShortDescription = "Air Huarache LE!"
                        },
                        new
                        {
                            SneakerId = 2,
                            CategoryId = 2,
                            ImageThumbnailUrl = "~/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4.jpg",
                            ImageUrl = "~/Images/tavlingsskor-vag-air-zoom-alphafly-next-flyknit-HqKDw4.jpg",
                            InStock = true,
                            LongDescription = "Get ready to reach your next personal best in this road shoe that's made for fast movement. It gives you the best energy reproduction of all our race shoes with a forward feel all the way across the finish line. The design is lightweight, breathable and designed using scientific data to give you a comfortable fit. The details celebrate our shared ability to take on tough challenges.Color shown: White/Black/Pink. Style: DJ5456-100",
                            Name = "Nike",
                            Price = 779.95m,
                            Sale = false,
                            ShortDescription = "Air Zoom Alphafly!"
                        },
                        new
                        {
                            SneakerId = 3,
                            CategoryId = 3,
                            ImageThumbnailUrl = "~/Images/loparskor-flex-runner-sTBg4T.jpg",
                            ImageUrl = "~/Images/loparskor-flex-runner-sTBg4T.jpg",
                            InStock = true,
                            LongDescription = "Forget the lacing – you can just pull these on. Run around the block or compete with your friends – Nike Flex Runner makes everything easy. The foam sole is super flexible so that each step and jump is as easy as 1, 2, 3.Color shown: Medium Ash/Siren Red/Black. Style: AT4662-200",
                            Name = "Nike",
                            Price = 499.95m,
                            Sale = false,
                            ShortDescription = "Flex Runner!"
                        },
                        new
                        {
                            SneakerId = 4,
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/Images/Ultraboost_4.0_DNA_Shoes_black.jpg",
                            ImageUrl = "~/Images/Ultraboost_4.0_DNA_Shoes_black.jpg",
                            InStock = true,
                            LongDescription = "Precision-made, seamless zones combine strength and function with smooth comfort to ensure interference-free movements.Color shown: Core Black. Product code: FY9121",
                            Name = "Adidas",
                            Price = 1299.95m,
                            Sale = false,
                            ShortDescription = "ULTRABOOST 4.0 DNA!"
                        });
                });

            modelBuilder.Entity("SneakersFootprint.Models.Sneaker", b =>
                {
                    b.HasOne("SneakersFootprint.Models.Category", "Category")
                        .WithMany("Sneakers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SneakersFootprint.Models.Category", b =>
                {
                    b.Navigation("Sneakers");
                });
#pragma warning restore 612, 618
        }
    }
}
