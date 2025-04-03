﻿// <auto-generated />
using System;
using BeautyLingerie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeautyLingerie.Data.Migrations
{
    [DbContext(typeof(BeautyLingerieDbContext))]
    [Migration("20250403191236_orderProducttable")]
    partial class orderProducttable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeautyLingerie.Data.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"),
                            Name = "Bikini"
                        },
                        new
                        {
                            CategoryId = new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"),
                            Name = "Underwear"
                        },
                        new
                        {
                            CategoryId = new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"),
                            Name = "Others"
                        });
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.Color", b =>
                {
                    b.Property<Guid>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ColorId = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                            Name = "Red"
                        },
                        new
                        {
                            ColorId = new Guid("21ec2020-3aea-4069-a2dd-08002b30309d"),
                            Name = "Blue"
                        },
                        new
                        {
                            ColorId = new Guid("ed6958ab-267e-4148-97f2-e1d9d4fcd8b7"),
                            Name = "Yellow"
                        },
                        new
                        {
                            ColorId = new Guid("68e3f5e2-6f52-4095-85c6-70bfb0d80b29"),
                            Name = "Green"
                        },
                        new
                        {
                            ColorId = new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"),
                            Name = "Black"
                        },
                        new
                        {
                            ColorId = new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"),
                            Name = "White"
                        },
                        new
                        {
                            ColorId = new Guid("a2d6b5cb-2a3e-4d58-a7fc-e42a67c4ff7d"),
                            Name = "Orange"
                        },
                        new
                        {
                            ColorId = new Guid("b6eb6d37-6d69-4b82-a5ec-9cf9a2e547a1"),
                            Name = "Purple"
                        },
                        new
                        {
                            ColorId = new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"),
                            Name = "Pink"
                        },
                        new
                        {
                            ColorId = new Guid("5531e2b6-0f72-40f8-9d62-6e7fc621c3f4"),
                            Name = "Brown"
                        },
                        new
                        {
                            ColorId = new Guid("a3a0a98e-7e51-4c32-9c2b-b00d9057ed9a"),
                            Name = "Gray"
                        },
                        new
                        {
                            ColorId = new Guid("b5b14f99-b75d-4017-bdd2-2fc08c30f35a"),
                            Name = "Cyan"
                        },
                        new
                        {
                            ColorId = new Guid("c1c34f64-c8e3-4d43-b8f2-d9ad4c2fbc2a"),
                            Name = "Magenta"
                        },
                        new
                        {
                            ColorId = new Guid("d7d6aeba-45b8-49c5-bf80-1d12c967ce5d"),
                            Name = "Lime"
                        },
                        new
                        {
                            ColorId = new Guid("e6e7a663-32b3-4c8f-a1da-051ac8e5dca9"),
                            Name = "Teal"
                        },
                        new
                        {
                            ColorId = new Guid("f3f4a0a4-12cb-4f5f-b3a8-3c8c8ea5dc1c"),
                            Name = "Indigo"
                        },
                        new
                        {
                            ColorId = new Guid("111a1245-7c45-4a12-baf4-cbdb5e85f7e6"),
                            Name = "Turquoise"
                        },
                        new
                        {
                            ColorId = new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"),
                            Name = "Multicolor"
                        });
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("TotalSum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.OrderProduct", b =>
                {
                    b.Property<Guid>("OrderProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PriceAtOrderTime")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("SizeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("SizeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("a06d65dc-2ed2-416e-8795-71a81be2f11c"),
                            CategoryId = new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"),
                            ColorId = new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"),
                            CreatedOn = new DateTime(2025, 4, 3, 19, 12, 35, 771, DateTimeKind.Utc).AddTicks(2696),
                            Description = "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.",
                            ImageUrl = "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/zaplviqvawybdtxwgoto.jpg",
                            Name = "Tropical Breeze Bikini",
                            Price = 26.00m,
                            Quantity = 3,
                            SizeId = new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2")
                        },
                        new
                        {
                            ProductId = new Guid("d32067bb-ba8e-4861-bac9-17f89f73cc97"),
                            CategoryId = new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"),
                            ColorId = new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"),
                            CreatedOn = new DateTime(2025, 4, 3, 19, 12, 35, 771, DateTimeKind.Utc).AddTicks(2712),
                            Description = "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.",
                            ImageUrl = "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/jvvbilveebrqwey5vnn9.jpg",
                            Name = "Beautiful Pink Lace Underwear",
                            Price = 3.50m,
                            Quantity = 5,
                            SizeId = new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da")
                        },
                        new
                        {
                            ProductId = new Guid("5fdb379c-585c-45c1-81f5-4827d914fc2d"),
                            CategoryId = new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"),
                            ColorId = new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"),
                            CreatedOn = new DateTime(2025, 4, 3, 19, 12, 35, 771, DateTimeKind.Utc).AddTicks(2718),
                            Description = "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.",
                            ImageUrl = "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/w0hvcjfrp7tcbucmszu1.jpg",
                            Name = "Elegant White Lace Bra",
                            Price = 12.99m,
                            Quantity = 7,
                            SizeId = new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e")
                        },
                        new
                        {
                            ProductId = new Guid("a1721f5f-f61a-4904-90cd-e420b5be3b9e"),
                            CategoryId = new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"),
                            ColorId = new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"),
                            CreatedOn = new DateTime(2025, 4, 3, 19, 12, 35, 771, DateTimeKind.Utc).AddTicks(2724),
                            Description = "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.",
                            ImageUrl = "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/rbku1kdduiuluc8jq6qy.jpg",
                            Name = "Chic Black Lace Tank Top",
                            Price = 29.99m,
                            Quantity = 7,
                            SizeId = new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7")
                        });
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.Size", b =>
                {
                    b.Property<Guid>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("SizeId");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            SizeId = new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7"),
                            Name = "S"
                        },
                        new
                        {
                            SizeId = new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da"),
                            Name = "M"
                        },
                        new
                        {
                            SizeId = new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2"),
                            Name = "L"
                        },
                        new
                        {
                            SizeId = new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e"),
                            Name = "XL"
                        },
                        new
                        {
                            SizeId = new Guid("ae2b67e1-df68-4e2d-9c3a-8b6e1e8b9f3c"),
                            Name = "XXL"
                        });
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.WishList", b =>
                {
                    b.Property<Guid>("WishListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("WishListId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("WishList");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.Customer", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.OrderProduct", b =>
                {
                    b.HasOne("BeautyLingerie.Data.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyLingerie.Data.Models.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.Product", b =>
                {
                    b.HasOne("BeautyLingerie.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyLingerie.Data.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyLingerie.Data.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.WishList", b =>
                {
                    b.HasOne("BeautyLingerie.Data.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyLingerie.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("BeautyLingerie.Data.Models.Product", b =>
                {
                    b.Navigation("OrderProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
