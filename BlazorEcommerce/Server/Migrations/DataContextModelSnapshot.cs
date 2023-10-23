﻿// <auto-generated />
using System;
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "ProductTypeId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Video Games",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId", "ProductTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Title = "The Hitchhiker's Guide to the Galaxy"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Dune is a 1965 epic science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966 and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune Chronicles. It is one of the world's best-selling science fiction novels.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg",
                            Title = "Dune"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "The Lord of the Rings is an epic high-fantasy novel by the English author and scholar J. R. R. Tolkien. Set in Middle-earth, the story began as a sequel to Tolkien's 1937 children's book The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.[2]",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e9/First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif",
                            Title = "The Lord of the Rings"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "The Creator is a 2023 American science fiction film produced and directed by Gareth Edwards, who co-wrote the screenplay with Chris Weitz. The film stars John David Washington, Gemma Chan, Ken Watanabe, Sturgill Simpson, Allison Janney, and Madeleine Yuna Voyles (in her film debut). Set in 2055 after a nuclear detonation in Los Angeles and a war against artificial intelligence, an ex-special forces agent is recruited to hunt down and kill the \"Creator\", who has developed a mysterious weapon with the power to end the war.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/94/The_Creator_2023_poster.jpg",
                            Title = "The Creator"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Napoleon is an upcoming epic historical drama film directed and produced by Ridley Scott and written by David Scarpa. Based on the true story of Napoleon Bonaparte, primarily depicting the French leader's rise to power as well as his relationship with Empress Joséphine, the film stars Joaquin Phoenix (who is also a producer) as Napoleon, and features Vanessa Kirby alongside Tahar Rahim in supporting roles.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/2e/Napoleon_Film_poster.jpg",
                            Title = "Napoleon"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "The Witcher 3: Wild Hunt is a 2015 action role-playing game developed and published by CD Projekt. It is the sequel to the 2011 game The Witcher 2: Assassins of Kings and the third game in The Witcher video game series, played in an open world with a third-person perspective. The games follow the Witcher series of fantasy novels written by Andrzej Sapkowski.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Witcher_3_cover_art.jpg",
                            Title = "The Witcher 3: Wild Hunt"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Assassin's Creed Mirage is an action-adventure game developed by Ubisoft Bordeaux and published by Ubisoft. The game is the thirteenth major installment in the Assassin's Creed series and the successor to 2020's Assassin's Creed Valhalla. While its historical timeframe precedes that of Valhalla, its modern-day framing story succeeds Valhalla's own. Set in 9th-century Baghdad during the Islamic Golden Age—in particular during the Anarchy at Samarra—the story follows Basim Ibn Ishaq (a character first introduced in Valhalla), a street thief who joins the Hidden Ones to fight for peace and liberty, against the Order of the Ancients,[b] who desire peace through control. The main narrative focuses on Basim's internal struggle between his duties as a Hidden One and his desire to uncover his mysterious past.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/23/Assassin%27s_Creed_Mirage_cover.jpeg",
                            Title = "Assassin's Creed Mirage"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "God of War is an action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment. It was released for the PlayStation 4 in April 2018, with a Windows port in January 2022. The game is the eighth installment in the God of War series, the eighth chronologically, and the sequel to 2010's God of War III.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a7/God_of_War_4_cover.jpg",
                            Title = "God of War"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Star Wars Jedi: Fallen Order is a 2019 action-adventure game developed by Respawn Entertainment and published by Electronic Arts. The story is set in the Star Wars universe, five years after Star Wars: Episode III – Revenge of the Sith. It follows Jedi Padawan Cal Kestis, who becomes a target of the Galactic Empire and is hunted throughout the galaxy by the Imperial Inquisitors while attempting to complete his training, reconcile with his troubled past, and rebuild the fallen Jedi Order. ",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Cover_art_of_Star_Wars_Jedi_Fallen_Order.jpg",
                            Title = "Star Wars Jedi: Fallen Order"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 3,
                            Name = "E-book"
                        },
                        new
                        {
                            Id = 4,
                            Name = "AudioBook"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Stream"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Blu-Ray"
                        },
                        new
                        {
                            Id = 7,
                            Name = "VHS"
                        },
                        new
                        {
                            Id = 8,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 9,
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            OriginalPrice = 19.99m,
                            Price = 10.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 3,
                            OriginalPrice = 29.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 4,
                            OriginalPrice = 19.99m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 3,
                            OriginalPrice = 19.99m,
                            Price = 5.99m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2,
                            OriginalPrice = 39.99m,
                            Price = 15.99m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 2,
                            OriginalPrice = 39.99m,
                            Price = 15.99m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 3,
                            OriginalPrice = 19.99m,
                            Price = 5.99m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 4,
                            OriginalPrice = 19.99m,
                            Price = 8.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 5,
                            OriginalPrice = 39.99m,
                            Price = 29.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 6,
                            OriginalPrice = 39.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 7,
                            OriginalPrice = 39.99m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 5,
                            OriginalPrice = 39.99m,
                            Price = 12.99m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 6,
                            OriginalPrice = 39.99m,
                            Price = 10.99m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 7,
                            OriginalPrice = 39.99m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 10,
                            OriginalPrice = 59.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 9,
                            OriginalPrice = 59.99m,
                            Price = 12.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 10,
                            OriginalPrice = 59.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 8,
                            OriginalPrice = 59.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 8,
                            ProductTypeId = 9,
                            OriginalPrice = 59.99m,
                            Price = 10.99m
                        },
                        new
                        {
                            ProductId = 9,
                            ProductTypeId = 8,
                            OriginalPrice = 59.99m,
                            Price = 9.99m
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Address", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.User", null)
                        .WithOne("Address")
                        .HasForeignKey("BlazorEcommerce.Shared.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.OrderItem", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorEcommerce.Shared.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorEcommerce.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.ProductVariant", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorEcommerce.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.User", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
