using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2731), 33, 27, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2742), 30, 19, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2744), 32, 9, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2745), 13, 8, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2746), 9, 15, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2748), 13, 8, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2750), 1, 18, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2751), 5, 26, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2752), 40, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2754), 42, 28, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2755), 13, 7, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2756), 12, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2757), 9, 7, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2758), 9, 2, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2759), 21, 16, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2761), 10, 24, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2761), 35, 26, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2763), 3, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2764), 26, 12, 4, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2765), 12, 25, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2766), 31, 20, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2767), 23, 25, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2768), 22, 11, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2770), 8, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2771), 20, 11, 5, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2772), 1, 13, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2773), 26, 17, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2774), 38, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2775), 8, 6, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2776), 40, 28, 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2777), 22, 14, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2778), 39, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2779), 29, 27, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2781), 7, 18, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2782), 37, 15, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2783), 22, 22, 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2784), 1, 23, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2785), 24, 16, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2786), 18, 26, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2787), 14, 7, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2788), 27, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2789), 7, 21, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2790), 4, 18, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2791), 34, 1, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2792), 10, 28, 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2793), 3, 4, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2794), 31, 12, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2795), 27, 6, 5, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2796), 45, 19, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2801), 16, 26, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2802), 5, 5, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2803), 20, 4, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2805), 6, 7, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2806), 16, 24, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2807), 19, 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2807), 1, 10, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2809), 4, 5, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2810), 32, 24, 5, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2811), 42, 20, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2811), 10, 13, 5, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2813), 12, 26, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2814), 41, 13, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2815), 37, 26, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2816), 32, 19, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2817), 28, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2819), 14, 17, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2820), 11, 20, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2821), 42, 2, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2822), 10, 3, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2824), 21, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2825), 41, 20, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2826), 25, 5, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2827), 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2828), 7, 5, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2829), 1, 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2831), 28, 19, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2832), 7, 5, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2832), 37, 25, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2833), 25, 24, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2834), 23, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2835), 43, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2836), 3, 7, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2838), 45, 8, 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2839), 41, 23, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2840), 15, 17, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2841), 12, 24, 5, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2842), 11, 18, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2843), 42, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2844), 10, 17, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "CreationTime", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2845), 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2846), 9, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2847), 13, 15, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2848), 33, 27, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2849), 18, 23, 3, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2850), 21, 2, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2850), 13, 28, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2851), 12, 27, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2853), 11, 28, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2853), 4, 12, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2854), 25, 25, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2855), 37, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2857), 24, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2858), 10, 25, 1, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2858), 9, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2859), 42, 26, 1, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2860), 9, 16, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2861), 27, 12, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2862), 34, 10, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2863), 37, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2864), 31, 23, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2865), 42, 11, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2866), 26, 22, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2867), 36, 15, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2868), 37, 9, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2869), 3, 8, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2870), 4, 24, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2871), 31, 3, 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2872), 42, 3, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2873), 4, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2874), 20, 26, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2875), 1, 21, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2876), 14, 20, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2877), 44, 10, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2878), 13, 8, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2879), 43, 2, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2880), 37, 6, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2881), 17, 16, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "CreationTime", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2882), 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2883), 34, 16, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2889), 34, 7, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2890), 30, 22, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2891), 32, 10, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2892), 37, 2, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2893), 40, 21, 5, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2893), 30, 23, 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2895), 28, 26, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2896), 33, 11, 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2897), 37, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2898), 27, 16, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2899), 1, 16, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2900), 27, 18, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2901), 33, 17, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2902), 29, 15, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2903), 4, 8, 1, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2904), 2, 12, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2905), 14, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2906), 37, 13, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2907), 43, 13, 5, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2908), 33, 18, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2909), 20, 9, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2910), 19, 24, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2911), 36, 16, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2912), 35, 27, 1, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2913), 25, 2, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2914), 30, 16, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2915), 19, 26, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2916), 20, 22, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2917), 32, 26, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2918), 35, 4, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2919), 17, 22, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2920), 9, 17, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2921), 23, 25, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2922), 3, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2923), 30, 4, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2924), 28, 7, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2925), 41, 12, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2925), 20, 12, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2926), 25, 17, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2927), 1, 28, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2928), 24, 11, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2929), 32, 4, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2930), 2, 6, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2931), 12, 10, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2932), 11, 27, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2933), 24, 8, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2933), 45, 24, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2934), 31, 20, 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2935), 27, 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2936), 23, 8, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2937), 12, 11, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2938), 25, 25, 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2939), 26, 27, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2940), 15, 15, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2941), 27, 20, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2942), 20, 10, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2943), 13, 5, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2944), 19, 1, 5, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2945), 19, 17, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2946), 33, 13, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2947), 17, 10, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2948), 32, 21, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2949), 34, 26, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2950), 29, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2951), 40, 27, 1, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2952), 17, 13, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2954), 39, 14, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2955), 9, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2956), 3, 6, 1, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2957), 10, 12, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2958), 44, 17, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2959), 26, 24, 5, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2960), 11, 26, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2961), 16, 17, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2962), 26, 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2963), 3, 28, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2963), 6, 7, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2965), 19, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2966), 10, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2967), 7, 22, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2968), 33, 24, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2969), 12, 11, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2970), 37, 2, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2971), 28, 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2972), 19, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2976), 34, 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2978), 25, 28, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2978), 29, 4, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2979), 27, 14, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2980), 31, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2981), 32, 3, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2982), 28, 6, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2983), 22, 12, 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2984), 41, 12, 2, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2985), 14, 28, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2986), 44, 4, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2987), 35, 19, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2988), 40, 23, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2989), 27, 21, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2990), 30, 21, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2991), 8, 14, 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2992), 6, 12, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2993), 23, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2994), 41, 11, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2995), 9, 10, 3, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2996), 29, 6, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2996), 7, 6, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2997), 32, 15, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2998), 43, 16, 5, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2999), 43, 3, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3000), 7, 3, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3001), 2, 23, 4, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3002), 28, 23, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3003), 6, 25, 5, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3003), 26, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3005), 11, 1, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3006), 22, 2, 3, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3007), 36, 16, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3008), 11, 11, 5, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3008), 45, 23, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3009), 26, 25, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3010), 30, 24, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3011), 34, 25, 3, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3012), 34, 14, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3013), 22, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3014), 38, 10, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3015), 20, 22, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3016), 31, 20, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3018), 8, 24, 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3019), 25, 28, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3020), 23, 20, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "CreationTime", "Day", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3021), 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3022), 22, 20, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3023), 12, 28, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3024), 16, 1, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3025), 14, 16, 5, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3029), 32, 14, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3030), 23, 18, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3032), 11, 3, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3033), 2, 20, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3033), 20, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3034), 42, 2, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3035), 9, 20, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3037), 7, 15, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3038), 23, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3039), 28, 6, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3040), 39, 7, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3041), 12, 22, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3042), 14, 9, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3043), 44, 23, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3044), 39, 26, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3045), 33, 6, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3046), 29, 18 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3047), 31, 18, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3048), 27, 2, 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3049), 36, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3050), 23, 1, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3052), 4, 1, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3053), 36, 19, 5, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3053), 15, 9, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3054), 26, 27, 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3056), 20, 11, 5, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3057), 11, 13, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3058), 42, 27, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3059), 20, 13, 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3060), 33, 1, 5, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3061), 1, 15, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3062), 43, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3063), 32, 22, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3065), 18, 3, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3066), 41, 25, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3127), 40, 14, 1, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3130), 13, 11, 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3132), 22, 13, 2, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3133), 18, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3134), 41, 11, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3136), 14, 21, 2, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3137), 16, 16, 5, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3138), 8, 23, 3, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3140), 18, 4, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3142), 19, 3, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3143), 33, 27, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3144), 38, 19, 2, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3145), 10, 5, 1, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3146), 28, 4, 4, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3148), 29, 7, 5, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3149), 17, 9, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3150), 14, 28, 2, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3152), 21, 9, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3153), 41, 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3154), 20, 26, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3155), 33, 21, 4, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3157), 29, 7, 5, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3158), 29, 21, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3159), 22, 16, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3160), 27, 25, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3161), 25, 22, 5, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3162), 44, 4, 3, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3163), 23, 21, 1, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3164), 21, 19, 3, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3165), 39, 26, 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3166), 43, 23, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3167), 26, 13, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3168), 40, 11, 4, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3170), 30, 27, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3171), 4, 20, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3173), 15, 7, 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3174), 30, 19, 4, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3176), 2, 15, 5, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3177), 14, 9, 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3178), 36, 3, 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3179), 36, 24, 4, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3180), 21, 9, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3181), 32, 16, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3183), 5, 9, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3184), 38, 15, 2, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3185), 4, 25, 3, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3186), 12, 5, 3, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3187), 36, 28, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3191), 9, 18, 5, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3193), 31, 25, 3, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3194), 6, 10, 2, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3195), 36, 26, 4, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3197), 9, 21, 5, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3198), 45, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3199), 38, 4, 4, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3200), 2, 4, 4, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3201), 10, 28, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3202), 16, 21, 4, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3203), 43, 27, 1, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3204), 38, 25, 2, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3205), 25, 23, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3206), 29, 6, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3207), 40, 16, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3208), 17, 21, 4, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3210), 34, 16, 5, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3211), 12, 28, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3213), 4, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3214), 13, 18, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3215), 6, 16, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3216), 36, 2, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3217), 30, 12, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3218), 36, 3, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3219), 44, 27, 3, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3221), 34, 25, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3222), 19, 7, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3223), 11, 15, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3224), 25, 27, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3225), 36, 24, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3226), 42, 23, 2, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3227), 4, 10, 5, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3228), 28, 17, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3229), 27, 16, 2, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3231), 43, 3, 4, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3231), 7, 15, 5, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3233), 20, 18, 3, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3234), 45, 24, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3235), 26, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3236), 38, 8, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3237), 29, 1, 3, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3238), 20, 13, 1, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3239), 30, 15, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3240), 29, 20, 5, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3241), 12, 4, 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3242), 43, 3, 5, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3243), 17, 15, 2, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3245), 1, 22, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3246), 36, 19, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3247), 37, 10, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3248), 44, 3, 3, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3249), 11, 6, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3250), 19, 18, 2, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3252), 7, 9, 5, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3253), 43, 26, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3254), 21, 17, 2, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3255), 4, 9, 5, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3256), 10, 15, 5, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3257), 25, 25, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3258), 7, 27, 5, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3260), 29, 15, 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3261), 35, 6, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3262), 10, 28, 2, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3263), 26, 2, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3264), 22, 3, 1, 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3265), 1, 28, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3266), 44, 4, 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3267), 33, 22, 2, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3268), 19, 27, 5, 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3270), 39, 15, 3, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3271), 7, 7, 4, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3272), 24, 26, 1, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3273), 31, 10, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3274), 41, 26, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3275), 37, 25, 2, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3276), 29, 4, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3277), 19, 1, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3278), 43, 14, 4, 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3279), 3, 27, 4, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3280), 3, 4, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3281), 18, 12, 2, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3287), 3, 2, 4, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3288), 31, 3, 1, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3289), 24, 2, 2, 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3290), 29, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3292), 36, 3, 5, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3293), 24, 18, 5, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3294), 23, 28, 1, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3295), 16, 14, 4, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3296), 45, 6, 5, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3297), 41, 13, 2, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3298), 44, 2, 3, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3299), 17, 4, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3300), 9, 6, 1, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3301), 11, 24, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3302), 40, 12, 3, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3303), 31, 17, 1, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3305), 23, 21, 4, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3306), 13, 21, 4, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3307), 17, 25, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3308), 12, 18, 2, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3309), 43, 11, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3310), 35, 6, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3312), 44, 5, 5, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3312), 10, 1, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3313), 29, 18, 2, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3315), 2, 26, 2, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3316), 9, 1, 3, 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3317), 36, 2, 3, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3318), 12, 17, 2, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3319), 27, 8, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3320), 26, 3, 5, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3321), 1, 9, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3322), 45, 21, 5, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3324), 34, 12, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3324), 16, 22, 3, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3326), 26, 1, 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3327), 16, 8, 4, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3328), 12, 18, 4, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3330), 38, 28, 1, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3331), 1, 16, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3332), 18, 6, 4, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3333), 25, 21, 3, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3334), 15, 18, 5, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3335), 34, 27, 4, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3336), 28, 2, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3337), 33, 24, 5, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3339), 15, 13, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "CreationTime", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3339), 21, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3341), 6, 3, 5, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3342), 19, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3343), 10, 24, 5, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3344), 24, 24, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3345), 13, 23, 2, 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3346), 4, 4, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3347), 6, 17, 4, 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3349), 1, 19, 1, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3350), 1, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3351), 32, 26, 5, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3352), 19, 18, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3353), 30, 16, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3354), 27, 11, 5, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3355), 18, 10, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3356), 43, 14, 1, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3357), 6, 6, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3358), 18, 5, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3359), 12, 6, 2, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3361), 16, 19, 4, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "CreationTime", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3362), 16, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3363), 19, 17, 1, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3364), 36, 13, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3365), 26, 13, 2, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(6031));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2630), 28, 15, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2642), 13, 11, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2643), 34, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2644), 19, 26, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2645), 45, 16, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2648), 8, 19, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2648), 31, 21, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2649), 44, 19, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2650), 16, 21, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2652), 36, 21, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2653), 5, 10, 1, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2654), 30, 2, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2655), 26, 5, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2655), 11, 10, 0, 0, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2658), 40, 10, 0, 0, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2661), 25, 13, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2662), 21, 1, 4, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2663), 15, 28, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2664), 25, 8, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2664), 24, 23, 0, 0, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2666), 40, 23, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2667), 28, 8, 4, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2668), 29, 28, 0, 0, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2671), 4, 1, 0, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2672), 29, 13, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2673), 8, 16, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2674), 18, 26, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2676), 42, 19, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2677), 5, 9, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2678), 30, 6, 5, 0, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2679), 10, 6, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2680), 6, 4, 3, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2681), 7, 17, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2682), 21, 8, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2683), 26, 23, 0, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2685), 28, 10, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2686), 41, 2, 2, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2687), 22, 3, 2, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2689), 16, 25, 3, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2690), 7, 1, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2691), 45, 17, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2692), 26, 17, 1, 0, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2693), 22, 12, 2, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2696), 31, 1, 0, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2697), 19, 3, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2699), 39, 20, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2703), 21, 7, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2704), 19, 24, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2705), 26, 12, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2706), 40, 10, 2, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2708), 5, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2709), 32, 1, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2710), 24, 24, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2711), 30, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2712), 5, 14, 0, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2713), 25, 13, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2714), 4, 28, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2715), 7, 18, 4, 0 });

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
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2717), 10, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2718), 21, 7, 1, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2719), 30, 21, 0, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2720), 19, 8, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2720), 44, 23, 2, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2721), 24, 3, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2722), 20, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2723), 16, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2724), 23, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2725), 34, 11, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2725), 44, 20, 4, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2726), 43, 16, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2727), 9, 11, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2728), 21, 2, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2729), 45, 20, 3, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2730), 2, 28, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2731), 34, 16, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "CreationTime", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2731), 2, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2732), 22, 6, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2733), 19, 27, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2734), 32, 3, 4, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2735), 34, 13, 1, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2736), 32, 20, 0, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2736), 34, 1, 0, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2738), 23, 7, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2738), 30, 24, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2739), 30, 6, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2740), 11, 27, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2741), 32, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2742), 25, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2743), 11, 21, 2, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2744), 23, 4, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2745), 28, 8, 3, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2745), 36, 24, 4, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2746), 3, 5, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2747), 11, 28, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2748), 34, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2749), 12, 13, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2750), 2, 23, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2751), 25, 5, 2, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2752), 29, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2753), 28, 16, 0, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2754), 39, 12, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2755), 3, 18, 2, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2756), 40, 7, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2757), 29, 0, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2758), 16, 24, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2759), 17, 10, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2760), 22, 16, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2761), 14, 15, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2761), 7, 16, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2762), 30, 5, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2763), 18, 11, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2764), 1, 17, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "CreationTime", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2764), 14, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2765), 16, 25, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2770), 7, 23, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2771), 37, 10, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2772), 13, 18, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2773), 23, 22, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2774), 17, 7, 0, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2774), 36, 8, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2775), 37, 25, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2776), 26, 6, 0, 0, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2778), 35, 1, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2779), 8, 18, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2781), 24, 13, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2781), 7, 23, 0, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2782), 31, 12, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2783), 31, 23, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2784), 25, 2, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2785), 5, 8, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2786), 3, 10, 3, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2787), 31, 8, 0, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2788), 41, 5, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2791), 44, 24, 5, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2793), 17, 20, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2793), 16, 28, 1, 0, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2795), 42, 13, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2796), 18, 17, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2797), 34, 13, 2, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2798), 11, 23, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2799), 32, 27, 2, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2800), 41, 8, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2801), 22, 25, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2802), 13, 4, 4, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2803), 11, 1, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2804), 45, 26, 1, 0, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2805), 42, 15, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2806), 38, 19, 1, 0, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2808), 18, 12, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2809), 25, 22, 2, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2810), 22, 7, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2811), 10, 5, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2813), 43, 13, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2814), 15, 3, 0, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2815), 38, 5, 0, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2816), 21, 24, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2816), 10, 8, 4, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2817), 6, 22, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2818), 6, 19, 2, 0, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2820), 27, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2820), 17, 4, 2, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2821), 26, 4, 2, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2823), 30, 21, 2, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2824), 7, 27, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2825), 28, 7, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2826), 16, 12, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2827), 12, 7, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2827), 4, 7, 4, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2828), 35, 23, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2829), 14, 9, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2831), 20, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2831), 32, 11, 2, 0, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2833), 3, 28, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2834), 31, 20, 0, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2835), 18, 22, 0, 1 });

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
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2837), 29, 4, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2838), 37, 8, 4, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2840), 41, 10, 0, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2841), 42, 3, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2842), 11, 11, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2843), 17, 23, 0, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2844), 35, 19, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2845), 45, 15, 3, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2846), 13, 27, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2847), 5, 15, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2848), 5, 26, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2848), 23, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2849), 21, 19, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2850), 8, 17, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2851), 43, 19, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2852), 35, 4, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2853), 6, 4, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2854), 41, 20, 2, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2855), 20, 4, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2859), 20, 22, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2860), 7, 12, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2861), 19, 6, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2862), 18, 6, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2863), 35, 24, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2864), 27, 1, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2865), 2, 22, 3, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2866), 19, 1, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2867), 1, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2868), 10, 25, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2869), 21, 5, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2869), 44, 4, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2870), 3, 23, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2871), 18, 13, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2872), 29, 10, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2873), 16, 4, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2874), 19, 4, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2875), 23, 16, 5, 0, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2876), 19, 3, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2877), 32, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2878), 10, 20, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2879), 20, 10, 2, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2880), 31, 19, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2881), 32, 23, 3, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2882), 37, 15, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2883), 36, 16, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2884), 16, 28, 5, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2886), 38, 18, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2887), 1, 14, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2888), 32, 11, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2889), 14, 24, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2891), 38, 26, 5, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2892), 2, 25, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2893), 29, 27, 0, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "CreationTime", "Day", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2893), 42, 0, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2896), 35, 5, 0, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2897), 32, 13, 2, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2898), 1, 6, 0, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2899), 35, 21, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2899), 33, 23, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2901), 34, 9, 4, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2901), 3, 12, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2902), 17, 28, 0, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2904), 30, 14, 4, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2905), 22, 27, 1, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2906), 25, 21, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2910), 29, 9, 4, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2912), 6, 17, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2912), 35, 4, 0, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2914), 30, 24, 0, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2915), 38, 15, 0, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2915), 34, 11, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2916), 12, 17, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2918), 34, 25, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2919), 39, 16, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2920), 19, 9, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2921), 28, 21, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2922), 27, 8, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2923), 4, 2, 4, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2923), 27, 25, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2924), 25, 11, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2925), 26, 25, 0, 0, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2927), 12, 7, 0, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2928), 45, 26, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2929), 10, 12, 1, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2929), 11, 12, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2930), 5, 17, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2931), 21, 13, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2932), 43, 11, 0, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2933), 16, 17, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2934), 36, 26, 5, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2935), 43, 27, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2936), 2, 1, 0, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2937), 12, 3, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2938), 30, 27, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2939), 25, 7, 4, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2940), 39, 11, 2, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2941), 23, 16, 1, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2941), 13, 2, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2942), 6, 0, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2943), 6, 25, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2944), 30, 1, 5, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2945), 11, 10, 5, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2945), 25, 13, 3, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2946), 10, 3, 2, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2947), 41, 20, 4, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2948), 39, 14, 1, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2949), 27, 4, 5, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2950), 3, 0, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2951), 35, 20, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2951), 39, 19, 1, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2952), 23, 18, 2, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2953), 12, 15, 4, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2954), 32, 3, 4, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2955), 21, 17, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2956), 45, 10, 3, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2957), 42, 15, 0, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2958), 1, 3, 4, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2958), 1, 2, 1, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2959), 30, 4, 3, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2961), 32, 7, 2, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2961), 12, 8, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2962), 22, 9, 1, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2963), 19, 5, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2964), 18, 8, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2965), 42, 4, 5, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2965), 14, 16, 2, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2966), 1, 3, 3, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2967), 2, 24, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2968), 37, 25, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2969), 35, 22, 0, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2970), 25, 7, 3, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2971), 10, 8, 3, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2972), 2, 28, 2, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2972), 10, 12, 0, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2973), 20, 23, 1, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2974), 14, 10, 5, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2975), 23, 24, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2976), 37, 4, 3, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2977), 15, 15, 1, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2978), 24, 21, 5, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2978), 41, 4, 3, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2979), 17, 20, 3, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2980), 40, 11, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2981), 42, 5, 1, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2982), 43, 18, 3, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2983), 34, 2, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2984), 23, 3, 5, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2985), 11, 12, 3, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2986), 32, 22, 4, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2987), 7, 14, 5, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2988), 2, 20, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2989), 32, 4, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2990), 20, 4, 5, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2990), 11, 3, 2, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2991), 33, 25, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2992), 36, 0, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2993), 6, 16, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2994), 9, 23, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2995), 28, 4, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2996), 8, 10, 5, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2996), 34, 27, 5, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2997), 45, 5, 5, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2998), 5, 10, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(2999), 9, 17, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3000), 5, 18, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3004), 9, 5, 1, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3006), 5, 14, 4, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3007), 15, 27, 4, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3007), 14, 5, 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3008), 32, 19, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3009), 44, 7, 3, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3010), 25, 5, 2, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3010), 12, 12, 2, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3011), 24, 2, 4, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3012), 43, 13, 3, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3013), 19, 0, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3014), 41, 19, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3015), 25, 26, 1, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3016), 39, 12, 4, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3017), 18, 2, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3018), 33, 12, 1, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3018), 13, 0, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3019), 30, 12, 2, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3020), 19, 6, 0, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3021), 45, 2, 2, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3022), 21, 16, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3023), 11, 23, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3024), 22, 17, 2, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3025), 43, 1, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3026), 16, 25, 0, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3027), 36, 2, 2, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3028), 6, 1, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3029), 39, 25, 0, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3030), 26, 23, 4, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3031), 25, 11, 4, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3031), 5, 20, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3032), 14, 7, 2, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3033), 6, 16, 4, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3034), 5, 2, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3035), 7, 17, 3, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3036), 6, 4, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3037), 42, 10, 2, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3037), 13, 27, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3038), 6, 22, 2, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3039), 42, 12, 4, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3040), 18, 28, 3, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3041), 18, 24, 1, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3042), 13, 13, 3, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3043), 45, 28, 2, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3044), 19, 17, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3045), 7, 27, 2, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3046), 3, 16, 0, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3047), 3, 26, 3, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3047), 18, 4, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3048), 2, 9, 2, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3049), 30, 14, 5, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3050), 21, 1, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3051), 26, 4, 5, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3052), 22, 5, 3, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3053), 36, 24, 5, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3053), 43, 9, 5, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3054), 19, 25, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3055), 37, 10, 2, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3056), 21, 21, 0, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3057), 2, 22, 0, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3057), 31, 10, 0, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3058), 31, 5, 3, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3059), 15, 17, 3, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3060), 36, 9, 4, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3061), 40, 12, 5, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3062), 15, 5, 4, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3062), 41, 25, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3063), 12, 22, 5, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3064), 39, 13, 0, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3065), 30, 25, 1, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3066), 9, 8, 5, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3067), 32, 12, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3068), 10, 15, 1, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3069), 28, 17, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3069), 26, 17, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3070), 24, 1, 4, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3071), 13, 21, 0, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3072), 17, 2, 3, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3073), 30, 23, 5, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3073), 10, 7, 0, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3074), 45, 14, 0, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3075), 37, 16, 5, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3076), 30, 21, 5, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3077), 24, 9, 4, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3078), 6, 5, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3079), 28, 25, 1, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3079), 33, 11, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3080), 15, 3, 5, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3081), 7, 0, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3082), 22, 16, 1, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3083), 24, 19, 2, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3084), 32, 10, 5, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3084), 26, 10, 0, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3085), 36, 12, 3, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3086), 44, 10, 5, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3087), 39, 12, 4, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3088), 12, 26, 3, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3088), 4, 3, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3089), 42, 15, 4, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3090), 22, 15, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "CreationTime", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3091), 16, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3092), 29, 24, 2, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3095), 22, 5, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3097), 9, 14, 1, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3098), 6, 12, 0, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3099), 39, 21, 1, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3099), 2, 12, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3100), 19, 28, 1, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3101), 29, 27, 2, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3102), 37, 3, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3103), 18, 28, 3, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3103), 29, 8, 0, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3104), 26, 6, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3105), 36, 27, 2, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3106), 44, 22, 3, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3107), 21, 7, 2, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3108), 24, 7, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3109), 26, 17, 0, null });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3110), 23, 15, 4, 0, null, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3111), 12, 3, 5, 0, null, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "CreationTime", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3111), 27, null, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3112), 20, 7, 5, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3113), 15, 7, 4, null, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 54, 58, 334, DateTimeKind.Local).AddTicks(3114), 4, 15, 5, 0, null, 5 });

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
    }
}
