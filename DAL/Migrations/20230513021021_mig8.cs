using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9490), 33, 12, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9504), 38, 20, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9506), 18, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9507), 44, 20, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9508), 18, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9511), 22, 18, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9513), 1, 6, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9514), 4, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9515), 22, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9516), 15, 15, 2, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9518), 44, 5, 3, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9519), 13, 27, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9520), 7, 24, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9521), 20, 18, 3, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9522), 5, 3, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9523), 14, 26, 5, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9529), 21, 14, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9531), 28, 10, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9532), 24, 19, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9533), 7, 22, 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9534), 45, 21, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9535), 42, 9, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9536), 13, 6, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9537), 25, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9538), 34, 17, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9539), 3, 23, 5, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9540), 41, 9, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9542), 23, 27, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9543), 15, 9, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9544), 13, 8, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9545), 36, 26, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9546), 31, 7, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9546), 19, 12, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9548), 10, 9, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9550), 11, 8, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9551), 22, 10, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9552), 32, 20, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9553), 23, 11, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9553), 32, 25, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9554), 20, 13, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9555), 33, 25, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9556), 14, 13, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9557), 6, 8, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9558), 38, 8, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9559), 40, 11, 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9560), 29, 16, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9561), 25, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9562), 4, 7, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9563), 33, 1, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9564), 34, 16, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9565), 13, 26, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9567), 24, 13, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9568), 32, 18, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9569), 32, 10, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9570), 28, 23, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9571), 20, 28, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9572), 17, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9573), 13, 15, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9574), 1, 24, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9575), 37, 17, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9576), 13, 25, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9577), 11, 1, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9578), 22, 15, 5, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9579), 34, 26, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9580), 33, 7, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9582), 22, 11, 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9583), 2, 21, 1, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9584), 12, 15, 1, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9586), 6, 9, 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9587), 33, 26, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9588), 24, 18, 3, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9589), 26, 4, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9590), 41, 18, 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9591), 7, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9592), 10, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9592), 27, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9594), 42, 25, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9594), 15, 20, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9595), 21, 5, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9596), 22, 24, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9597), 8, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9598), 20, 20, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9600), 19, 4, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9601), 4, 7, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9602), 24, 6, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9603), 22, 28, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9604), 36, 7, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9605), 29, 12, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9606), 36, 24, 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9607), 30, 9, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9608), 21, 8, 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9609), 32, 10, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9610), 21, 13, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9611), 5, 9, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9612), 44, 8, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9617), 38, 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9618), 32, 6, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9619), 21, 8, 2, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9620), 17, 3, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9621), 44, 16, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9622), 25, 17, 5, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9623), 36, 12, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9624), 32, 17, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9625), 30, 22, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9626), 33, 19, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9627), 8, 5, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9628), 44, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9629), 26, 19, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9630), 9, 24, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9631), 41, 20, 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9632), 3, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9633), 34, 5, 5, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9634), 32, 8, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9635), 6, 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9636), 28, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9637), 17, 26, 3, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9638), 7, 25, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9639), 14, 12, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9640), 29, 27, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9641), 35, 18, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9642), 33, 28, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9643), 43, 16, 1, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9644), 11, 18, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9645), 19, 7, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9646), 11, 16, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9647), 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9648), 30, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9649), 44, 13, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9650), 32, 1, 5, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9652), 27, 26, 3, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9653), 33, 17, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9654), 6, 12, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9655), 7, 19, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9656), 7, 17, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9657), 18, 20, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9658), 22, 7, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "CreationTime", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9659), 12, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9660), 38, 10, 5, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9661), 28, 14, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9662), 29, 24, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9663), 33, 22, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9664), 3, 26, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9666), 37, 12, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9667), 34, 16, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9668), 40, 9, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9669), 22, 28, 1, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9670), 42, 4, 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9671), 21, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9672), 22, 18, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9673), 17, 19, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9674), 45, 16, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9676), 24, 18, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9677), 16, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9678), 8, 27, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9679), 35, 21, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9680), 17, 9, 1, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9681), 19, 9, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9682), 21, 13, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9683), 21, 2, 5, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9684), 20, 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9685), 35, 28, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9686), 43, 28, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9688), 28, 7, 5, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9689), 11, 16, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9690), 41, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9691), 31, 8, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9692), 15, 7, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9693), 2, 10, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9694), 26, 17, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9695), 20, 6, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9696), 42, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9700), 36, 13, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9701), 15, 16, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9702), 12, 26, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9703), 27, 1, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9704), 15, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9706), 23, 21, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9707), 11, 19, 3, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9708), 29, 20, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9708), 2, 5, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9709), 4, 10, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9711), 1, 4, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9711), 16, 10, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9712), 17, 6, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9714), 41, 24, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9715), 23, 17, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9716), 36, 4, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9717), 11, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9718), 31, 7, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9719), 31, 24, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9720), 17, 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "CreationTime", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9721), 7, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9722), 16, 1, 2, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9723), 14, 6, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9724), 37, 10, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9725), 42, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9726), 16, 8, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9727), 41, 25, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9728), 19, 17, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9729), 21, 16, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9730), 43, 15, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9731), 17, 21, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9732), 31, 11, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9733), 26, 2, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9734), 5, 28, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9735), 28, 10, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9736), 15, 19, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9737), 24, 26, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9738), 39, 22, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9739), 14, 10, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9740), 35, 13, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9741), 42, 19, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9742), 38, 26, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9743), 42, 24, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9744), 9, 15, 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9745), 27, 11, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9746), 11, 18, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9747), 37, 25, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9748), 9, 16, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9749), 39, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9750), 33, 24, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9751), 1, 27, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9752), 18, 21, 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9753), 31, 12, 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9754), 12, 27, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9755), 24, 26, 5, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9756), 26, 6, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9757), 16, 25, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9758), 1, 12, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9759), 28, 1, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9760), 44, 3, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9761), 38, 10, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9762), 26, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9763), 3, 5, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9764), 1, 9, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9765), 38, 16, 4, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9766), 3, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9767), 22, 13, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9768), 30, 15, 5, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9769), 41, 24, 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9770), 32, 19, 5, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9771), 2, 13, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9772), 17, 23, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9773), 21, 15, 5, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9774), 16, 28, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9775), 11, 23, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9776), 4, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9777), 12, 11, 2, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9778), 26, 26, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9779), 25, 24, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9780), 32, 10, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9781), 20, 9, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9782), 18, 5, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9783), 21, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9784), 43, 9, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9785), 17, 3, 1, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9786), 44, 21, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9792), 45, 9, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9793), 44, 26, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9794), 40, 16, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9795), 14, 22, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9797), 40, 14, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9797), 38, 4, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9798), 34, 26, 2, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9799), 41, 8, 5, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9800), 28, 10, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9801), 9, 10, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9802), 41, 8, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9803), 3, 12, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9804), 9, 4, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9805), 15, 14, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9806), 35, 28, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9807), 37, 8, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9808), 31, 8, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9809), 22, 28, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9810), 25, 12, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9811), 33, 7, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9812), 3, 16, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9813), 35, 11, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9814), 9, 7, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9815), 32, 16, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9816), 34, 25, 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9817), 32, 14, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9818), 13, 9, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9819), 8, 27, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9820), 8, 27, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9821), 8, 28, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9822), 45, 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9823), 28, 7, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9824), 14, 26, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9825), 25, 12, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9825), 45, 23, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9827), 6, 11, 5, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9828), 32, 13, 3, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9829), 16, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9830), 22, 10, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9831), 5, 10, 3, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9832), 24, 17, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9833), 3, 23, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9834), 16, 6, 1, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9835), 44, 21, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9837), 31, 28, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9838), 32, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9839), 8, 23, 5, 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9840), 8, 21, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9842), 9, 19, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9843), 44, 20, 4, 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9844), 24, 13, 1, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9845), 30, 6, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9846), 7, 9, 3, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9847), 42, 11, 4, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9849), 38, 12, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9850), 21, 5, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9851), 32, 20, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9852), 14, 14, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9853), 39, 10, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9854), 19, 19, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9856), 42, 1, 5, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9857), 35, 22, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9858), 19, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9859), 25, 22, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9860), 12, 12, 3, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9862), 27, 8, 5, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9863), 33, 8, 4, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9867), 17, 15, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9868), 29, 28, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9869), 12, 4, 4, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9870), 14, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9872), 8, 12, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9873), 12, 4, 1, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9874), 12, 7, 2, 0, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9875), 37, 17, 2, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9876), 17, 10, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9877), 32, 16, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9878), 36, 22, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9879), 20, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9881), 41, 19, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9882), 24, 5, 0, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9883), 16, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9884), 38, 27, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9886), 27, 13, 1, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9887), 39, 3, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9888), 12, 1, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9889), 20, 21, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9890), 38, 7, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9891), 6, 24, 2, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9892), 29, 14, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9893), 35, 13, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9895), 11, 10, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9896), 14, 16, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9897), 37, 24, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9898), 19, 21, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9899), 13, 28, 3, 0, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9900), 1, 16, 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9901), 41, 11, 3, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9902), 34, 17, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9904), 27, 3, 4, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9905), 9, 22, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9906), 13, 5, 4, 3, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9906), 25, 15, 1, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9907), 29, 17, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9908), 8, 14, 3, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9909), 6, 17, 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9911), 13, 28, 3, 0, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9912), 44, 12, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9913), 5, 9, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9914), 20, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9915), 3, 16, 5, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9916), 18, 21, 3, 0, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9917), 23, 5, 4, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9919), 36, 28, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9920), 29, 12, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9921), 31, 8, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9922), 17, 24, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9923), 17, 2, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9924), 43, 20, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9925), 25, 6, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9926), 35, 16, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9928), 24, 14, 4, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9929), 34, 22, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9930), 12, 28 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9931), 27, 27, 4, 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9932), 14, 13, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9933), 1, 23, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9934), 24, 25, 1, 0, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9935), 2, 27, 4, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9936), 37, 13, 5, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9938), 2, 24, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9939), 32, 22, 1, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9940), 39, 12, 3, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9941), 2, 6, 2, 0, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9942), 29, 11, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9943), 5, 16, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9944), 14, 25, 3, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9945), 15, 23, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9946), 12, 25, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9947), 10, 23, 4, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9948), 15, 22, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9950), 9, 22, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9951), 27, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9952), 22, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9953), 14, 26, 3, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9954), 38, 9, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9955), 42, 11, 4, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9957), 13, 17, 3, 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9958), 29, 26, 2, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9959), 45, 25, 4, 0, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9960), 17, 12, 3, 0, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9961), 7, 9, 3, 0, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9962), 21, 25, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9964), 12, 18, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9965), 30, 12, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9966), 40, 11, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9967), 14, 24, 0, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9968), 22, 2, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9969), 2, 10, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9970), 20, 10, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9971), 28, 22, 5, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9972), 39, 24, 3, 0, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9974), 44, 24, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9975), 40, 4, 2, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9976), 28, 13, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9977), 21, 5, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9978), 15, 10, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9979), 37, 11, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9980), 31, 5, 4, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9985), 29, 8, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9987), 8, 3, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9988), 31, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9989), 27, 10, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9990), 33, 13, 2, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9991), 8, 24, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9992), 34, 27, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9993), 39, 9, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9994), 9, 7, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9995), 37, 28, 5, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9996), 34, 20, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9998), 38, 28, 1, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 978, DateTimeKind.Local).AddTicks(9999), 8, 7, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local), 8, 7, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(1), 10, 19, 5, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(2), 16, 28, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(3), 22, 5, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(4), 3, 28, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(5), 13, 22, 4, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(6), 18, 15, 5, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(7), 23, 1, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(9), 28, 28, 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(10), 30, 12, 4, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(11), 19, 4, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(12), 36, 7, 5, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(14), 42, 20, 4, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(15), 29, 14, 5, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(16), 43, 21, 4, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(17), 17, 10, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(18), 14, 10, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(19), 32, 14, 2, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(20), 39, 24, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(21), 17, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(23), 1, 4, 0, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(24), 33, 2, 2, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(25), 27, 23, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(26), 27, 20, 2, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(27), 38, 19, 5, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(28), 38, 21, 1, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(29), 33, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(30), 4, 23, 2, 0, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(31), 43, 26, 1, 0, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(32), 33, 25, 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(33), 18, 9, 1, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(34), 21, 2, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(35), 36, 8, 2, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(37), 14, 2, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(38), 30, 10, 3, 0, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(39), 45, 14, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(40), 22, 20, 4, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(41), 16, 6, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(42), 24, 14, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(43), 32, 17, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(44), 21, 26, 3, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(45), 30, 12, 5, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(46), 20, 17, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(47), 6, 19, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(48), 30, 14, 4, 0, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(50), 39, 26, 2, 0, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(51), 15, 15, 0, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(52), 44, 28, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(53), 36, 23, 2, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(54), 11, 2, 5, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(55), 8, 4, 2, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(56), 31, 26, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(57), 29, 10, 3, 0, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(58), 33, 7, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(59), 31, 19, 4, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(60), 31, 17, 1, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(62), 3, 11, 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(62), 15, 14, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(63), 7, 9, 3, 0, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(64), 1, 15, 2, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(66), 37, 17, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 10, 20, 979, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 4, 18, 14, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 4, 18, 14, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 4, 18, 14, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 4, 18, 14, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 4, 18, 14, 30, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6765), 41, 16, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6780), 1, 10, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6781), 42, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6782), 41, 25, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationTime", "Day", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6783), 25, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6786), 30, 24, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6787), 31, 25, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6788), 24, 21, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6790), 18, 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6792), 36, 3, 5, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6793), 14, 24, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6794), 22, 13, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6795), 12, 26, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6797), 2, 17, 5, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6798), 4, 8, 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6799), 5, 20, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6800), 41, 15, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6802), 4, 20, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6803), 33, 27, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6804), 30, 25, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6805), 19, 28, 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6806), 39, 14, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6807), 30, 18, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6808), 27, 17, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6810), 35, 13, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6811), 32, 21, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6812), 19, 8, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6813), 14, 6, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6814), 21, 7, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6815), 31, 19, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6816), 9, 25, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6817), 25, 26, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6818), 1, 14, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6820), 29, 27, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6821), 2, 11, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6822), 42, 4, 2, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6823), 15, 27, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6824), 13, 16, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6825), 30, 28, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6826), 29, 22, 3, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6827), 9, 22, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6828), 31, 20, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6829), 16, 10, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6830), 32, 21, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6831), 22, 12, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6833), 28, 17, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6833), 31, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6834), 5, 20, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6835), 44, 23, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6837), 10, 21, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6838), 12, 16, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6839), 38, 8, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6840), 23, 24, 5, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6841), 8, 8, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6842), 7, 21, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6849), 11, 11, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6850), 1, 14, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6851), 22, 20, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6852), 6, 27, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6853), 5, 9, 4, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6854), 34, 27, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6855), 20, 5, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6856), 15, 23, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6857), 3, 10, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6858), 4, 24, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6860), 16, 19, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6861), 20, 25, 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6863), 15, 18, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6864), 24, 3, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6864), 29, 9, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6865), 2, 20, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6866), 27, 21, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6867), 5, 5, 2, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6868), 18, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6869), 7, 13, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6870), 1, 5, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6871), 41, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6872), 10, 25, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6873), 26, 26, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6875), 18, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6876), 20, 13 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6877), 39, 14, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6878), 13, 27, 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6879), 33, 18, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6879), 11, 4, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6880), 45, 2, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6881), 21, 12, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6882), 32, 14, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6883), 7, 2, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6884), 9, 8, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6885), 27, 23, 5, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6886), 43, 14, 1, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6887), 29, 19, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6888), 11, 22, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6889), 40, 21, 2, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6890), 35, 28, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6891), 19, 24, 5, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6892), 44, 7, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6893), 19, 1, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6894), 38, 27, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6895), 27, 15, 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6896), 30, 18, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6897), 35, 19, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6898), 19, 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6899), 36, 8, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6900), 9, 6, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6901), 20, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6902), 33, 7, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6903), 7, 23, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6904), 4, 16, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6905), 45, 19, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6906), 21, 10, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6908), 44, 1, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6909), 44, 21, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6910), 38, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6911), 1, 8, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6912), 17, 18, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6912), 15, 17, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6914), 40, 2, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6914), 19, 9, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6915), 43, 14, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6916), 6, 22, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6917), 39, 19, 5, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6918), 44, 25, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6919), 41, 5, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6920), 27, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6921), 33, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6922), 18, 21, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6923), 41, 12, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6928), 14, 22, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6929), 14, 9, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6930), 33, 8, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6931), 12, 18, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6932), 41, 24, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6933), 14, 16, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6934), 26, 17, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "CreationTime", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6936), 20, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6937), 11, 25, 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6938), 14, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6939), 22, 8, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6940), 4, 26, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6941), 39, 20, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6942), 30, 5, 1, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6943), 31, 17, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6944), 39, 16, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6945), 19, 19, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6946), 29, 5, 5, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6947), 32, 6, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6948), 40, 2, 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6949), 26, 22, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6950), 38, 6, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6951), 33, 13, 5, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6952), 13, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6953), 16, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6954), 8, 7, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6955), 9, 3, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6956), 27, 15, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6957), 14, 23, 5, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6958), 40, 15, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6959), 42, 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6960), 11, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6961), 5, 8, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6963), 35, 15, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6964), 9, 13, 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6964), 24, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6965), 19, 15, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6966), 34, 26, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6967), 9, 5, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6968), 4, 27, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6969), 5, 9, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6970), 31, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6972), 27, 22, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6973), 44, 15, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6974), 42, 18, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6975), 15, 7, 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6976), 18, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6977), 9, 23, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6977), 22, 15, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6979), 1, 6, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6980), 11, 13, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6981), 32, 3, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6982), 13, 7, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6983), 31, 27, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6984), 3, 8, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6985), 16, 22, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6986), 14, 20, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6987), 7, 17, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6988), 13, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6988), 35, 27, 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6989), 27, 15, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6990), 1, 17, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "CreationTime", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6991), 21, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6992), 31, 16, 5, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6993), 6, 11, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6994), 41, 26, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6995), 8, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6996), 13, 24, 3, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6997), 20, 17, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6998), 32, 18, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6999), 15, 13, 5, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7000), 11, 24, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7001), 44, 9, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7002), 5, 22, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7003), 6, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7004), 19, 3, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7005), 24, 8, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7006), 37, 17, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7007), 20, 22, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7008), 20, 12, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7009), 42, 25, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7011), 16, 25, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7012), 3, 1, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7013), 40, 24, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7013), 1, 16, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7015), 30, 18, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7016), 33, 5, 5, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7017), 24, 7, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7018), 6, 21, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7019), 18, 20, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7020), 8, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7025), 3, 20, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7026), 7, 16, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7027), 5, 24, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7028), 29, 4, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7028), 26, 1, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7030), 22, 9, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7031), 42, 11, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7032), 7, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7033), 39, 18, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7034), 5, 14, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7035), 38, 28, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7036), 45, 12, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7037), 34, 14, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7038), 38, 24, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7039), 31, 17, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7041), 35, 10, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7042), 45, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7043), 44, 21, 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7044), 33, 26, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7045), 43, 11, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7046), 19, 20, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7047), 3, 27, 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7048), 8, 26, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7049), 5, 5, 4, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7050), 9, 24, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7051), 45, 21, 5, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7052), 10, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7053), 29, 26, 5, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7054), 8, 25, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7055), 2, 9, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7056), 12, 7, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7057), 31, 28, 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7058), 4, 18, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7059), 27, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7060), 37, 8, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7061), 31, 14, 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7062), 45, 18, 2, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7064), 25, 23, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7065), 7, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7066), 4, 5, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7068), 35, 7, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7068), 45, 16, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7069), 15, 2, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7070), 13, 2, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7072), 29, 7, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7073), 14, 5, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7074), 15, 4, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7075), 6, 17, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7075), 5, 24, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7076), 11, 23, 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7081), 34, 15, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7082), 28, 17, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7083), 12, 26, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7084), 14, 28, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7085), 39, 27, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7087), 13, 17, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7088), 23, 6, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7089), 14, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7090), 1, 9, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7091), 6, 12, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7092), 45, 24, 5, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7093), 33, 23, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7094), 2, 22, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7095), 19, 12, 5, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7096), 26, 26, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7096), 25, 19, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7097), 45, 16, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7098), 9, 21, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7099), 8, 6, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7100), 8, 7, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7102), 16, 2, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7103), 30, 3, 5, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7104), 20, 20, 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7105), 15, 1, 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7106), 35, 6, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7107), 28, 26, 5, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7108), 11, 20, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7109), 20, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7110), 23, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7111), 26, 17, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7112), 4, 7, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7115), 12, 17, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7116), 40, 16, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7117), 32, 19, 2, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7118), 39, 27, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7120), 2, 25, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7121), 40, 8, 2, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7122), 33, 5, 2, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7123), 20, 13, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7124), 23, 24, 5, 0, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7125), 11, 9, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7127), 18, 25, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7128), 17, 25, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7129), 22, 17, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7130), 8, 15, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7131), 11, 15, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7133), 13, 24, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7134), 40, 23, 4, 0, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7135), 14, 27, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7136), 34, 12, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7138), 28, 18, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7139), 14, 13, 2, 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7140), 4, 12, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7141), 10, 18, 1, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7142), 23, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7143), 22, 9, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7144), 4, 21, 3, 0, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7146), 36, 17, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7147), 9, 17, 5, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7147), 19, 14, 3, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7149), 3, 21, 5, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7150), 8, 6, 4, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7151), 38, 12, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7152), 5, 24, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7154), 23, 19, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7154), 3, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7156), 18, 9, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7157), 6, 4, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7158), 29, 5, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7159), 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7160), 41, 14, 5, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7162), 9, 23, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7163), 6, 23, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7164), 28, 18, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7165), 6, 5, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7166), 27, 15, 1, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7167), 44, 13, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7168), 2, 8, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7170), 45, 22, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7171), 5, 27, 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7172), 24, 14, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7173), 42, 24, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7174), 11, 21, 2, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7175), 8, 5, 0, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7176), 38, 8, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7177), 29, 8, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7178), 19, 10, 1, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7180), 12, 26, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7181), 37, 1, 5, 0, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7182), 24, 18, 3, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7183), 15, 19, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7184), 40, 8, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7186), 16, 3, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7187), 20, 4, 1, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7188), 23, 26, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7189), 20, 13, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7190), 10, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7191), 43, 15, 2, 0, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7193), 36, 18, 2, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7194), 22, 10, 2, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7195), 8, 11, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7196), 43, 9, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7201), 42, 15, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7202), 30, 27, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7203), 35, 13, 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7204), 30, 18, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7205), 9, 23, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7207), 22, 19, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7208), 29, 1, 3, 0, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7209), 43, 12, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7210), 30, 27 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7211), 43, 21, 5, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7212), 8, 20, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7214), 21, 17, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7215), 34, 20, 5, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7216), 13, 26, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7217), 1, 24, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7218), 9, 7, 1, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7220), 17, 12, 2, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7220), 38, 5, 4, 0, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7221), 40, 19, 5, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7222), 27, 17, 2, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7225), 41, 7, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7226), 31, 12, 1, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7227), 32, 28, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7253), 40, 28, 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7254), 30, 13, 2, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7256), 27, 6, 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7258), 41, 20, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7259), 30, 13, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7261), 10, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7263), 37, 4, 4, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7265), 39, 3, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7267), 14, 3, 1, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7269), 5, 14, 5, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7271), 35, 9, 3, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7272), 3, 5, 2, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7273), 7, 17, 2, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7274), 42, 19, 1, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7275), 27, 18, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7277), 34, 9, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7278), 33, 7, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7279), 8, 26, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7280), 8, 19, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7281), 11, 7, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7282), 43, 13, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7283), 26, 9, 1, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7284), 1, 20, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7285), 28, 25, 2, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7287), 31, 20, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7288), 41, 10, 3, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7289), 34, 23, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7290), 19, 19, 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7291), 43, 8, 0, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7292), 21, 15, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7293), 4, 18, 1, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7295), 3, 26, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7296), 12, 25, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7297), 23, 4, 0, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7298), 10, 25, 0, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7299), 12, 27, 1, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7300), 39, 15, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7301), 38, 7, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7302), 36, 6, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7304), 10, 5, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7305), 14, 12, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7306), 45, 18, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7307), 29, 3, 3, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7308), 20, 17, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7309), 40, 25, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7310), 29, 22, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7311), 21, 22, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7312), 21, 3, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7314), 42, 6, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7315), 4, 27, 3, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7316), 3, 10, 2, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7317), 29, 10, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7318), 26, 21, 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7320), 9, 21, 3, 0, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7321), 3, 5, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7322), 35, 26, 1, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7323), 44, 7, 5, 0, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7324), 24, 16, 3, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7325), 22, 11, 2, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7327), 8, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7328), 4, 2, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7329), 2, 7, 1, 0, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7330), 24, 7, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7331), 24, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7332), 17, 20, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7333), 21, 13, 1, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7334), 32, 8, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7336), 29, 16, 4, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7337), 13, 17, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7338), 9, 17, 5, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7339), 32, 28, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7340), 2, 1, 1, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7341), 35, 28, 3, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7342), 34, 18, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7343), 23, 5, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7345), 37, 4, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7346), 4, 23, 1, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7347), 31, 5, 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7348), 2, 24, 1, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7349), 8, 10, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7354), 35, 19, 2, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7356), 43, 11, 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7357), 38, 2, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7358), 11, 10, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7359), 36, 9, 2, 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7361), 8, 16, 1, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7362), 17, 11, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7363), 11, 17, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7364), 40, 11, 1, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7365), 45, 20, 5, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7366), 39, 22, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7368), 23, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7369), 16, 3, 3, 0, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7370), 13, 27, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7371), 44, 2, 1, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7372), 36, 14, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7373), 39, 19, 1, 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7374), 28, 20, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7375), 42, 18, 1, 3, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7377), 37, 7, 5, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7378), 13, 15, 5, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7379), 6, 4, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7380), 22, 10, 5, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7381), 3, 9, 1, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7382), 15, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 763, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 763, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 763, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 763, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 5, 7, 17, 763, DateTimeKind.Local).AddTicks(112));
        }
    }
}
