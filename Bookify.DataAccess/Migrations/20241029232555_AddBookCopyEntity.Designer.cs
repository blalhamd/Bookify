﻿// <auto-generated />
using System;
using Bookify.DataAccess.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookify.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241029232555_AddBookCopyEntity")]
    partial class AddBookCopyEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence<int>("SerialNumber", "Shared")
                .StartsAt(10000001L)
                .IncrementsBy(2);

            modelBuilder.Entity("Bookify.Entities.entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FirstModificationByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModificationByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2851),
                            IsDeleted = false,
                            Name = "Taha Hussien",
                            Nationality = "Egypt"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2858),
                            IsDeleted = false,
                            Name = "Naguib Mahfouz",
                            Nationality = "Egypt"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2861),
                            IsDeleted = false,
                            Name = "Mahmoud Darwish",
                            Nationality = "Palestine"
                        },
                        new
                        {
                            Id = 4,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2865),
                            IsDeleted = false,
                            Name = "Khalil Gibran",
                            Nationality = "Lebanon"
                        },
                        new
                        {
                            Id = 5,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2868),
                            IsDeleted = false,
                            Name = "Adonis",
                            Nationality = "Syria"
                        },
                        new
                        {
                            Id = 6,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2874),
                            IsDeleted = false,
                            Name = "Hanan al-Shaykh",
                            Nationality = "Lebanon"
                        },
                        new
                        {
                            Id = 7,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2877),
                            IsDeleted = false,
                            Name = "Ahlam Mosteghanemi",
                            Nationality = "Algeria"
                        },
                        new
                        {
                            Id = 8,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2881),
                            IsDeleted = false,
                            Name = "Ibrahim Nasrallah",
                            Nationality = "Palestine"
                        },
                        new
                        {
                            Id = 9,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2884),
                            IsDeleted = false,
                            Name = "Hanan al-Shaykh",
                            Nationality = "Lebanon"
                        },
                        new
                        {
                            Id = 10,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2888),
                            IsDeleted = false,
                            Name = "Nawal El Saadawi",
                            Nationality = "Egypt"
                        },
                        new
                        {
                            Id = 11,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2892),
                            IsDeleted = false,
                            Name = "Yasmina Khadra",
                            Nationality = "Algeria"
                        },
                        new
                        {
                            Id = 12,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2895),
                            IsDeleted = false,
                            Name = "Salman Rushdie",
                            Nationality = "India"
                        },
                        new
                        {
                            Id = 13,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2899),
                            IsDeleted = false,
                            Name = "Orhan Pamuk",
                            Nationality = "Turkey"
                        },
                        new
                        {
                            Id = 14,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2902),
                            IsDeleted = false,
                            Name = "Elif Shafak",
                            Nationality = "Turkey"
                        },
                        new
                        {
                            Id = 15,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2905),
                            IsDeleted = false,
                            Name = "Amitav Ghosh",
                            Nationality = "India"
                        });
                });

            modelBuilder.Entity("Bookify.Entities.entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FirstModificationByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hall")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailableForRental")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModificationByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PublishedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("Title", "AuthorId")
                        .IsUnique();

                    b.ToTable("Books", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9808),
                            Description = "A sweeping saga of a family in Cairo during the early 20th century.",
                            Hall = "Main Hall",
                            ImageUrl = "https://example.com/cairo_trilogy.jpg",
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            Price = 150m,
                            PublishedOn = new DateTime(1956, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Publishing House",
                            Title = "The Cairo Trilogy",
                            Type = "Drama"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9822),
                            Description = "The first book in the Cairo Trilogy, focusing on family life in Cairo.",
                            Hall = "Main Hall",
                            ImageUrl = "https://example.com/palace_walk.jpg",
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            Price = 120m,
                            PublishedOn = new DateTime(1956, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Publishing House",
                            Title = "Palace Walk",
                            Type = "Drama"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9827),
                            Description = "A postcolonial narrative exploring identity and belonging.",
                            Hall = "Main Hall",
                            ImageUrl = "https://example.com/season_of_migration.jpg",
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            Price = 130m,
                            PublishedOn = new DateTime(1966, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Publishing House",
                            Title = "Season of Migration to the North",
                            Type = "Fiction"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 3,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9832),
                            Description = "A collection of poetic essays covering various aspects of life.",
                            Hall = "Poetry Section",
                            ImageUrl = "https://example.com/the_prophet.jpg",
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            Price = 90m,
                            PublishedOn = new DateTime(1923, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Publishing House",
                            Title = "The Prophet",
                            Type = "Poetry"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 4,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9836),
                            Description = "A historical novel set in Egypt and America, intertwining love stories.",
                            Hall = "Main Hall",
                            ImageUrl = "https://example.com/map_of_love.jpg",
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            Price = 140m,
                            PublishedOn = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Publishing House",
                            Title = "The Map of Love",
                            Type = "HistoricalFiction"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 5,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9842),
                            Description = "A novel set in a once-grand building in downtown Cairo.",
                            Hall = "Main Hall",
                            ImageUrl = "https://example.com/yacoubian_building.jpg",
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            Price = 110m,
                            PublishedOn = new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Publishing House",
                            Title = "The Yacoubian Building",
                            Type = "Fiction"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 6,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9869),
                            Description = "A poignant coming-of-age story set in Egypt.",
                            Hall = "Main Hall",
                            ImageUrl = "https://example.com/open_door.jpg",
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            Price = 100m,
                            PublishedOn = new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Publishing House",
                            Title = "The Open Door",
                            Type = "Fiction"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 7,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9875),
                            Description = "A novel that blends Eastern and Western philosophies.",
                            Hall = "Main Hall",
                            ImageUrl = "https://example.com/book_of_khalid.jpg",
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            Price = 85m,
                            PublishedOn = new DateTime(1911, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Publishing House",
                            Title = "The Book of Khalid",
                            Type = "Fiction"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 8,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9879),
                            Description = "An exploration of spirituality and identity.",
                            Hall = "Main Hall",
                            ImageUrl = "https://example.com/return_of_the_spirit.jpg",
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            Price = 125m,
                            PublishedOn = new DateTime(1933, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Publishing House",
                            Title = "The Return of the Spirit",
                            Type = "Fiction"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 9,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9884),
                            Description = "A novel set in the Ottoman Empire, blending art and politics.",
                            Hall = "Main Hall",
                            ImageUrl = "https://example.com/my_name_is_red.jpg",
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            Price = 135m,
                            PublishedOn = new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Publishing House",
                            Title = "My Name is Red",
                            Type = "Fiction"
                        });
                });

            modelBuilder.Entity("Bookify.Entities.entities.BookCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("BookCategories", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            BookId = 1
                        },
                        new
                        {
                            CategoryId = 1,
                            BookId = 2
                        },
                        new
                        {
                            CategoryId = 2,
                            BookId = 3
                        },
                        new
                        {
                            CategoryId = 3,
                            BookId = 4
                        },
                        new
                        {
                            CategoryId = 2,
                            BookId = 5
                        },
                        new
                        {
                            CategoryId = 2,
                            BookId = 6
                        },
                        new
                        {
                            CategoryId = 2,
                            BookId = 7
                        },
                        new
                        {
                            CategoryId = 2,
                            BookId = 8
                        },
                        new
                        {
                            CategoryId = 2,
                            BookId = 9
                        },
                        new
                        {
                            CategoryId = 2,
                            BookId = 10
                        });
                });

            modelBuilder.Entity("Bookify.Entities.entities.BookCopy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("EditionNumber")
                        .HasColumnType("int");

                    b.Property<int?>("FirstModificationByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAvailableForRental")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModificationByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SerialNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR Shared.SerialNumber");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("BookCopies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 7, 22, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2204),
                            EditionNumber = 1,
                            IsAvailableForRental = true,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 2,
                            BookId = 1,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 4, 13, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2212),
                            EditionNumber = 2,
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 3,
                            BookId = 2,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 9, 10, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2216),
                            EditionNumber = 1,
                            IsAvailableForRental = true,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 4,
                            BookId = 2,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 6, 2, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2219),
                            EditionNumber = 2,
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 5,
                            BookId = 3,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 10, 20, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2223),
                            EditionNumber = 1,
                            IsAvailableForRental = true,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 6,
                            BookId = 3,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 9, 30, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2229),
                            EditionNumber = 2,
                            IsAvailableForRental = true,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 7,
                            BookId = 4,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 8, 31, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2232),
                            EditionNumber = 1,
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 8,
                            BookId = 4,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 8, 1, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2235),
                            EditionNumber = 2,
                            IsAvailableForRental = true,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 9,
                            BookId = 5,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 10, 25, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2238),
                            EditionNumber = 1,
                            IsAvailableForRental = true,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 10,
                            BookId = 5,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 10, 5, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2242),
                            EditionNumber = 2,
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 11,
                            BookId = 6,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 9, 25, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2246),
                            EditionNumber = 1,
                            IsAvailableForRental = true,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 12,
                            BookId = 6,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 8, 16, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2249),
                            EditionNumber = 2,
                            IsAvailableForRental = true,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 13,
                            BookId = 7,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 7, 2, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2252),
                            EditionNumber = 1,
                            IsAvailableForRental = false,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 14,
                            BookId = 7,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 5, 3, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2256),
                            EditionNumber = 2,
                            IsAvailableForRental = true,
                            IsDeleted = false,
                            SerialNumber = 0
                        },
                        new
                        {
                            Id = 15,
                            BookId = 8,
                            CreatedByUserId = 0,
                            CreationTime = new DateTime(2024, 4, 13, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2259),
                            EditionNumber = 1,
                            IsAvailableForRental = true,
                            IsDeleted = false,
                            SerialNumber = 0
                        });
                });

            modelBuilder.Entity("Bookify.Entities.entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FirstModificationByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModificationByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(4267),
                            IsDeleted = false,
                            Name = "Fighting"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(4286),
                            IsDeleted = false,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 30, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(4288),
                            IsDeleted = false,
                            Name = "Fiction"
                        });
                });

            modelBuilder.Entity("Bookify.Entities.entities.Book", b =>
                {
                    b.HasOne("Bookify.Entities.entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Bookify.Entities.entities.BookCategory", b =>
                {
                    b.HasOne("Bookify.Entities.entities.Book", "Book")
                        .WithMany("Categories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookify.Entities.entities.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Bookify.Entities.entities.BookCopy", b =>
                {
                    b.HasOne("Bookify.Entities.entities.Book", "Book")
                        .WithMany("Copies")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Bookify.Entities.entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Bookify.Entities.entities.Book", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Copies");
                });

            modelBuilder.Entity("Bookify.Entities.entities.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
