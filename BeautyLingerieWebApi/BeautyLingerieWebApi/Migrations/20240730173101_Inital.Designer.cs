﻿// <auto-generated />
using System;
using BeautyLingerieWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeautyLingerieWebApi.Migrations
{
    [DbContext(typeof(BeautyLingerieDbContext))]
    [Migration("20240730173101_Inital")]
    partial class Inital
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Cart", b =>
                {
                    b.Property<Guid>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CardId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.CartProduct", b =>
                {
                    b.Property<Guid>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Color", b =>
                {
                    b.Property<Guid>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Color");

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

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TownName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalSum")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.OrderProduct", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            ProductId = new Guid("bcad58c4-26be-49dc-98bb-e80e3472ff22"),
                            CategoryId = new Guid("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"),
                            ColorId = new Guid("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"),
                            Description = "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.",
                            ImageKey = "bikiniSeed",
                            Name = "Tropical Breeze Bikini",
                            Price = 26.00m,
                            Quantity = 3,
                            SizeId = new Guid("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2")
                        },
                        new
                        {
                            ProductId = new Guid("b5b768f7-5b62-4518-9ca5-fea60e8499a6"),
                            CategoryId = new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"),
                            ColorId = new Guid("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"),
                            Description = "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.",
                            ImageKey = "BraSeed",
                            Name = "Beautiful Pink Lace Underwear",
                            Price = 3.50m,
                            Quantity = 5,
                            SizeId = new Guid("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da")
                        },
                        new
                        {
                            ProductId = new Guid("18329236-93ce-4e00-ae57-e0d40ad414e3"),
                            CategoryId = new Guid("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"),
                            ColorId = new Guid("37bc840f-355e-4bb2-8b79-ccca593ee1c6"),
                            Description = "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.",
                            ImageKey = "braSeed",
                            Name = "Elegant White Lace Bra",
                            Price = 12.99m,
                            Quantity = 7,
                            SizeId = new Guid("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e")
                        },
                        new
                        {
                            ProductId = new Guid("711f5668-2d1d-4fbc-9376-8ca7f6559b2d"),
                            CategoryId = new Guid("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"),
                            ColorId = new Guid("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"),
                            Description = "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.",
                            ImageKey = "othersSeed",
                            Name = "Chic Black Lace Tank Top",
                            Price = 29.99m,
                            Quantity = 7,
                            SizeId = new Guid("d1b82e13-25c1-4d5e-98c3-769b9b48adf7")
                        });
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Size", b =>
                {
                    b.Property<Guid>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeId");

                    b.ToTable("Size");

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

            modelBuilder.Entity("BeautyLingerieWebApi.Models.WishList", b =>
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

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Cart", b =>
                {
                    b.HasOne("BeautyLingerieWebApi.Models.Customer", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("BeautyLingerieWebApi.Models.Cart", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.CartProduct", b =>
                {
                    b.HasOne("BeautyLingerieWebApi.Models.Cart", "Cart")
                        .WithMany("CartProduct")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyLingerieWebApi.Models.Product", "Product")
                        .WithMany("CartProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Order", b =>
                {
                    b.HasOne("BeautyLingerieWebApi.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.OrderProduct", b =>
                {
                    b.HasOne("BeautyLingerieWebApi.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyLingerieWebApi.Models.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Product", b =>
                {
                    b.HasOne("BeautyLingerieWebApi.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyLingerieWebApi.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyLingerieWebApi.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.WishList", b =>
                {
                    b.HasOne("BeautyLingerieWebApi.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyLingerieWebApi.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Cart", b =>
                {
                    b.Navigation("CartProduct");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Customer", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("BeautyLingerieWebApi.Models.Product", b =>
                {
                    b.Navigation("CartProduct");

                    b.Navigation("OrderProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
