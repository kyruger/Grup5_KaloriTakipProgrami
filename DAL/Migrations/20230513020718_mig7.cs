using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6765), 41, 16, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6780), 1, 10, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6782), 41, 25, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6783), 25, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6786), 30, 24, 5, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6788), 24, 21, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6790), 18, 21, 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6792), 36, 3, 5, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6795), 12, 26, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6797), 2, 17, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6798), 4, 8, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6799), 5, 20, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6802), 4, 20, 4, 5 });

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
                columns: new[] { "CreationTime", "Day", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6804), 30, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6806), 39, 14, 1, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6807), 30, 18, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6808), 27, 17, 1, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6811), 32, 21, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6812), 19, 8, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6813), 14, 6, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6814), 21, 7, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6815), 31, 19, 2, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6817), 25, 26, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6818), 1, 14, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6820), 29, 27, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6821), 2, 11, 4, 2, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6823), 15, 27, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6824), 13, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6825), 30, 28, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6826), 29, 22, 3, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6829), 16, 10, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6830), 32, 21, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6831), 22, 12, 2, 1 });

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
                columns: new[] { "CreationTime", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6833), 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6834), 5, 20, 3, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6841), 8, 8, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6842), 7, 21, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6849), 11, 11, 5, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6850), 1, 14, 2, 2, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6852), 6, 27, 3, 4, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6856), 15, 23, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6857), 3, 10, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6858), 4, 24, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6860), 16, 19, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6861), 20, 25, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6863), 15, 18, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6864), 24, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6864), 29, 9, 5, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreationTime", "Day", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6865), 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6866), 27, 21, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6867), 5, 5, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6868), 27, 18, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6869), 7, 13, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6870), 3, 1, 5, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6871), 41, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6872), 10, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6873), 26, 26, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6875), 18, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6876), 20, 13, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6877), 39, 14, 4, 0, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6879), 33, 18, 5, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6881), 21, 12, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6882), 32, 14, 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6883), 7, 2, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6886), 43, 14, 1, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6888), 11, 22, 0, 4 });

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
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6890), 35, 5, 0, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6892), 44, 7, 3, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6897), 35, 19, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6898), 19, 2, 4, 1 });

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
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6900), 6, 5, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6901), 20, 4, 2, 1, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6903), 7, 23, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6904), 4, 16, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6905), 45, 19, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6906), 21, 10, 4, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6909), 44, 21, 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6910), 38, 7, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6911), 1, 8, 4, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6912), 15, 17, 3, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6915), 43, 14, 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6916), 6, 22, 1, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6918), 44, 25, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6919), 41, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6920), 27, 22, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6921), 33, 5, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6922), 18, 21, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6923), 41, 12, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6928), 14, 22, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6929), 14, 9, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6930), 33, 8, 1, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6931), 12, 18, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6932), 41, 24, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6933), 14, 16, 4, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6936), 9, 20, 0, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6938), 14, 2, 1, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6939), 22, 8, 4, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6941), 39, 20, 1, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6943), 31, 17, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6944), 39, 16, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6945), 19, 19, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6946), 29, 5, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6947), 32, 6, 4, 4, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6950), 38, 6, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6951), 33, 13, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6952), 6, 13, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6953), 16, 1, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6954), 8, 7, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6955), 9, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6956), 27, 15, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6957), 14, 23, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6958), 40, 15, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6959), 42, 2, 5, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6960), 11, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6961), 5, 8, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6963), 35, 15, 4, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6964), 24, 14, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6965), 19, 15, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6966), 34, 26, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6967), 9, 5, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6968), 4, 27, 3, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6970), 31, 1, 1, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6972), 27, 22, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6973), 44, 15, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6974), 42, 18, 1, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6975), 15, 7, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6976), 18, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6977), 9, 23, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6977), 22, 15, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6979), 1, 6, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6980), 11, 13, 5, 2, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6982), 13, 7, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6984), 3, 8, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6985), 16, 22, 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6986), 14, 20, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6987), 7, 17, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6988), 13, 14, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6988), 35, 27, 1, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6990), 1, 17, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6991), 25, 21, 1, 2, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6993), 6, 11, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6994), 41, 26, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6995), 8, 2, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6996), 24, 3, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6998), 32, 18, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(6999), 15, 13, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7000), 11, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7001), 44, 9, 5, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7003), 28, 6, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7004), 19, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7005), 24, 8, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7006), 37, 17, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7007), 20, 22, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7008), 20, 12, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7009), 42, 25, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7011), 16, 25, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7012), 3, 1, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7013), 40, 24, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7013), 1, 16, 4, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7017), 24, 7, 5, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7018), 6, 21, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7019), 18, 20, 1, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7020), 8, 6, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7026), 7, 16, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7027), 5, 24, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7028), 29, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7028), 26, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7030), 22, 9, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7031), 42, 11, 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7032), 7, 2, 4, 1 });

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
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7034), 5, 1, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7036), 45, 12, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7037), 34, 14, 5, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7038), 38, 24, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7039), 31, 17, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7041), 35, 10, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7042), 45, 3, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7043), 44, 21, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7044), 33, 26, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7045), 43, 11, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7048), 8, 26, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "CreationTime", "Day", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7049), 5, 0, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7051), 45, 21, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7052), 10, 14, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7053), 29, 26, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7054), 8, 25, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7055), 2, 9, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7056), 12, 7, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7057), 31, 28, 4, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7059), 38, 27, 1, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7061), 31, 14, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7062), 45, 18, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7064), 25, 23, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7065), 7, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7066), 4, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7068), 35, 7, 4, 4, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7070), 13, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7072), 29, 7, 2, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7075), 6, 17, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7081), 34, 15, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7082), 28, 17, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7083), 12, 26, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7084), 14, 28, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7085), 39, 27, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7087), 13, 17, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7088), 23, 6, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "CreationTime", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7089), 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7090), 1, 9, 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7091), 6, 12, 3, 2, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7093), 33, 23, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7094), 2, 22, 3, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7096), 26, 26, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7096), 25, 19, 1, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7097), 45, 16, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7098), 9, 21, 2, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7099), 8, 6, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7100), 8, 7, 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7102), 16, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7103), 30, 3, 5, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7105), 15, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7106), 35, 6, 1, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7108), 11, 20, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7109), 20, 1, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7110), 23, 5, 5, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7111), 26, 17, 3, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7116), 40, 16, 5, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7117), 32, 19, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7118), 39, 27, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7120), 2, 25, 5, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7121), 40, 8, 2, 3, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7123), 20, 13, 5, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7124), 23, 24, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7125), 11, 9, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7127), 18, 25, 4, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7128), 17, 25, 5, 0, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7129), 22, 17, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7130), 8, 15, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7131), 11, 15 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7134), 40, 23, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7135), 14, 27, 3, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7136), 34, 12, 1, 4, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7141), 10, 18, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7142), 23, 5, 1, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7143), 22, 9, 2, 0, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7144), 4, 21, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7146), 36, 17, 4, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7147), 9, 17, 5, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7147), 19, 14, 3, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7149), 3, 21, 5, 2, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7151), 38, 12, 3, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7152), 5, 24, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7154), 23, 19, 1, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7154), 32, 3, 5, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7156), 18, 9, 3, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7157), 24, 6, 4, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7158), 29, 17, 5, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7159), 4, 1, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7160), 41, 14, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7162), 9, 23, 2, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7163), 6, 23, 5, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7164), 28, 18, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7167), 44, 13, 2, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7168), 2, 8, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7170), 45, 22, 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7171), 5, 27, 5, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7172), 24, 14, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7173), 42, 24, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7174), 11, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7175), 8, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "CreationTime", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7176), 8, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7177), 29, 8, 5, 0, 3, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7180), 12, 26, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7181), 37, 1, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7182), 24, 18, 3, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7186), 16, 3, 2, 2, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7188), 23, 26, 1, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7189), 20, 13, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7190), 10, 11, 3, 4, 3, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7194), 22, 10, 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7195), 8, 11, 4, 3, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7201), 42, 15, 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7202), 30, 27, 5, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7203), 35, 13, 1, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7204), 30, 18, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7205), 9, 23, 3, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7207), 22, 19, 5, 3, 1, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7209), 43, 12, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7210), 30, 27, 1, 0, 2, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7212), 8, 20, 1, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7214), 21, 17, 2, 3, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7216), 13, 26, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7217), 24, 2, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7218), 9, 7, 1, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7220), 17, 12, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7220), 38, 5, 4, 0, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7222), 27, 17, 2, 0, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7225), 41, 7, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7226), 31, 12, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7227), 32, 28, 3, 0, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7253), 40, 28, 4, 4, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7254), 30, 13, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7256), 27, 6, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7258), 41, 20, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7259), 30, 13, 4, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7261), 10, 21, 5, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7263), 37, 4, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7265), 39, 3, 4, 0, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7267), 14, 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7269), 5, 14, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7271), 35, 9, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7272), 3, 5, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7273), 17, 2, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7274), 42, 19, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7275), 27, 18, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7277), 34, 9, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7278), 33, 7, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7279), 8, 26, 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7280), 8, 19, 5, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7281), 11, 7, 1, 0, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7282), 43, 13, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7283), 26, 9, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7284), 1, 20, 4, 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7285), 28, 25, 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7287), 31, 20, 3, 2, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7288), 41, 3, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7289), 34, 23, 2, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7290), 19, 19, 4, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7291), 43, 8, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7292), 21, 15, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7293), 4, 18, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7295), 26, 1, 0, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7296), 12, 25, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7297), 23, 17, 4, 0, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7298), 10, 25, 2, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7299), 12, 27, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7300), 39, 15, 3, 2, 2, 2 });

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
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7302), 6, 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7304), 10, 5, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7305), 14, 12, 3, 0, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7306), 45, 18, 5, 0, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7307), 29, 3, 3, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7308), 20, 17, 4, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7309), 40, 25, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7310), 29, 22, 2, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7311), 21, 22, 3, 1, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7312), 21, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7314), 42, 6, 4, 1, 1, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7317), 29, 10, 3, 0, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7318), 26, 21, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7320), 9, 21, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7321), 12, 3, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7322), 26, 1, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "CreationTime", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7323), 7, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7324), 24, 16, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7325), 22, 11, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7327), 8, 2, 4, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7328), 4, 2, 1, 0, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7329), 2, 7, 1, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7330), 24, 7, 3, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7331), 26, 24 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7332), 17, 20, 1, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7333), 21, 13, 1, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7334), 32, 8, 4, 2, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7337), 13, 17, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7338), 9, 17, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7339), 32, 28, 3, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7340), 2, 1, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7341), 35, 3, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7342), 34, 18, 4, 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7343), 23, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7345), 37, 22, 4, 4, 3, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7347), 31, 5, 3, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7348), 2, 24, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7356), 43, 11, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7357), 38, 2, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7358), 11, 10, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7359), 36, 9, 2, 3, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7362), 17, 11, 3, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7363), 11, 17, 5, 2, 2, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7366), 39, 22, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7368), 23, 1, 1, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7369), 16, 3, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7370), 13, 27, 4, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7371), 44, 2, 1, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7372), 36, 14, 5, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7373), 39, 19, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7374), 28, 20, 5, 1, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7377), 37, 7, 5, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7378), 13, 15, 5, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7379), 6, 4, 1, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7380), 22, 10, 5, 1, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 7, 17, 762, DateTimeKind.Local).AddTicks(7382), 15, 2, 3, 4, 4 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2744), 32, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2745), 13, 8, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2746), 9, 15, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2748), 13, 8, 1, 1, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2752), 40, 3, 2, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2754), 42, 28, 1, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2756), 12, 23, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2757), 9, 7, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2758), 9, 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2759), 21, 16, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2761), 10, 24, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2761), 35, 26, 5, 1 });

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
                columns: new[] { "CreationTime", "Day", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2765), 12, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2766), 31, 20, 4, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2768), 22, 11, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2770), 8, 2, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2772), 1, 13, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2773), 26, 17, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2774), 38, 2, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2775), 8, 6, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2776), 40, 28, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2777), 22, 14, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2778), 39, 2, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2779), 29, 27, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2781), 7, 18, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2784), 1, 23, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2785), 24, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2786), 18, 26, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2787), 14, 7, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2788), 27, 4, 2, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2790), 4, 18, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2791), 34, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2792), 10, 28, 4, 2 });

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
                columns: new[] { "CreationTime", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2794), 12, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2795), 27, 6, 5, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2803), 20, 4, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2805), 6, 7, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2806), 16, 24, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2807), 19, 2, 0, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2809), 4, 11, 5, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2810), 32, 24, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2811), 42, 20, 2, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2813), 12, 26, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2814), 41, 13, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2815), 37, 26, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2816), 32, 19, 3, 0, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2819), 14, 17, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2820), 11, 20, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2821), 42, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2822), 10, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2824), 21, 1, 1, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreationTime", "Day", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2825), 41, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2826), 25, 5, 3, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2827), 17, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2828), 7, 5, 3, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2832), 7, 5, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2832), 37, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2833), 25, 24, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2834), 23, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2835), 43, 18, 5, 4, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2843), 42, 4, 3, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2844), 10, 17, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2845), 27, 21, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2846), 9, 4, 3, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2847), 13, 15, 2, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2849), 18, 23, 4, 5 });

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
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2850), 13, 1, 2, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2853), 11, 28, 5, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2853), 4, 12, 3, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2854), 25, 25, 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2855), 37, 1, 3, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2857), 24, 19, 1, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2858), 10, 25, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2858), 16, 9, 1, 3 });

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
                columns: new[] { "CreationTime", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2860), 16, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2861), 27, 12, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2862), 34, 10, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2863), 37, 14, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2864), 31, 23, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2865), 42, 11, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2866), 26, 22, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2867), 36, 15, 3, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2868), 37, 9, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2869), 3, 8, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2870), 4, 24, 1, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2872), 42, 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2873), 4, 16, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2874), 20, 26, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2875), 1, 21, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2876), 14, 20, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2877), 44, 10, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2878), 13, 8, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2879), 43, 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2880), 37, 6, 5, 3, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2882), 19, 1, 5, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2883), 34, 16, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2889), 34, 7, 1, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2891), 32, 10, 5, 2, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2893), 40, 21, 5, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2893), 30, 23, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2895), 28, 26, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2896), 33, 11, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2897), 37, 4, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2898), 27, 16, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2899), 1, 16, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2900), 27, 18, 5, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2903), 4, 8, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2904), 2, 12, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2906), 37, 13, 1, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2910), 19, 24, 1, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2911), 36, 16, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2913), 25, 2, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2914), 30, 16, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2915), 19, 26, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2916), 20, 22, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2917), 32, 26, 1, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2920), 9, 17, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2921), 23, 25, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2922), 3, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2923), 30, 4, 5, 4, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2925), 41, 12, 3, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2926), 25, 17, 1, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2927), 1, 28, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2928), 24, 11, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2929), 32, 4, 5, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2930), 2, 6, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2931), 12, 10, 1, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2933), 24, 8, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2933), 45, 24, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2935), 27, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2936), 23, 8, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2937), 12, 11, 3, 1, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2939), 26, 27, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2941), 27, 20, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2942), 20, 10, 2, 3, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2945), 19, 17, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2946), 33, 13, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2947), 17, 10, 2, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2949), 34, 26, 3, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2950), 29, 3, 4, 0, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2952), 17, 13, 2, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2954), 39, 14, 5, 4, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2956), 3, 6, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2957), 10, 12, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2958), 44, 17, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2959), 26, 5, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2960), 11, 26, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2961), 16, 17, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2962), 26, 21, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2963), 3, 28, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2963), 6, 7, 4, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2965), 19, 5, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2966), 10, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2967), 7, 22, 3, 4, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2970), 37, 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2971), 28, 5, 5, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2976), 34, 5, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2978), 25, 28, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2978), 29, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2979), 27, 14, 4, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2980), 31, 1, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2981), 32, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2982), 28, 6, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2983), 22, 12, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2984), 41, 12, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2985), 14, 28, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2987), 35, 19, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2988), 40, 23, 2, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2989), 27, 21, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2990), 30, 21, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "CreationTime", "Day", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2991), 8, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2992), 6, 12, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2993), 23, 5, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2994), 41, 11, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2995), 9, 10, 3, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2996), 7, 6, 4, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2998), 43, 16, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(2999), 43, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3000), 7, 1, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3002), 28, 23, 5, 0, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3003), 6, 25, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "CreationTime", "Day", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3003), 26, 2, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3006), 22, 2, 3, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3008), 11, 11, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3008), 45, 23, 4, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3011), 34, 25, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3012), 34, 14, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3013), 22, 2, 3, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3015), 20, 22, 1, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3018), 8, 24, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3019), 25, 28 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3020), 23, 20, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3021), 4, 23, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3022), 22, 20, 1, 0, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3023), 12, 28, 4, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3024), 16, 1, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3025), 14, 16, 5, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3030), 23, 18, 1, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3032), 11, 3, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3033), 20, 2, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3034), 42, 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3035), 9, 20, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3037), 7, 15, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3038), 23, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3039), 28, 6, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3040), 39, 7, 3, 1 });

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
                columns: new[] { "CreationTime", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3042), 9 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3044), 39, 26, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3045), 33, 6, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3046), 29, 18, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3047), 31, 18, 1, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3049), 36, 2, 5, 0, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3052), 4, 1, 1, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3053), 15, 9, 4, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3056), 20, 11, 5, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3057), 11, 13, 2, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3059), 20, 13, 5, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "CreationTime", "Day", "FoodId", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3060), 33, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3061), 1, 15, 2, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3062), 43, 2, 1, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3066), 41, 25, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3127), 40, 14, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3130), 13, 11, 2, 2, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3133), 27, 18, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3134), 41, 11, 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3136), 14, 21, 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3137), 16, 16, 5, 2, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3140), 18, 4, 4, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3142), 19, 26, 3, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3143), 33, 27, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3144), 38, 19, 2, 3, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3146), 28, 4, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3148), 29, 7, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3149), 17, 9 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3150), 14, 28, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3152), 21, 9, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3153), 41, 7, 2, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3154), 20, 26, 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3155), 33, 21, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3157), 29, 7, 5, 0, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3158), 29, 21, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3159), 22, 16, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3160), 27, 25, 4, 3, 2, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3162), 44, 4, 3, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3165), 39, 26, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3166), 43, 23, 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3167), 26, 13, 5, 3, 3, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3170), 30, 27, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3171), 4, 20, 5, 4, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3173), 15, 7, 2, 0, 2, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3176), 2, 15, 5, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3177), 14, 9, 4, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3178), 36, 3, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3179), 36, 24, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3180), 21, 9, 4, 0, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3181), 32, 16, 2, 0, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3183), 5, 9, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3184), 38, 15, 2, 3, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3187), 36, 28, 5, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3191), 9, 18, 5, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3193), 31, 25, 3, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3194), 6, 10, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3195), 36, 26, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3197), 9, 5, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3198), 45, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "CreationTime", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3199), 4, 4, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3201), 10, 28, 4, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3202), 16, 21, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3203), 43, 27, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3204), 38, 25, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3205), 25, 23, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3206), 29, 6, 0, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3207), 40, 16, 4, 1, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3211), 12, 28, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3213), 4, 9, 4, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3214), 13, 18, 3, 3, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3215), 6, 16, 4, 0, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3216), 36, 2, 4, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3217), 30, 12, 3, 0, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3219), 44, 27, 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3221), 34, 25, 2, 0, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3222), 19, 7, 4, 3, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3223), 11, 15, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3224), 25, 27, 2, 0, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3225), 36, 24, 1, 0, 3, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3228), 28, 17, 4, 1, 1, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3231), 7, 15, 5, 4, 5 });

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
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3235), 26, 1, 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3236), 38, 8, 4, 0, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3237), 29, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3238), 20, 13, 1, 4, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3239), 30, 15, 3, 0, 1, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3241), 2, 12, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3242), 43, 3, 5, 4, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3245), 1, 22, 3, 0, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3246), 36, 19, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3247), 37, 10, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3248), 44, 3, 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3249), 11, 6, 5, 0, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3250), 19, 18, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3252), 7, 9, 5, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3253), 43, 26, 3, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3254), 21, 17, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3255), 4, 9, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3256), 10, 15, 5, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3257), 25, 25, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3258), 27, 5, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3260), 29, 15, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3261), 35, 6, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3262), 10, 28, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3263), 11, 26, 2, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3264), 22, 3, 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3265), 1, 28, 3, 0, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3266), 44, 4, 4, 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3267), 33, 22, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3268), 19, 27, 5, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3271), 7, 7, 4, 1, 3 });

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
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3273), 31, 5, 0, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3274), 41, 26, 3, 0, 3, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3276), 29, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3277), 36, 19, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3278), 43, 14, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3279), 27, 4, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3280), 42, 3, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3287), 3, 2, 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3288), 31, 3, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3290), 29, 1, 5, 0, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3292), 3, 5, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3293), 24, 18, 4, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3296), 45, 6, 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3297), 41, 13, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3298), 44, 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3299), 17, 4, 4, 0, 2, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3301), 11, 24, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3307), 17, 25, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3308), 12, 18, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3309), 43, 11, 2, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "CreationTime", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3310), 6, 2, 0, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "CreationTime", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3312), 5, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3312), 10, 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3313), 29, 18, 4, 2, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3317), 36, 2, 3, 4, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3319), 27, 8 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3320), 26, 3, 5, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3321), 1, 9, 4, 3, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3322), 45, 21, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3324), 34, 12, 1, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3324), 16, 22, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3326), 42, 26, 1, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3328), 12, 18, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "CreationTime", "Day", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3330), 38, 1, 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3331), 1, 16, 1, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3332), 18, 6, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3335), 34, 27, 4, 2, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3336), 29, 28, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3337), 33, 24, 5, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3339), 15, 13, 5, 0, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3339), 40, 21, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3341), 6, 3, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3342), 19, 24, 0, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3343), 10, 24, 5, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3344), 24, 24, 3, 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3345), 13, 23, 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3346), 4, 4, 1, 3, 3, 1 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3350), 1, 9, 1, 0, 3 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3352), 19, 18, 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3353), 30, 16, 2, 0, 2, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3354), 27, 11, 5, 1, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3355), 18, 10, 1, 0, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3356), 43, 14, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3357), 6, 6, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3358), 18, 5, 2, 0, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3359), 12, 6, 2, 3, 2 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3362), 31, 16, 5, 0, 1, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3363), 19, 17, 1, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3364), 36, 13, 2, 0, 3, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 5, 4, 48, 868, DateTimeKind.Local).AddTicks(3365), 26, 13, 2, 1, 3 });

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
    }
}
