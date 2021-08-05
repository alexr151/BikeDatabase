﻿// <auto-generated />
using System;
using BikeDatabase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BikeDatabase.Migrations
{
    [DbContext(typeof(BikeContext))]
    partial class BikeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BikeDatabase.Models.Bike", b =>
                {
                    b.Property<int>("BikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BikeColorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BikeSizeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BikeTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GearNumberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TireSizeId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BikeId");

                    b.HasIndex("BikeColorId");

                    b.HasIndex("BikeSizeId");

                    b.HasIndex("BikeTypeId");

                    b.HasIndex("GearNumberId");

                    b.HasIndex("TireSizeId");

                    b.ToTable("Bikes");

                    b.HasData(
                        new
                        {
                            BikeId = 1,
                            BikeColorId = "blue",
                            BikeSizeId = "58",
                            BikeTypeId = "rd",
                            GearNumberId = "2x7",
                            Make = "Masi",
                            Model = "Inizio",
                            TireSizeId = "12x2"
                        },
                        new
                        {
                            BikeId = 2,
                            BikeColorId = "grn",
                            BikeSizeId = "60",
                            BikeTypeId = "com",
                            GearNumberId = "2x11",
                            Make = "Trek",
                            Model = "520",
                            TireSizeId = "12x2"
                        },
                        new
                        {
                            BikeId = 3,
                            BikeColorId = "red",
                            BikeSizeId = "56",
                            BikeTypeId = "hyb",
                            GearNumberId = "3x8",
                            Make = "Giant",
                            Model = "Escape 3",
                            TireSizeId = "12x2"
                        },
                        new
                        {
                            BikeId = 4,
                            BikeColorId = "gld",
                            BikeSizeId = "16",
                            BikeTypeId = "cru",
                            GearNumberId = "1x3",
                            Make = "Townie",
                            Model = "Cruiser 2",
                            TireSizeId = "12x2"
                        });
                });

            modelBuilder.Entity("BikeDatabase.Models.BikeColor", b =>
                {
                    b.Property<string>("BikeColorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BikeColorId");

                    b.ToTable("BikeColors");

                    b.HasData(
                        new
                        {
                            BikeColorId = "red",
                            Color = "Red"
                        },
                        new
                        {
                            BikeColorId = "blue",
                            Color = "Blue"
                        },
                        new
                        {
                            BikeColorId = "grn",
                            Color = "Green"
                        },
                        new
                        {
                            BikeColorId = "purp",
                            Color = "Purple"
                        },
                        new
                        {
                            BikeColorId = "pnk",
                            Color = "Pink"
                        },
                        new
                        {
                            BikeColorId = "ylw",
                            Color = "Yellow"
                        },
                        new
                        {
                            BikeColorId = "wht",
                            Color = "White"
                        },
                        new
                        {
                            BikeColorId = "blk",
                            Color = "Black"
                        },
                        new
                        {
                            BikeColorId = "gld",
                            Color = "Gold"
                        },
                        new
                        {
                            BikeColorId = "slv",
                            Color = "Silver"
                        },
                        new
                        {
                            BikeColorId = "brz",
                            Color = "Bronze"
                        },
                        new
                        {
                            BikeColorId = "org",
                            Color = "Orange"
                        });
                });

            modelBuilder.Entity("BikeDatabase.Models.BikeSize", b =>
                {
                    b.Property<string>("BikeSizeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BikeSizeId");

                    b.ToTable("BikeSizes");

                    b.HasData(
                        new
                        {
                            BikeSizeId = "47",
                            Size = "47cm"
                        },
                        new
                        {
                            BikeSizeId = "48",
                            Size = "48cm"
                        },
                        new
                        {
                            BikeSizeId = "49",
                            Size = "49cm"
                        },
                        new
                        {
                            BikeSizeId = "50",
                            Size = "50cm"
                        },
                        new
                        {
                            BikeSizeId = "51",
                            Size = "51cm"
                        },
                        new
                        {
                            BikeSizeId = "52",
                            Size = "52cm"
                        },
                        new
                        {
                            BikeSizeId = "53",
                            Size = "53cm"
                        },
                        new
                        {
                            BikeSizeId = "54",
                            Size = "54cm"
                        },
                        new
                        {
                            BikeSizeId = "55",
                            Size = "55cm"
                        },
                        new
                        {
                            BikeSizeId = "56",
                            Size = "56cm"
                        },
                        new
                        {
                            BikeSizeId = "57",
                            Size = "57cm"
                        },
                        new
                        {
                            BikeSizeId = "58",
                            Size = "58cm"
                        },
                        new
                        {
                            BikeSizeId = "59",
                            Size = "59cm"
                        },
                        new
                        {
                            BikeSizeId = "60",
                            Size = "60cm"
                        },
                        new
                        {
                            BikeSizeId = "61",
                            Size = "61cm"
                        },
                        new
                        {
                            BikeSizeId = "62",
                            Size = "62cm"
                        },
                        new
                        {
                            BikeSizeId = "63",
                            Size = "63cm"
                        },
                        new
                        {
                            BikeSizeId = "13",
                            Size = "13in"
                        },
                        new
                        {
                            BikeSizeId = "14",
                            Size = "14in"
                        },
                        new
                        {
                            BikeSizeId = "15",
                            Size = "15in"
                        },
                        new
                        {
                            BikeSizeId = "16",
                            Size = "16in"
                        },
                        new
                        {
                            BikeSizeId = "17",
                            Size = "17in"
                        },
                        new
                        {
                            BikeSizeId = "18",
                            Size = "18in"
                        },
                        new
                        {
                            BikeSizeId = "19",
                            Size = "19in"
                        },
                        new
                        {
                            BikeSizeId = "20",
                            Size = "20in"
                        },
                        new
                        {
                            BikeSizeId = "21",
                            Size = "21in"
                        },
                        new
                        {
                            BikeSizeId = "22",
                            Size = "22in"
                        },
                        new
                        {
                            BikeSizeId = "23",
                            Size = "23in"
                        },
                        new
                        {
                            BikeSizeId = "24",
                            Size = "24in"
                        });
                });

            modelBuilder.Entity("BikeDatabase.Models.BikeType", b =>
                {
                    b.Property<string>("BikeTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BikeTypeId");

                    b.ToTable("BikeTypes");

                    b.HasData(
                        new
                        {
                            BikeTypeId = "rd",
                            Type = "Road"
                        },
                        new
                        {
                            BikeTypeId = "mtn",
                            Type = "Mountain"
                        },
                        new
                        {
                            BikeTypeId = "cc",
                            Type = "CycloCross"
                        },
                        new
                        {
                            BikeTypeId = "com",
                            Type = "Commuter"
                        },
                        new
                        {
                            BikeTypeId = "cmf",
                            Type = "Comfort"
                        },
                        new
                        {
                            BikeTypeId = "cru",
                            Type = "Cruiser"
                        },
                        new
                        {
                            BikeTypeId = "fit",
                            Type = "Fitness"
                        },
                        new
                        {
                            BikeTypeId = "hyb",
                            Type = "Hybrid"
                        },
                        new
                        {
                            BikeTypeId = "kid",
                            Type = "Children's"
                        },
                        new
                        {
                            BikeTypeId = "bmx",
                            Type = "BMX"
                        },
                        new
                        {
                            BikeTypeId = "elc",
                            Type = "Electric"
                        },
                        new
                        {
                            BikeTypeId = "rec",
                            Type = "Recumbant"
                        });
                });

            modelBuilder.Entity("BikeDatabase.Models.GearNumber", b =>
                {
                    b.Property<string>("GearNumberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Gear")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GearNumberId");

                    b.ToTable("GearNumbers");

                    b.HasData(
                        new
                        {
                            GearNumberId = "1x1",
                            Gear = "Single Speed"
                        },
                        new
                        {
                            GearNumberId = "1x3",
                            Gear = "1x3"
                        },
                        new
                        {
                            GearNumberId = "1x4",
                            Gear = "1x4"
                        },
                        new
                        {
                            GearNumberId = "1x6",
                            Gear = "1x6"
                        },
                        new
                        {
                            GearNumberId = "1x7",
                            Gear = "1x7"
                        },
                        new
                        {
                            GearNumberId = "1x8",
                            Gear = "1x8"
                        },
                        new
                        {
                            GearNumberId = "1x9",
                            Gear = "1x9"
                        },
                        new
                        {
                            GearNumberId = "1x10",
                            Gear = "1x10"
                        },
                        new
                        {
                            GearNumberId = "1x11",
                            Gear = "1x11"
                        },
                        new
                        {
                            GearNumberId = "1x12",
                            Gear = "1x12"
                        },
                        new
                        {
                            GearNumberId = "2x6",
                            Gear = "2 X 6"
                        },
                        new
                        {
                            GearNumberId = "2x7",
                            Gear = "2 X 7"
                        },
                        new
                        {
                            GearNumberId = "2x8",
                            Gear = "2 X 8"
                        },
                        new
                        {
                            GearNumberId = "2x9",
                            Gear = "2 X 9"
                        },
                        new
                        {
                            GearNumberId = "2x10",
                            Gear = "2 X 10"
                        },
                        new
                        {
                            GearNumberId = "2x11",
                            Gear = "2 X 11"
                        },
                        new
                        {
                            GearNumberId = "2x12",
                            Gear = "2 X 12"
                        },
                        new
                        {
                            GearNumberId = "3x6",
                            Gear = "3 X 6"
                        },
                        new
                        {
                            GearNumberId = "3x7",
                            Gear = "3 X 7"
                        },
                        new
                        {
                            GearNumberId = "3x8",
                            Gear = "3 X 8"
                        },
                        new
                        {
                            GearNumberId = "3x9",
                            Gear = "3 X 9"
                        },
                        new
                        {
                            GearNumberId = "3x10",
                            Gear = "3 X 10"
                        },
                        new
                        {
                            GearNumberId = "3x11",
                            Gear = "3 X 11"
                        },
                        new
                        {
                            GearNumberId = "3x12",
                            Gear = "3 X 12"
                        });
                });

            modelBuilder.Entity("BikeDatabase.Models.TireSize", b =>
                {
                    b.Property<string>("TireSizeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Tire")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TireSizeId");

                    b.ToTable("TireSizes");

                    b.HasData(
                        new
                        {
                            TireSizeId = "12x1.75",
                            Tire = "12 x 1.75"
                        },
                        new
                        {
                            TireSizeId = "12x1.9",
                            Tire = "12 x 1.90"
                        },
                        new
                        {
                            TireSizeId = "12.5x1.75",
                            Tire = "12 1/2 x 1.75"
                        },
                        new
                        {
                            TireSizeId = "12.5x1.9",
                            Tire = "12 1/2 x 1.90"
                        },
                        new
                        {
                            TireSizeId = "12x2",
                            Tire = "12 x 2.00"
                        },
                        new
                        {
                            TireSizeId = "12x1.95",
                            Tire = "12 x 1.95"
                        },
                        new
                        {
                            TireSizeId = "12.5x2.25",
                            Tire = "12 1/2 x 2 1/4"
                        });
                });

            modelBuilder.Entity("BikeDatabase.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            DOB = new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alex@ryberg.com",
                            FirstName = "Alex",
                            LastName = "Ryberg"
                        },
                        new
                        {
                            UserId = 2,
                            DOB = new DateTime(1997, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ashley@green.com",
                            FirstName = "Ashley",
                            LastName = "Green"
                        },
                        new
                        {
                            UserId = 3,
                            DOB = new DateTime(2016, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "olive@green.com",
                            FirstName = "Olive",
                            LastName = "Green"
                        },
                        new
                        {
                            UserId = 4,
                            DOB = new DateTime(1997, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nick@gunther.com",
                            FirstName = "Nick",
                            LastName = "Gunther"
                        });
                });

            modelBuilder.Entity("BikeDatabase.Models.Bike", b =>
                {
                    b.HasOne("BikeDatabase.Models.BikeColor", "BikeColor")
                        .WithMany()
                        .HasForeignKey("BikeColorId");

                    b.HasOne("BikeDatabase.Models.BikeSize", "BikeSize")
                        .WithMany()
                        .HasForeignKey("BikeSizeId");

                    b.HasOne("BikeDatabase.Models.BikeType", "BikeType")
                        .WithMany()
                        .HasForeignKey("BikeTypeId");

                    b.HasOne("BikeDatabase.Models.GearNumber", "GearNumber")
                        .WithMany()
                        .HasForeignKey("GearNumberId");

                    b.HasOne("BikeDatabase.Models.TireSize", "TireSize")
                        .WithMany()
                        .HasForeignKey("TireSizeId");

                    b.Navigation("BikeColor");

                    b.Navigation("BikeSize");

                    b.Navigation("BikeType");

                    b.Navigation("GearNumber");

                    b.Navigation("TireSize");
                });
#pragma warning restore 612, 618
        }
    }
}
