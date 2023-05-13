using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2630), 28, 15, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2642), 13, 11, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2643), 34, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2644), 19, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2645), 45, 16, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2648), 8, 19, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2648), 31, 21, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2649), 44, 19, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2650), 16, 21, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2652), 36, 21, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2653), 5, 10, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2654), 30, 23, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2655), 26, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2655), 11, 10, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2656), 39, 14, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2657), 19, 18, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2658), 40, 10, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2660), 13, 23, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2661), 25, 13, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2662), 21, 1, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2663), 15, 28, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2664), 25, 8 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2664), 24, 23, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2665), 39, 5, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2666), 40, 23, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2667), 28, 8, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2668), 29, 28, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2669), 5, 26, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2670), 40, 28, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2671), 4, 1, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2672), 29, 13, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2673), 8, 16, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2674), 18, 26, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2676), 42, 19, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2677), 5, 9, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2678), 30, 6, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2679), 31, 21, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2679), 10, 6, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2680), 6, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2681), 7, 17, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2682), 21, 8, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2683), 26, 23, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2684), 5, 15, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2685), 28, 10, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2686), 41, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2687), 22, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2688), 18, 26, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2689), 16, 25, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2690), 7, 1, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2691), 45, 17, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2692), 26, 17, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2693), 42, 6, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2693), 22, 12, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2695), 18, 20, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2695), 40, 13, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2696), 31, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2697), 19, 11, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2699), 39, 20 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2703), 21, 7 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2704), 19, 24, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2705), 26, 12, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2706), 40, 10, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2707), 43, 20, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2708), 5, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2709), 32, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2710), 24, 24, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2711), 30, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2712), 5, 14, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2713), 25, 13, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2714), 4, 28, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2715), 7, 18, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2716), 35, 27, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2717), 17, 10, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2718), 21, 7, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2719), 30, 21, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2720), 19, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2720), 44, 23, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2721), 24, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2722), 20, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2723), 16, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2724), 23, 18, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2725), 34, 11, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2725), 44, 20 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2726), 43, 16, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2727), 9, 11, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2728), 21, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2729), 45, 20, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2730), 2, 28, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2731), 34, 16, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2731), 27, 21, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2732), 22, 6, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2733), 19, 27, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2734), 32, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2735), 34, 13, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2736), 32, 20, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2736), 34, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2738), 23, 7, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2738), 30, 24, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2739), 30, 6, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2740), 11, 27, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2741), 32, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2742), 25, 19, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2743), 11, 21, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2744), 16, 23, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2745), 28, 8, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2745), 36, 24, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2746), 3, 5, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2747), 11, 28, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2748), 34, 14, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2749), 12, 13, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2750), 2, 23, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2751), 25, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "CreationTime", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2752), 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2753), 28, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2753), 29, 25, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2754), 39, 12, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2755), 3, 18, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2756), 40, 7, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "CreationTime", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2757), 16, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2758), 16, 24, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2759), 17, 10, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2760), 22, 16, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2761), 14, 15 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2761), 7, 16, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2762), 30, 5, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2763), 18, 11, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "CreationTime", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2764), 17, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2764), 19, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2765), 16, 25, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2770), 7, 23, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2771), 37, 10, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2772), 13, 18, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2773), 23, 22, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2774), 17, 7, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2774), 36, 8, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2775), 37, 25, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2776), 26, 6, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2777), 17, 12, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2778), 35, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2779), 8, 18, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2780), 34, 24, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2781), 24, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2781), 7, 23, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2782), 31, 12, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2783), 31, 23, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2784), 25, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2785), 5, 8, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2786), 3, 10, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2787), 31, 8, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2788), 41, 5, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2789), 17, 17, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2790), 2, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2791), 44, 24, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2792), 3, 14, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2793), 17, 20, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2793), 16, 28, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2794), 23, 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2795), 42, 13, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2796), 18, 17, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2797), 34, 13, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2798), 11, 23, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2799), 32, 27, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2800), 41, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2801), 22, 25, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2802), 13, 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2803), 11, 1, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2804), 45, 26, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2805), 13, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2805), 42, 15 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2806), 38, 19, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2807), 45, 28, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2808), 18, 12, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2809), 25, 22, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2810), 22, 7, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2811), 10, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2812), 10, 21, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2813), 13, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2814), 15, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2815), 38, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2816), 21, 24, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2816), 10, 8, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2817), 6, 22, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2818), 6, 19, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2819), 26, 23, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2820), 27, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2820), 17, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2821), 26, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2822), 12, 11, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2823), 30, 21, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2824), 7, 27, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2825), 28, 7, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2826), 16, 12, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2827), 12, 7, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2827), 4, 7, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2828), 35, 23, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2829), 14, 9, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2831), 13, 20, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2831), 32, 11, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2832), 20, 28, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2833), 3, 28, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2834), 31, 20, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2835), 18, 22, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2836), 12, 14, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2837), 29, 21, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2838), 37, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2839), 40, 14, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2840), 41, 10 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2841), 42, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2842), 11, 11, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2843), 17, 23, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2844), 35, 19, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2845), 45, 15, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2846), 13, 27, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2847), 5, 15, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2848), 5, 26, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2848), 23, 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2849), 21, 19, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2850), 8, 17, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2851), 43, 19, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2852), 35, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2853), 6, 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2854), 41, 20, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2855), 20, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2859), 20, 22, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2860), 7, 12, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2861), 19, 6, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2862), 18, 6, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2863), 35, 24, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2864), 27, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2865), 2, 22, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2866), 19, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2867), 1, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2868), 10, 25, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2869), 21, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2869), 44, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2870), 3, 23, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2871), 18, 13, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2872), 29, 10, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2873), 16, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2874), 19, 1, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2875), 16, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2875), 17, 10, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2876), 19, 3, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2877), 32, 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2878), 10, 20, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2879), 20, 10, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2880), 31, 19, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2881), 32, 23, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2882), 21, 18, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2882), 37, 15, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2883), 36, 16, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2884), 16, 28, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2885), 29, 6, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2886), 38, 18, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2887), 1, 14, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2888), 32, 11, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2889), 14, 24, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2891), 38, 26, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2892), 2, 25, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2893), 29, 27, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2893), 42, 23, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2894), 14, 28, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2895), 17, 21, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2896), 35, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2897), 32, 13, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2898), 1, 6, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2899), 35, 21, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2899), 33, 23, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2901), 34, 9, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2901), 3, 12, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2902), 17, 28, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2904), 30, 14, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2905), 22, 27, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2906), 25, 21, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2910), 29, 9, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2912), 6, 17, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2912), 35, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2914), 30, 24, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2915), 38, 15, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2915), 34, 11, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2916), 12, 17, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2917), 15, 27 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2918), 34, 25, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2919), 39, 16, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2920), 19, 9, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2921), 28, 21, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2922), 27, 8 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2923), 4, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2923), 27, 25 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2924), 25, 11, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2925), 26, 25, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2926), 24, 7, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2927), 12, 7, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2928), 45, 26, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2929), 10, 12, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2929), 11, 12, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2930), 5, 17, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2931), 21, 13, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2932), 43, 11, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2933), 16, 17, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2934), 36, 26, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreationTime", "Day" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2935), 43 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2936), 2, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2937), 27, 12, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2938), 30, 27, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2939), 25, 7, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2940), 39, 11 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2941), 23, 16, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2941), 13, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2942), 6, 26, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2943), 6, 25, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2944), 30, 1, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2945), 11, 10, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2945), 25, 13, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2946), 10, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2947), 41, 20, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2948), 39, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2949), 27, 4, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2950), 3, 7, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2951), 35, 20, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2951), 39, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2952), 23, 18, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2953), 12, 15, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2954), 32, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2955), 21, 17, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2956), 45, 10, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2957), 42, 15, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2958), 1, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2958), 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2959), 30, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2961), 32, 7, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2961), 12, 8, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2962), 22, 9 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2963), 19, 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2964), 18, 8, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2965), 42, 4, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2965), 14, 16, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2966), 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2967), 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2968), 37, 25, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2969), 35, 22, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2970), 25, 7, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2971), 10, 8, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2972), 2, 28, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2972), 10, 12, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2973), 20, 23, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2974), 14, 10, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2975), 23, 24, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2976), 37, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2977), 15, 15, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2978), 24, 21, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2978), 41, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2979), 17, 20, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2980), 40, 11, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2981), 42, 5, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2982), 43, 18, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2983), 34, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2984), 23, 3, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2985), 11, 12, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2986), 32, 22, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2987), 7, 14, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2988), 2, 20, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2989), 32, 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "CreationTime", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2990), 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2990), 11, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2991), 33, 25, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2992), 36, 9, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2993), 6, 16, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2994), 9, 23, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2995), 28, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2996), 8, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2996), 34, 27, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2997), 45, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2998), 5, 10, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2999), 9, 17, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3000), 5, 18, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3004), 9, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3006), 5, 14, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3007), 15, 27, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3007), 14, 5, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3008), 32, 19, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3009), 44, 7, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3010), 25, 5, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3010), 12, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3011), 24, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3012), 43, 13, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3013), 1, 19, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3014), 41, 19, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3015), 25, 26, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3016), 39, 12, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3017), 18, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3018), 33, 12, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3018), 2, 13, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3019), 30, 12, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3020), 19, 6, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3021), 45, 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3022), 21, 16, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3023), 11, 23, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3024), 22, 17, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3025), 43, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3026), 16, 25, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3027), 36, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3028), 6, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3029), 39, 25, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3030), 26, 23, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3031), 25, 11, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3031), 5, 20, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3032), 14, 7, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3033), 6, 16, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3034), 5, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3035), 7, 17, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3036), 11, 6, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3037), 42, 10, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3037), 13, 27, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3038), 6, 22, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3039), 42, 12 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3040), 18, 28, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3041), 18, 24, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3042), 13, 13, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3043), 45, 28, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3044), 19, 17 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3045), 7, 27, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3046), 3, 16, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3047), 3, 26, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3047), 36, 18, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3048), 2, 9, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3049), 30, 14, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3050), 42, 21, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3051), 26, 4, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3052), 22, 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3053), 36, 24, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3053), 43, 9, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3054), 19, 25, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3055), 37, 10, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3056), 21, 21, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3057), 2, 22, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3057), 31, 10, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3058), 31, 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3059), 15, 17, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3060), 36, 9, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3061), 40, 12, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3062), 15, 5, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3062), 41, 25, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3063), 12, 22, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3064), 39, 13, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3065), 30, 25, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3066), 9, 8, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3067), 32, 12, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3068), 10, 15 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3069), 17, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3069), 26, 17 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3070), 24, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3071), 13, 21, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3072), 17, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3073), 30, 23, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3073), 10, 7, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3074), 45, 14, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3075), 37, 16, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3076), 30, 21, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3077), 24, 9, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3078), 6, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3079), 28, 25, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3079), 33, 11, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3080), 15, 3, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3081), 42, 7, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3082), 22, 16, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3083), 24, 19, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3084), 32, 10, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3084), 26, 10, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3085), 36, 12, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3086), 44, 10, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3087), 39, 12, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3088), 12, 26, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3088), 29, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3089), 42, 15, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3090), 22, 15, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3091), 40, 16, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3092), 29, 24, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3095), 22, 24, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3097), 9, 14, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3098), 6, 12, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3099), 39, 21, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3099), 2, 12, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3100), 19, 28, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3101), 29, 27, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3102), 37, 9, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3103), 18, 28, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3103), 29, 8, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3104), 26, 6, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3105), 36, 27, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3106), 44, 22, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3107), 21, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3108), 24, 7, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3109), 26, 17, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3110), 23, 15, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3111), 12, 3, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3111), 31, 27, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3112), 20, 7, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3113), 15, 7, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3114), 4, 15, 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(6298));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6574), 29, 19, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6590), 42, 15, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6591), 1, 9, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6592), 32, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6593), 19, 23, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6595), 33, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6597), 32, 15, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6597), 19, 18, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6598), 18, 9, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6600), 15, 17, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6601), 42, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6602), 34, 19, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6603), 35, 14, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6604), 22, 17, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6605), 30, 10, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6606), 11, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6607), 24, 6, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6609), 35, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6610), 29, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6611), 44, 16, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6612), 42, 22, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6613), 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6614), 41, 26, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6615), 6, 19, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6616), 8, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6617), 33, 27, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6618), 25, 16, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6619), 34, 15, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6620), 29, 25, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6621), 11, 8, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6622), 22, 26, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6623), 45, 24, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6624), 39, 1, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6625), 4, 18, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6626), 2, 8, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6627), 13, 22, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6632), 33, 12, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6634), 13, 27, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6634), 21, 25, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6636), 39, 26, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6637), 13, 25, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6637), 5, 8, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6638), 10, 11, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6639), 3, 20, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6640), 25, 17, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6641), 26, 14, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6642), 24, 8, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6643), 35, 15, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6644), 1, 21, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6644), 7, 19, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6645), 30, 23, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6646), 12, 25, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6647), 44, 16, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6648), 21, 11, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6649), 13, 25, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6649), 34, 19, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6651), 25, 6, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6651), 25, 16 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6652), 7, 14 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6653), 29, 9, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6654), 13, 27, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6655), 30, 20, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6656), 17, 8, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6657), 43, 7, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6658), 12, 25 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6660), 8, 26, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6661), 3, 7, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6662), 16, 23, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6663), 9, 14, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6664), 7, 8, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6665), 44, 12, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6666), 27, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6667), 34, 19, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6667), 15, 20, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6668), 5, 7, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6670), 20, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6671), 35, 27, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6672), 21, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6673), 38, 23, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6674), 8, 6, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6675), 24, 11, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6675), 29, 21, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6676), 14, 6 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6677), 37, 25, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6678), 8, 22, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6679), 6, 10, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6680), 10, 14, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6681), 17, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6682), 44, 15, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6682), 15, 12, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6683), 1, 19, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6684), 17, 1, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6685), 23, 17, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6686), 3, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6687), 37, 21, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6688), 26, 16, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6689), 34, 1, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6690), 28, 18, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6690), 23, 23, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6691), 8, 15, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6692), 6, 11, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6693), 21, 4, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6694), 21, 20, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6695), 11, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6696), 20, 27, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6696), 30, 14, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6697), 20, 3, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6698), 22, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6699), 25, 5, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6700), 25, 12, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6701), 44, 13, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6702), 20, 6, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "CreationTime", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6702), 28 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6703), 38, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6704), 19, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6705), 18, 11, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6706), 40, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6707), 7, 15, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "CreationTime", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6708), 28, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6709), 4, 26, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6710), 16, 26, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6711), 27, 9, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6711), 15, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6712), 11, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6713), 8, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6717), 26, 6, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "CreationTime", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6719), 15, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6720), 41, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6721), 34, 8, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6723), 9, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6724), 11, 14, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6725), 42, 25, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6726), 26, 12, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6726), 20, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6727), 35, 10, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6728), 16, 14, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6729), 20, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6730), 25, 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6731), 32, 13, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6732), 29, 20, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6733), 21, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6734), 20, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6734), 9, 19, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6735), 11, 11, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6736), 10, 20, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6737), 23, 25, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6738), 29, 7, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6739), 11, 28, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6740), 5, 17, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6741), 16, 12, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6742), 4, 7, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6743), 17, 23, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6744), 20, 17, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6745), 24, 3, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6745), 41, 19, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6746), 32, 17, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6747), 12, 25, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6748), 22, 25, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6749), 6, 25, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6750), 14, 1, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6751), 5, 19, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6752), 10, 23, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6753), 32, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6753), 5, 28, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6754), 16, 26, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6755), 32, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6756), 42, 20, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6757), 36, 21, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6758), 38, 26 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6759), 32, 18, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6760), 28, 13, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6760), 38, 10, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6761), 29, 15, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6762), 38, 28, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6763), 33, 20, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6764), 9, 26, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6764), 28, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6765), 38, 12, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6766), 33, 13, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6767), 13, 25, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6768), 23, 2, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6769), 44, 27, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6770), 43, 14, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6771), 29, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6772), 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6772), 36, 6, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6774), 1, 17, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6775), 39, 12, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6776), 39, 12, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6777), 41, 5, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6778), 3, 10, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6779), 29, 15, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6779), 26, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6780), 42, 20, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6781), 6, 28, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6782), 5, 10, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6783), 16, 15, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6784), 24, 24, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6785), 5, 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6786), 12, 12, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6787), 10, 8, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6791), 14, 20, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6792), 3, 17, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6793), 37, 6, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6794), 35, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6795), 20, 4, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6796), 26, 13 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6797), 8, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6798), 38, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6799), 38, 10, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6800), 23, 15, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6800), 5, 9, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6801), 41, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6802), 27, 23, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6803), 12, 19, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6804), 44, 24, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6804), 13, 24, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6805), 10, 26, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6806), 10, 27, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6807), 14, 17 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6808), 30, 22, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6809), 2, 24, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6810), 19, 24, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6811), 41, 28, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6812), 45, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6812), 33, 28, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6813), 2, 5, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6814), 29, 8, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6815), 18, 13, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6816), 39, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6817), 31, 15, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6818), 42, 7, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6818), 18, 17, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6819), 7, 17, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6820), 38, 12, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6821), 12, 8, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6822), 33, 28, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6822), 20, 23, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6823), 36, 6, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6824), 36, 17, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6825), 6, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6826), 3, 28, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6827), 35, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6828), 34, 7, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6829), 45, 25, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6830), 4, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6831), 19, 21, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6832), 38, 11, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6833), 40, 24, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6834), 42, 14, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6834), 19, 26, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6835), 31, 6, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6836), 40, 16, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6837), 1, 24, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6838), 27, 13, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6840), 43, 21, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6840), 6, 7, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6846), 20, 8, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6847), 36, 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6848), 40, 16, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6849), 21, 18, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6850), 20, 19, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6851), 44, 6, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6852), 12, 27, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6852), 19, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6853), 4, 19, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6854), 37, 24, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6855), 31, 21, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6856), 11, 18, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6857), 42, 9, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6858), 23, 21, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6859), 36, 27, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6860), 14, 3, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6861), 42, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6861), 9, 26, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6862), 17, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6863), 2, 18, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6864), 39, 16, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6865), 1, 5, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6866), 43, 18, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6867), 17, 21, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6867), 40, 8 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6868), 26, 20, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6869), 9, 5, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6870), 28, 20, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6871), 3, 11, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6872), 43, 14 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6872), 10, 10, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6873), 3, 20 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6874), 37, 26, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6875), 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6876), 27, 24, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6877), 6, 28, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6878), 22, 19, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6879), 17, 9, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6880), 3, 26, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6881), 36, 16, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6882), 29, 12, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6883), 34, 18, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6884), 17, 14, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6885), 35, 10, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreationTime", "Day" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6885), 17 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6887), 36, 12, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6887), 38, 18, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6888), 38, 14, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6889), 35, 16, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6890), 25, 25 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6891), 35, 6, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6892), 16, 9, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6893), 20, 25, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6894), 30, 18, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6895), 45, 28, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6896), 21, 12, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6897), 9, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6898), 40, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6899), 26, 21, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6899), 7, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6901), 30, 18, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6902), 21, 10, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6902), 32, 16, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6903), 14, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6904), 5, 26, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6905), 39, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6906), 1, 12, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6907), 26, 25, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6908), 33, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6908), 13, 12, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6909), 43, 12, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6910), 22, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6911), 32, 24, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6912), 2, 22, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6913), 17, 5, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6914), 27, 10 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6915), 6, 14, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6915), 20, 18, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6916), 39, 25, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6917), 20, 17, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6918), 14, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6919), 44, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6920), 11, 7, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6921), 24, 6, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6922), 6, 17, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6922), 25, 17, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6923), 26, 10, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6924), 38, 18, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6925), 25, 7, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6926), 21, 26, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6926), 42, 26, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6927), 2, 14, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6928), 22, 28, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6929), 40, 10, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6930), 29, 23, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6931), 37, 24, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6932), 30, 21, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6936), 18, 11, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6937), 29, 8, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6938), 11, 8, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6939), 27, 17, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6940), 44, 8, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6941), 31, 20, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6942), 9, 17, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6943), 9, 9, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6944), 11, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "CreationTime", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6945), 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6946), 16, 14, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6947), 8, 3, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6947), 14, 10, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6948), 25, 21, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6949), 40, 28, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6950), 35, 14, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6951), 24, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6952), 31, 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6953), 23, 13, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6954), 12, 19, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6955), 19, 22, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6956), 20, 2, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6957), 5, 20, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6958), 19, 21, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6958), 14, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6959), 16, 7, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6960), 6, 28, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6961), 22, 24, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6962), 32, 25, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6963), 33, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6964), 29, 5, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6964), 5, 17, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6965), 45, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6966), 2, 10, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6967), 23, 22, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6968), 35, 5, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6969), 17, 19, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6970), 17, 24, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6971), 3, 9, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6972), 8, 24, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6973), 30, 8, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6973), 14, 25, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6974), 3, 13, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6975), 34, 22, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6976), 35, 16, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6977), 24, 17 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6978), 36, 12, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6979), 21, 23 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6980), 21, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6981), 2, 22, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6982), 30, 9, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6983), 34, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6984), 23, 9, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6985), 25, 16, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6986), 30, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6987), 2, 12, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6988), 14, 28, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6989), 37, 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6990), 14, 15, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6991), 7, 25, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6992), 37, 14, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6993), 24, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6993), 28, 15, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6995), 35, 27, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6995), 18, 6, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6996), 26, 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6997), 29, 15 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6998), 39, 22, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6999), 32, 9, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6999), 21, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7000), 24, 8, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7001), 35, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7002), 14, 13, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7003), 4, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7004), 3, 25, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7005), 25, 13, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7006), 5, 9, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7006), 22, 22, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7007), 40, 20, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7008), 11, 22, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7009), 32, 10, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7010), 40, 15, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7011), 42, 20, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7012), 13, 8, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7013), 17, 11, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7013), 38, 25, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7014), 23, 13, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7015), 40, 18, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7016), 17, 8, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7017), 21, 18, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7018), 32, 25, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7019), 18, 28, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7020), 41, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7021), 9, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7022), 15, 12 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7023), 28, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7024), 21, 23 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7025), 37, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7025), 26, 25, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7026), 29, 28, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7027), 9, 8, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7028), 22, 25, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7032), 19, 6, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7033), 43, 11, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7034), 45, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7035), 10, 13, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7036), 14, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7037), 35, 11, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7038), 22, 6, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7038), 42, 27, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7039), 34, 9, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7040), 34, 24, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7041), 37, 27, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7042), 15, 25, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7043), 7, 27, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7044), 14, 21, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7045), 6, 7, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7046), 41, 8, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7047), 11, 10, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7048), 8, 11, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7049), 28, 26, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7050), 6, 14, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7050), 32, 23, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7051), 4, 10, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7052), 25, 6, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7053), 2, 13, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7054), 22, 13, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7055), 20, 25, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7056), 35, 23, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7056), 22, 6, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7057), 13, 19, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7058), 15, 16, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7059), 2, 15, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7060), 27, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7061), 15, 5, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7062), 40, 10, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7063), 25, 11, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7064), 32, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7065), 45, 21, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7066), 45, 25, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7067), 10, 26, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7068), 45, 19, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7069), 38, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7070), 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7071), 2, 16, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7072), 23, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 844, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 844, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 844, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 844, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 4, 52, 44, 844, DateTimeKind.Local).AddTicks(1133));
        }
    }
}
