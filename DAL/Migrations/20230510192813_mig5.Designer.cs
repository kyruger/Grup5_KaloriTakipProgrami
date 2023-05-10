﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(CalorieTrackingDbContext))]
    [Migration("20230510192813_mig5")]
    partial class mig5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.ConsumedFood", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("MealType")
                        .HasColumnType("int");

                    b.Property<int>("PortionCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int?>("PortionType")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FoodId");

                    b.HasIndex("UserId");

                    b.ToTable("ConsumedFoods");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6945),
                            Day = 1,
                            FoodId = 1,
                            MealType = 3,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 1
                        },
                        new
                        {
                            ID = 2,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6954),
                            Day = 1,
                            FoodId = 2,
                            MealType = 3,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 1
                        },
                        new
                        {
                            ID = 3,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6955),
                            Day = 1,
                            FoodId = 3,
                            MealType = 2,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 1
                        },
                        new
                        {
                            ID = 4,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6955),
                            Day = 2,
                            FoodId = 1,
                            MealType = 2,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 1
                        },
                        new
                        {
                            ID = 5,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6956),
                            Day = 2,
                            FoodId = 2,
                            MealType = 2,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 1
                        },
                        new
                        {
                            ID = 6,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6957),
                            Day = 2,
                            FoodId = 2,
                            MealType = 3,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 1
                        },
                        new
                        {
                            ID = 7,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6957),
                            Day = 3,
                            FoodId = 1,
                            MealType = 1,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 1
                        },
                        new
                        {
                            ID = 8,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6958),
                            Day = 3,
                            FoodId = 1,
                            MealType = 1,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 1
                        },
                        new
                        {
                            ID = 9,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6958),
                            Day = 5,
                            FoodId = 3,
                            MealType = 3,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 1
                        },
                        new
                        {
                            ID = 10,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6959),
                            Day = 1,
                            FoodId = 3,
                            MealType = 2,
                            PortionCount = 0,
                            Quantity = 2,
                            UserId = 2
                        },
                        new
                        {
                            ID = 11,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6960),
                            Day = 2,
                            FoodId = 2,
                            MealType = 2,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 2
                        },
                        new
                        {
                            ID = 12,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6961),
                            Day = 2,
                            FoodId = 3,
                            MealType = 1,
                            PortionCount = 1,
                            PortionType = 2,
                            Quantity = 0,
                            UserId = 2
                        },
                        new
                        {
                            ID = 13,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6962),
                            Day = 2,
                            FoodId = 1,
                            MealType = 3,
                            PortionCount = 0,
                            Quantity = 1,
                            UserId = 2
                        },
                        new
                        {
                            ID = 14,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6962),
                            Day = 4,
                            FoodId = 3,
                            MealType = 2,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 2
                        },
                        new
                        {
                            ID = 15,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6963),
                            Day = 4,
                            FoodId = 2,
                            MealType = 2,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 2
                        },
                        new
                        {
                            ID = 16,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6964),
                            Day = 4,
                            FoodId = 1,
                            MealType = 1,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 2
                        },
                        new
                        {
                            ID = 17,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6964),
                            Day = 5,
                            FoodId = 1,
                            MealType = 1,
                            PortionCount = 0,
                            Quantity = 0,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Entities.Food", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("CalorieFor100Gram")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("CarbonhydrateAmountFor100Gram")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FatRateFor100Gram")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<byte[]>("ImageResource")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("PortionGram")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProteinRateFor100Gram")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("ID");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CalorieFor100Gram = 300.1546m,
                            CarbonhydrateAmountFor100Gram = 69m,
                            Category = 12,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(7510),
                            FatRateFor100Gram = 14m,
                            Name = "Hamburger",
                            PortionGram = 190m,
                            ProteinRateFor100Gram = 17m
                        },
                        new
                        {
                            ID = 2,
                            CalorieFor100Gram = 186m,
                            CarbonhydrateAmountFor100Gram = 30.51m,
                            Category = 12,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(7518),
                            FatRateFor100Gram = 4.33m,
                            Name = "Pizza",
                            PortionGram = 38m,
                            ProteinRateFor100Gram = 5.84m
                        },
                        new
                        {
                            ID = 3,
                            CalorieFor100Gram = 170m,
                            CarbonhydrateAmountFor100Gram = 29.71m,
                            Category = 9,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(7522),
                            FatRateFor100Gram = 3.5m,
                            Name = "Mantı",
                            PortionGram = 190m,
                            ProteinRateFor100Gram = 4.12m
                        });
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasMaxLength(120)
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DailyGoalCalorie")
                        .HasColumnType("int");

                    b.Property<int>("DayGoal")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(90)
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<decimal>("GoalWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Age = 27,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(9084),
                            DailyGoalCalorie = 3000,
                            DayGoal = 0,
                            FirstName = "Enes",
                            Gender = 1,
                            GoalWeight = 72m,
                            Height = 170m,
                            LastName = "Kurt",
                            Mail = "eneskurt@bilgeadam.com",
                            Password = "12345",
                            PhoneNumber = "5434168",
                            Weight = 66.5m
                        },
                        new
                        {
                            ID = 2,
                            Age = 24,
                            CreationTime = new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(9092),
                            DailyGoalCalorie = 3500,
                            DayGoal = 30,
                            FirstName = "Baran",
                            Gender = 1,
                            GoalWeight = 80m,
                            Height = 185m,
                            LastName = "Oğuz",
                            Mail = "baranoguz@bilgeadam.com",
                            Password = "12345",
                            PhoneNumber = "11111",
                            Weight = 73m
                        });
                });

            modelBuilder.Entity("Entities.ConsumedFood", b =>
                {
                    b.HasOne("Entities.Food", "Food")
                        .WithMany("ConsumedFoods")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.User", "User")
                        .WithMany("ConsumedFoods")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Food", b =>
                {
                    b.Navigation("ConsumedFoods");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Navigation("ConsumedFoods");
                });
#pragma warning restore 612, 618
        }
    }
}
