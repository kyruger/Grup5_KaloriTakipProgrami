﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
<<<<<<<< HEAD:DAL/Migrations/20230511152436_init.cs
    public partial class init : Migration
========
    public partial class v1 : Migration
>>>>>>>> Baran_Brench:DAL/Migrations/20230511160101_v1.cs
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PortionGram = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    CalorieFor100Gram = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    ProteinRateFor100Gram = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    FatRateFor100Gram = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    CarbonhydrateAmountFor100Gram = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    ImageResource = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 120, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DailyGoalCalorie = table.Column<int>(type: "int", nullable: false),
                    GoalWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DayGoal = table.Column<int>(type: "int", maxLength: 90, nullable: false, defaultValue: 0),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConsumedFoods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    PortionCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PortionType = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumedFoods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ConsumedFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumedFoods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "ID", "CalorieFor100Gram", "CarbonhydrateAmountFor100Gram", "Category", "CreationTime", "FatRateFor100Gram", "ImageResource", "Name", "PortionGram", "ProteinRateFor100Gram" },
                values: new object[,]
                {
<<<<<<<< HEAD:DAL/Migrations/20230511152436_init.cs
                    { 1, 300.1546m, 69m, 12, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(3061), 14m, null, "Hamburger", 190m, 17m },
                    { 2, 186m, 30.51m, 12, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(3075), 4.33m, null, "Pizza", 38m, 5.84m },
                    { 3, 170m, 29.71m, 9, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(3080), 3.5m, null, "Mantı", 190m, 4.12m }
========
                    { 1, 300.1546m, 69m, 12, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(5016), 14m, null, "Hamburger", 190m, 17m },
                    { 2, 186m, 30.51m, 12, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(5034), 4.33m, null, "Pizza", 38m, 5.84m },
                    { 3, 170m, 29.71m, 9, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(5042), 3.5m, null, "Mantı", 190m, 4.12m }
>>>>>>>> Baran_Brench:DAL/Migrations/20230511160101_v1.cs
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Age", "CreationTime", "DailyGoalCalorie", "FirstName", "Gender", "GoalWeight", "Height", "LastName", "Mail", "Password", "PhoneNumber", "Weight" },
<<<<<<<< HEAD:DAL/Migrations/20230511152436_init.cs
                values: new object[] { 1, 27, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(6125), 3000, "Enes", 1, 72m, 170m, "Kurt", "eneskurt@bilgeadam.com", "12345", "5434168", 66.5m });
========
                values: new object[] { 1, 27, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(7739), 3000, "Enes", 1, 72m, 170m, "Kurt", "eneskurt@bilgeadam.com", "12345", "5434168", 66.5m });
>>>>>>>> Baran_Brench:DAL/Migrations/20230511160101_v1.cs

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Age", "CreationTime", "DailyGoalCalorie", "DayGoal", "FirstName", "Gender", "GoalWeight", "Height", "LastName", "Mail", "Password", "PhoneNumber", "Weight" },
<<<<<<<< HEAD:DAL/Migrations/20230511152436_init.cs
                values: new object[] { 2, 24, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(6138), 3500, 30, "Baran", 1, 80m, 185m, "Oğuz", "baranoguz@bilgeadam.com", "12345", "11111", 73m });
========
                values: new object[] { 2, 24, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(7753), 3500, 30, "Baran", 1, 80m, 185m, "Oğuz", "baranoguz@bilgeadam.com", "12345", "11111", 73m });
>>>>>>>> Baran_Brench:DAL/Migrations/20230511160101_v1.cs

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
<<<<<<<< HEAD:DAL/Migrations/20230511152436_init.cs
                    { 1, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2174), 1, 1, 3, null, 1 },
                    { 2, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2185), 1, 2, 3, null, 1 },
                    { 3, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2187), 1, 3, 2, null, 1 },
                    { 4, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2188), 2, 1, 2, null, 1 },
                    { 5, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2189), 2, 2, 2, null, 1 },
                    { 6, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2190), 2, 2, 3, null, 1 },
                    { 7, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2191), 3, 1, 1, null, 1 },
                    { 8, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2192), 3, 1, 1, null, 1 },
                    { 9, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2193), 5, 3, 3, null, 1 }
========
                    { 1, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4151), 1, 1, 3, null, 1 },
                    { 2, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4176), 1, 2, 3, null, 1 },
                    { 3, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4177), 1, 3, 2, null, 1 },
                    { 4, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4178), 2, 1, 2, null, 1 },
                    { 5, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4183), 2, 2, 2, null, 1 },
                    { 6, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4184), 2, 2, 3, null, 1 },
                    { 7, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4186), 3, 1, 1, null, 1 },
                    { 8, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4187), 3, 1, 1, null, 1 },
                    { 9, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4189), 5, 3, 3, null, 1 }
>>>>>>>> Baran_Brench:DAL/Migrations/20230511160101_v1.cs
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "Quantity", "UserId" },
<<<<<<<< HEAD:DAL/Migrations/20230511152436_init.cs
                values: new object[] { 10, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2194), 1, 3, 1, null, 2, 2 });
========
                values: new object[] { 10, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4190), 1, 3, 1, null, 2, 2 });
>>>>>>>> Baran_Brench:DAL/Migrations/20230511160101_v1.cs

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
<<<<<<<< HEAD:DAL/Migrations/20230511152436_init.cs
                values: new object[] { 11, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2195), 2, 2, 2, null, 2 });
========
                values: new object[] { 11, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4191), 2, 2, 2, null, 2 });
>>>>>>>> Baran_Brench:DAL/Migrations/20230511160101_v1.cs

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
<<<<<<<< HEAD:DAL/Migrations/20230511152436_init.cs
                values: new object[] { 12, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2196), 1, 3, 1, 1, 2, 2 });
========
                values: new object[] { 12, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4193), 1, 3, 1, 1, 2, 2 });
>>>>>>>> Baran_Brench:DAL/Migrations/20230511160101_v1.cs

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "Quantity", "UserId" },
<<<<<<<< HEAD:DAL/Migrations/20230511152436_init.cs
                values: new object[] { 13, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2198), 2, 1, 1, null, 1, 2 });
========
                values: new object[] { 13, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4195), 2, 1, 1, null, 1, 2 });
>>>>>>>> Baran_Brench:DAL/Migrations/20230511160101_v1.cs

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
<<<<<<<< HEAD:DAL/Migrations/20230511152436_init.cs
                    { 14, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2199), 4, 3, 2, null, 2 },
                    { 15, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2199), 4, 2, 2, null, 2 },
                    { 16, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2200), 4, 1, 1, null, 2 },
                    { 17, new DateTime(2023, 5, 11, 18, 24, 36, 2, DateTimeKind.Local).AddTicks(2201), 5, 1, 1, null, 2 }
========
                    { 14, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4196), 4, 3, 2, null, 2 },
                    { 15, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4198), 4, 2, 2, null, 2 },
                    { 16, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4199), 4, 1, 1, null, 2 },
                    { 17, new DateTime(2023, 5, 11, 19, 1, 0, 816, DateTimeKind.Local).AddTicks(4200), 5, 1, 1, null, 2 }
>>>>>>>> Baran_Brench:DAL/Migrations/20230511160101_v1.cs
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsumedFoods_FoodId",
                table: "ConsumedFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumedFoods_UserId",
                table: "ConsumedFoods",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumedFoods");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
