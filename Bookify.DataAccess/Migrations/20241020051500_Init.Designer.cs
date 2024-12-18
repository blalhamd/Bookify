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
    [Migration("20241020051500_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 20, 8, 14, 59, 872, DateTimeKind.Local).AddTicks(1862),
                            IsDeleted = false,
                            Name = "Fighting"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 20, 8, 14, 59, 872, DateTimeKind.Local).AddTicks(1933),
                            IsDeleted = false,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByUserId = 1,
                            CreationTime = new DateTime(2024, 10, 20, 8, 14, 59, 872, DateTimeKind.Local).AddTicks(1937),
                            IsDeleted = false,
                            Name = "Fiction"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
