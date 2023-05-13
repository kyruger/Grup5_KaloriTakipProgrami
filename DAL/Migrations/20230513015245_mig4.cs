using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 18, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6609), 35, 1, 3, null, 1 },
                    { 22, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6613), 5, 3, 1, null, 2 },
                    { 72, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6666), 27, 2, 2, null, 2 },
                    { 78, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6672), 21, 1, 2, null, 1 },
                    { 94, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6686), 3, 2, 0, null, 2 },
                    { 138, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6730), 25, 2, 2, null, 1 },
                    { 141, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6733), 21, 1, 2, null, 2 },
                    { 154, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6745), 24, 3, 5, null, 1 },
                    { 193, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6779), 26, 3, 1, null, 2 },
                    { 199, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6785), 5, 3, 1, null, 1 },
                    { 246, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6830), 4, 3, 1, null, 2 },
                    { 259, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6847), 36, 3, 1, null, 1 },
                    { 276, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6862), 17, 3, 5, null, 1 },
                    { 314, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6897), 9, 1, 2, null, 1 },
                    { 387, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6965), 45, 2, 0, null, 1 },
                    { 409, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6986), 30, 3, 0, null, 2 },
                    { 416, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6993), 24, 2, 4, null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CalorieFor100Gram", "CarbonhydrateAmountFor100Gram", "CreationTime", "FatRateFor100Gram", "ProteinRateFor100Gram" },
                values: new object[] { 164m, 20m, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8123), 6m, 7m });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CalorieFor100Gram", "CarbonhydrateAmountFor100Gram", "CreationTime", "FatRateFor100Gram", "PortionGram", "ProteinRateFor100Gram" },
                values: new object[] { 185m, 31m, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8130), 4m, 185m, 6m });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CalorieFor100Gram", "CarbonhydrateAmountFor100Gram", "CreationTime", "FatRateFor100Gram", "ProteinRateFor100Gram" },
                values: new object[] { 169m, 30m, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8132), 4m, 4m });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "ID", "CalorieFor100Gram", "CarbonhydrateAmountFor100Gram", "Category", "CreationTime", "FatRateFor100Gram", "ImageResource", "Name", "PortionGram", "ProteinRateFor100Gram" },
                values: new object[,]
                {
                    { 4, 31m, 4m, 8, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8133), 1m, null, "Seasonal Salad ", 190m, 1m },
                    { 5, 61m, 11m, 6, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8135), 0m, null, "Cola", 250m, 0m },
                    { 6, 50m, 5m, 6, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8136), 3m, null, "Ayran", 250m, 2m },
                    { 7, 357m, 84m, 10, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8137), 0.4m, null, "Cornflakes", 30m, 8m },
                    { 8, 403m, 69m, 10, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8142), 9m, null, "Chocolate Nesquik Flakes", 40m, 8m },
                    { 9, 310m, 3m, 7, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8143), 24m, null, "White Cheese", 50m, 20m },
                    { 10, 61m, 5m, 7, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8145), 3m, null, "Yogurt", 160m, 3m },
                    { 11, 119m, 20m, 3, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8146), 3m, null, "Puding", 150m, 3m },
                    { 12, 411m, 49m, 3, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8148), 22m, null, "Baklava", 160m, 7m },
                    { 13, 52m, 14m, 1, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8150), 0.17m, null, "Apple", 120m, 0.26m },
                    { 14, 88m, 23m, 1, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8152), 0.3m, null, "Banana", 130m, 1m },
                    { 15, 360m, 61m, 13, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8154), 5m, null, "Chickpeas", 80m, 21m },
                    { 16, 268m, 38m, 13, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8155), 3m, null, "Roasted Chickpea", 45m, 20m },
                    { 17, 214m, 0m, 4, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8156), 13m, null, "Steak", 140m, 23m },
                    { 18, 204m, 7.04m, 4, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8158), 13.08m, null, "Meatball", 108m, 17.45m },
                    { 19, 121m, 0m, 11, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8160), 15m, null, "Trout", 200m, 19m },
                    { 20, 146m, 0m, 11, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8161), 5.93m, null, "Salmon", 57m, 21.62m },
                    { 21, 170m, 6.52m, 8, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8168), 14.17m, null, "Caesar Salad", 108m, 5.03m },
                    { 22, 186m, 26.61m, 5, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8171), 4.59m, null, "Lentil Soup ", 248m, 10.42m },
                    { 23, 129m, 8.98m, 5, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8173), 9.3m, null, "Mushroom Soup", 244m, 2.32m },
                    { 24, 15m, 3.63m, 2, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8175), 0.11m, null, "Cucumber", 60m, 0.67m },
                    { 25, 25m, 5.84m, 2, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8177), 0.15m, null, "Carrot", 150m, 0.57m }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "ID", "CalorieFor100Gram", "CarbonhydrateAmountFor100Gram", "Category", "CreationTime", "FatRateFor100Gram", "ImageResource", "Name", "PortionGram", "ProteinRateFor100Gram" },
                values: new object[,]
                {
                    { 26, 19m, 1.1m, 14, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8179), 1.32m, null, "Haydari", 30m, 0.8m },
                    { 27, 41m, 4.29m, 14, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8186), 1.98m, null, "Probis (Ulker)", 9m, 1.25m },
                    { 28, 256m, 83.96m, 9, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(8189), 3.17m, null, "Bread", 60m, 12.87m }
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Age", "CreationTime", "DailyGoalCalorie", "FirstName", "Gender", "GoalWeight", "Height", "LastName", "Mail", "Password", "PhoneNumber", "Weight" },
                values: new object[] { 3, 30, new DateTime(2023, 5, 13, 4, 52, 44, 844, DateTimeKind.Local).AddTicks(1129), 2500, "Nazli", 2, 45m, 165m, "Koc", "nazlikoc@bilgeadam.com", "12345", "22222", 47m });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Age", "CreationTime", "DailyGoalCalorie", "DayGoal", "FirstName", "Gender", "GoalWeight", "Height", "LastName", "Mail", "Password", "PhoneNumber", "Weight" },
                values: new object[] { 4, 35, new DateTime(2023, 5, 13, 4, 52, 44, 844, DateTimeKind.Local).AddTicks(1131), 3200, 60, "Erdinç", 1, 80m, 180m, "Dincer", "erdincdincer@bilgeadam.com", "12345", "3333333", 85m });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Age", "CreationTime", "DailyGoalCalorie", "FirstName", "Gender", "GoalWeight", "Height", "LastName", "Mail", "Password", "PhoneNumber", "Weight" },
                values: new object[] { 5, 45, new DateTime(2023, 5, 13, 4, 52, 44, 844, DateTimeKind.Local).AddTicks(1133), 2800, "Yılmaz", 1, 65m, 175m, "Uslu", "yilmazuslu@bilgeadam.com", "12345", "22222", 75m });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6590), 42, 15, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6591), 9, 1, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6592), 32, 26, 3, 4 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6593), 19, 23, 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6595), 33, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6597), 32, 15, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6597), 19, 18, 4 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6600), 15, 17, 3, 0, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6601), 42, 4, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6602), 34, 19, 0, null, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6603), 35, 14, 5, 0 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6605), 30, 10, 5 });

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
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6607), 24, 6, 0, 4 });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 19, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6610), 29, 2, 4, null, 5 },
                    { 20, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6611), 44, 16, 0, null, 3 },
                    { 21, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6612), 42, 22, 3, null, 5 },
                    { 23, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6614), 41, 26, 1, null, 1 },
                    { 24, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6615), 6, 19, 2, null, 2 },
                    { 25, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6616), 8, 2, 4, null, 5 },
                    { 26, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6617), 33, 27, 3, null, 2 },
                    { 27, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6618), 25, 16, 4, null, 5 },
                    { 28, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6619), 34, 15, 0, null, 2 },
                    { 29, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6620), 29, 25, 3, null, 2 },
                    { 30, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6621), 11, 8, 5, null, 2 },
                    { 31, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6622), 22, 26, 5, null, 1 },
                    { 32, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6623), 45, 24, 5, null, 3 },
                    { 33, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6624), 39, 1, 4, null, 4 },
                    { 34, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6625), 4, 18, 0, null, 3 },
                    { 35, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6626), 2, 8, 2, null, 4 },
                    { 36, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6627), 13, 22, 2, null, 5 },
                    { 37, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6632), 33, 12, 1, null, 2 },
                    { 38, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6634), 13, 27, 0, null, 1 },
                    { 39, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6634), 21, 25, 2, null, 3 },
                    { 40, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6636), 39, 26, 3, null, 5 },
                    { 41, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6637), 13, 25, 0, null, 1 },
                    { 42, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6637), 5, 8, 1, null, 2 },
                    { 43, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6638), 10, 11, 4, null, 5 },
                    { 44, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6639), 3, 20, 1, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 45, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6640), 25, 17, 5, null, 1 },
                    { 46, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6641), 26, 14, 4, null, 1 },
                    { 47, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6642), 24, 8, 2, null, 1 },
                    { 48, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6643), 35, 15, 3, null, 5 },
                    { 49, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6644), 1, 21, 3, null, 4 },
                    { 50, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6644), 7, 19, 2, null, 1 },
                    { 51, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6645), 30, 23, 3, null, 3 },
                    { 52, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6646), 12, 25, 1, null, 2 },
                    { 53, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6647), 44, 16, 2, null, 1 },
                    { 54, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6648), 21, 11, 1, null, 3 },
                    { 55, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6649), 13, 25, 2, null, 1 },
                    { 56, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6649), 34, 19, 3, null, 2 },
                    { 57, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6651), 25, 6, 4, null, 1 },
                    { 58, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6651), 25, 16, 1, null, 5 },
                    { 59, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6652), 7, 14, 1, null, 3 },
                    { 60, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6653), 29, 9, 2, null, 5 },
                    { 61, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6654), 13, 27, 0, null, 3 },
                    { 62, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6655), 30, 20, 3, null, 5 },
                    { 63, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6656), 17, 8, 4, null, 3 },
                    { 64, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6657), 43, 7, 0, null, 2 },
                    { 65, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6658), 12, 25, 3, null, 4 },
                    { 66, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6660), 8, 26, 1, null, 3 },
                    { 67, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6661), 3, 7, 3, null, 4 },
                    { 68, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6662), 16, 23, 1, null, 4 },
                    { 69, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6663), 9, 14, 0, null, 4 },
                    { 70, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6664), 7, 8, 3, null, 4 },
                    { 71, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6665), 44, 12, 0, null, 2 },
                    { 73, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6667), 34, 19, 4, null, 3 },
                    { 74, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6667), 15, 20, 2, null, 5 },
                    { 75, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6668), 5, 7, 3, null, 4 },
                    { 76, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6670), 20, 8, 1, null, 2 },
                    { 77, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6671), 35, 27, 0, null, 4 },
                    { 79, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6673), 38, 23, 5, null, 5 },
                    { 80, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6674), 8, 6, 2, null, 3 },
                    { 81, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6675), 24, 11, 4, null, 1 },
                    { 82, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6675), 29, 21, 0, null, 2 },
                    { 83, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6676), 14, 6, 4, null, 4 },
                    { 84, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6677), 37, 25, 1, null, 4 },
                    { 85, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6678), 8, 22, 5, null, 4 },
                    { 86, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6679), 6, 10, 5, null, 4 },
                    { 87, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6680), 10, 14, 3, null, 5 },
                    { 88, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6681), 17, 5, 0, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 89, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6682), 44, 15, 4, null, 5 },
                    { 90, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6682), 15, 12, 2, null, 4 },
                    { 91, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6683), 1, 19, 3, null, 2 },
                    { 92, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6684), 17, 1, 4, null, 3 },
                    { 93, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6685), 23, 17, 4, null, 4 },
                    { 95, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6687), 37, 21, 1, null, 2 },
                    { 96, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6688), 26, 16, 4, null, 1 },
                    { 97, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6689), 34, 1, 5, null, 4 },
                    { 98, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6690), 28, 18, 3, null, 2 },
                    { 99, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6690), 23, 23, 3, null, 3 },
                    { 100, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6691), 8, 15, 2, null, 2 },
                    { 101, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6692), 6, 11, 0, null, 2 },
                    { 102, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6693), 21, 4, 0, null, 2 },
                    { 103, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6694), 21, 20, 3, null, 2 },
                    { 104, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6695), 11, 1, 3, null, 5 },
                    { 105, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6696), 20, 27, 4, null, 4 },
                    { 106, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6696), 30, 14, 0, null, 3 },
                    { 107, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6697), 20, 3, 0, null, 4 },
                    { 108, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6698), 22, 4, 3, null, 2 },
                    { 109, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6699), 25, 5, 0, null, 5 },
                    { 110, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6700), 25, 12, 3, null, 1 },
                    { 111, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6701), 44, 13, 1, null, 2 },
                    { 112, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6702), 20, 6, 2, null, 1 },
                    { 113, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6702), 29, 28, 4, null, 2 },
                    { 114, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6703), 38, 16, 0, null, 4 },
                    { 115, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6704), 19, 5, 1, null, 3 },
                    { 116, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6705), 18, 11, 4, null, 5 },
                    { 117, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6706), 40, 5, 3, null, 4 },
                    { 118, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6707), 7, 15, 0, null, 3 },
                    { 119, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6708), 29, 28, 4, null, 5 },
                    { 120, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6709), 4, 26, 3, null, 5 },
                    { 121, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6710), 16, 26, 5, null, 3 },
                    { 122, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6711), 27, 9, 5, null, 5 },
                    { 123, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6711), 15, 5, 1, null, 3 },
                    { 124, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6712), 11, 3, 1, null, 4 },
                    { 125, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6713), 8, 1, 3, null, 4 },
                    { 126, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6717), 26, 6, 3, null, 2 },
                    { 127, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6719), 1, 15, 3, null, 2 },
                    { 128, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6720), 41, 14, 1, null, 1 },
                    { 129, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6721), 34, 8, 5, null, 4 },
                    { 130, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6723), 9, 4, 3, null, 1 },
                    { 131, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6724), 11, 14, 0, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 132, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6725), 42, 25, 3, null, 4 },
                    { 133, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6726), 26, 12, 0, null, 2 },
                    { 134, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6726), 20, 4, 3, null, 4 },
                    { 135, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6727), 35, 10, 4, null, 4 },
                    { 136, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6728), 16, 14, 5, null, 1 },
                    { 137, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6729), 20, 4, 2, null, 4 },
                    { 139, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6731), 32, 13, 5, null, 1 },
                    { 140, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6732), 29, 20, 4, null, 5 },
                    { 142, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6734), 20, 13, 4, null, 5 },
                    { 143, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6734), 9, 19, 2, null, 2 },
                    { 144, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6735), 11, 11, 4, null, 5 },
                    { 145, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6736), 10, 20, 0, null, 3 },
                    { 146, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6737), 23, 25, 1, null, 5 },
                    { 147, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6738), 29, 7, 4, null, 5 },
                    { 148, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6739), 11, 28, 1, null, 1 },
                    { 149, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6740), 5, 17, 1, null, 3 },
                    { 150, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6741), 16, 12, 2, null, 1 },
                    { 151, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6742), 4, 7, 2, null, 5 },
                    { 152, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6743), 17, 23, 4, null, 1 },
                    { 153, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6744), 20, 17, 0, null, 4 },
                    { 155, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6745), 41, 19, 1, null, 2 },
                    { 156, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6746), 32, 17, 5, null, 5 },
                    { 157, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6747), 12, 25, 3, null, 5 },
                    { 158, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6748), 22, 25, 1, null, 1 },
                    { 159, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6749), 6, 25, 4, null, 1 },
                    { 160, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6750), 14, 1, 5, null, 4 },
                    { 161, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6751), 5, 19, 0, null, 3 },
                    { 162, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6752), 10, 23, 5, null, 5 },
                    { 163, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6753), 32, 8, 0, null, 5 },
                    { 164, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6753), 5, 28, 2, null, 4 },
                    { 165, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6754), 16, 26, 5, null, 5 },
                    { 166, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6755), 32, 5, 4, null, 3 },
                    { 167, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6756), 42, 20, 0, null, 3 },
                    { 168, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6757), 36, 21, 4, null, 2 },
                    { 169, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6758), 38, 26, 5, null, 2 },
                    { 170, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6759), 32, 18, 1, null, 3 },
                    { 171, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6760), 28, 13, 3, null, 1 },
                    { 172, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6760), 38, 10, 3, null, 2 },
                    { 173, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6761), 29, 15, 4, null, 3 },
                    { 174, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6762), 38, 28, 0, null, 2 },
                    { 175, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6763), 33, 20, 5, null, 3 },
                    { 176, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6764), 9, 26, 0, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 177, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6764), 43, 28, 4, null, 5 },
                    { 178, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6765), 38, 12, 0, null, 5 },
                    { 179, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6766), 33, 13, 4, null, 2 },
                    { 180, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6767), 13, 25, 0, null, 5 },
                    { 181, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6768), 23, 2, 5, null, 3 },
                    { 182, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6769), 44, 27, 2, null, 1 },
                    { 183, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6770), 43, 14, 5, null, 5 },
                    { 184, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6771), 29, 2, 5, null, 4 },
                    { 185, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6772), 4, 4, 2, null, 3 },
                    { 186, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6772), 36, 6, 1, null, 5 },
                    { 187, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6774), 1, 17, 5, null, 3 },
                    { 188, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6775), 39, 12, 5, null, 3 },
                    { 189, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6776), 39, 12, 3, null, 2 },
                    { 190, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6777), 41, 5, 2, null, 5 },
                    { 191, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6778), 3, 10, 0, null, 1 },
                    { 192, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6779), 29, 15, 5, null, 1 },
                    { 194, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6780), 42, 20, 5, null, 5 },
                    { 195, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6781), 6, 28, 0, null, 1 },
                    { 196, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6782), 5, 10, 1, null, 3 },
                    { 197, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6783), 16, 15, 1, null, 2 },
                    { 198, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6784), 24, 24, 1, null, 1 },
                    { 200, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6786), 12, 12, 1, null, 3 },
                    { 201, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6787), 10, 8, 5, null, 4 },
                    { 202, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6791), 14, 20, 5, null, 2 },
                    { 203, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6792), 3, 17, 1, null, 4 },
                    { 204, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6793), 37, 6, 0, null, 3 },
                    { 205, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6794), 35, 8, 1, null, 3 },
                    { 206, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6795), 20, 4, 0, null, 2 },
                    { 207, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6796), 26, 13, 0, null, 4 },
                    { 208, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6797), 8, 4, 0, null, 3 },
                    { 209, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6798), 38, 3, 2, null, 3 },
                    { 210, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6799), 38, 10, 1, null, 1 },
                    { 211, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6800), 23, 15, 5, null, 4 },
                    { 212, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6800), 5, 9, 1, null, 1 },
                    { 213, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6801), 41, 5, 5, null, 1 },
                    { 214, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6802), 27, 23, 4, null, 4 },
                    { 215, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6803), 12, 19, 3, null, 5 },
                    { 216, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6804), 44, 24, 2, null, 2 },
                    { 217, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6804), 13, 24, 1, null, 1 },
                    { 218, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6805), 10, 26, 1, null, 1 },
                    { 219, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6806), 10, 27, 0, null, 3 },
                    { 220, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6807), 14, 17, 5, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 221, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6808), 30, 22, 5, null, 3 },
                    { 222, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6809), 2, 24, 5, null, 1 },
                    { 223, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6810), 19, 24, 1, null, 2 },
                    { 224, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6811), 41, 28, 3, null, 1 },
                    { 225, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6812), 45, 4, 1, null, 4 },
                    { 226, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6812), 33, 28, 3, null, 5 },
                    { 227, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6813), 2, 5, 3, null, 5 },
                    { 228, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6814), 29, 8, 4, null, 1 },
                    { 229, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6815), 18, 13, 4, null, 1 },
                    { 230, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6816), 39, 3, 0, null, 3 },
                    { 231, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6817), 31, 15, 0, null, 1 },
                    { 232, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6818), 42, 7, 5, null, 5 },
                    { 233, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6818), 18, 17, 4, null, 2 },
                    { 234, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6819), 7, 17, 2, null, 1 },
                    { 235, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6820), 38, 12, 5, null, 4 },
                    { 236, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6821), 12, 8, 0, null, 3 },
                    { 237, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6822), 33, 28, 3, null, 4 },
                    { 238, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6822), 20, 23, 5, null, 5 },
                    { 239, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6823), 36, 6, 4, null, 2 },
                    { 240, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6824), 36, 17, 3, null, 3 },
                    { 241, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6825), 23, 6, 4, null, 4 },
                    { 242, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6826), 3, 28, 2, null, 1 },
                    { 243, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6827), 35, 4, 3, null, 5 },
                    { 244, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6828), 34, 7, 3, null, 3 },
                    { 245, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6829), 45, 25, 0, null, 3 },
                    { 247, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6831), 19, 21, 4, null, 1 },
                    { 248, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6832), 38, 11, 0, null, 1 },
                    { 249, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6833), 40, 24, 3, null, 1 },
                    { 250, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6834), 42, 14, 3, null, 4 },
                    { 251, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6834), 19, 26, 1, null, 1 },
                    { 252, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6835), 31, 6, 2, null, 5 },
                    { 253, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6836), 40, 16, 2, null, 1 },
                    { 254, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6837), 1, 24, 4, null, 1 },
                    { 255, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6838), 27, 13, 0, null, 3 },
                    { 256, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6840), 43, 21, 4, null, 1 },
                    { 257, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6840), 6, 7, 5, null, 3 },
                    { 258, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6846), 20, 8, 0, null, 5 },
                    { 260, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6848), 40, 16, 4, null, 1 },
                    { 261, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6849), 21, 18, 0, null, 2 },
                    { 262, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6850), 20, 19, 3, null, 5 },
                    { 263, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6851), 44, 6, 2, null, 1 },
                    { 264, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6852), 12, 27, 3, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 265, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6852), 19, 1, 2, null, 5 },
                    { 266, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6853), 4, 19, 3, null, 2 },
                    { 267, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6854), 37, 24, 4, null, 5 },
                    { 268, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6855), 31, 21, 2, null, 3 },
                    { 269, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6856), 11, 18, 5, null, 5 },
                    { 270, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6857), 42, 9, 5, null, 4 },
                    { 271, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6858), 23, 21, 1, null, 2 },
                    { 272, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6859), 36, 27, 4, null, 3 },
                    { 273, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6860), 14, 3, 4, null, 5 },
                    { 274, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6861), 42, 3, 0, null, 5 },
                    { 275, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6861), 9, 26, 1, null, 3 },
                    { 277, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6863), 2, 18, 0, null, 4 },
                    { 278, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6864), 39, 16, 4, null, 5 },
                    { 279, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6865), 1, 5, 5, null, 2 },
                    { 280, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6866), 43, 18, 2, null, 4 },
                    { 281, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6867), 17, 21, 4, null, 1 },
                    { 282, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6867), 40, 8, 3, null, 1 },
                    { 283, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6868), 26, 20, 3, null, 4 },
                    { 284, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6869), 9, 5, 5, null, 2 },
                    { 285, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6870), 28, 20, 1, null, 2 },
                    { 286, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6871), 3, 11, 2, null, 4 },
                    { 287, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6872), 43, 14, 5, null, 2 },
                    { 288, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6872), 10, 10, 3, null, 4 },
                    { 289, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6873), 3, 20, 1, null, 4 },
                    { 290, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6874), 37, 26, 0, null, 1 },
                    { 291, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6875), 2, 1, 0, null, 4 },
                    { 292, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6876), 27, 24, 0, null, 3 },
                    { 293, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6877), 6, 28, 4, null, 3 },
                    { 294, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6878), 22, 19, 4, null, 4 },
                    { 295, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6879), 17, 9, 5, null, 3 },
                    { 296, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6880), 3, 26, 5, null, 3 },
                    { 297, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6881), 36, 16, 4, null, 5 },
                    { 298, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6882), 29, 12, 1, null, 1 },
                    { 299, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6883), 34, 18, 3, null, 2 },
                    { 300, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6884), 17, 14, 5, null, 3 },
                    { 301, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6885), 35, 10, 2, null, 3 },
                    { 302, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6885), 17, 27, 2, null, 4 },
                    { 303, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6887), 36, 12, 1, null, 3 },
                    { 304, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6887), 38, 18, 0, null, 5 },
                    { 305, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6888), 38, 14, 0, null, 3 },
                    { 306, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6889), 35, 16, 3, null, 5 },
                    { 307, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6890), 25, 25, 2, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 308, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6891), 35, 6, 3, null, 1 },
                    { 309, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6892), 16, 9, 0, null, 3 },
                    { 310, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6893), 20, 25, 2, null, 4 },
                    { 311, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6894), 30, 18, 2, null, 4 },
                    { 312, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6895), 45, 28, 2, null, 5 },
                    { 313, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6896), 21, 12, 4, null, 4 },
                    { 315, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6898), 40, 2, 3, null, 5 },
                    { 316, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6899), 26, 21, 3, null, 2 },
                    { 317, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6899), 7, 14, 0, null, 4 },
                    { 318, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6901), 30, 18, 3, null, 2 },
                    { 319, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6902), 21, 10, 2, null, 5 },
                    { 320, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6902), 32, 16, 0, null, 4 },
                    { 321, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6903), 14, 19, 3, null, 5 },
                    { 322, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6904), 5, 26, 5, null, 5 },
                    { 323, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6905), 39, 4, 2, null, 2 },
                    { 324, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6906), 1, 12, 1, null, 1 },
                    { 325, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6907), 26, 25, 5, null, 5 },
                    { 326, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6908), 33, 4, 3, null, 2 },
                    { 327, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6908), 13, 12, 0, null, 1 },
                    { 328, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6909), 43, 12, 3, null, 1 },
                    { 329, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6910), 22, 3, 1, null, 3 },
                    { 330, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6911), 32, 24, 2, null, 4 },
                    { 331, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6912), 2, 22, 3, null, 4 },
                    { 332, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6913), 17, 5, 2, null, 1 },
                    { 333, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6914), 27, 10, 1, null, 5 },
                    { 334, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6915), 6, 14, 1, null, 5 },
                    { 335, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6915), 20, 18, 5, null, 5 },
                    { 336, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6916), 39, 25, 2, null, 5 },
                    { 337, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6917), 20, 17, 5, null, 1 },
                    { 338, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6918), 14, 4, 1, null, 4 },
                    { 339, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6919), 44, 24, 2, null, 2 },
                    { 340, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6920), 11, 7, 2, null, 1 },
                    { 341, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6921), 24, 6, 4, null, 4 },
                    { 342, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6922), 6, 17, 1, null, 3 },
                    { 343, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6922), 25, 17, 3, null, 2 },
                    { 344, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6923), 26, 10, 0, null, 2 },
                    { 345, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6924), 38, 18, 2, null, 5 },
                    { 346, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6925), 25, 7, 1, null, 5 },
                    { 347, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6926), 21, 26, 5, null, 4 },
                    { 348, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6926), 42, 26, 4, null, 2 },
                    { 349, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6927), 2, 14, 1, null, 4 },
                    { 350, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6928), 22, 28, 1, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 351, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6929), 40, 10, 1, null, 4 },
                    { 352, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6930), 29, 23, 3, null, 5 },
                    { 353, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6931), 37, 24, 0, null, 1 },
                    { 354, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6932), 30, 21, 1, null, 5 },
                    { 355, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6936), 18, 11, 4, null, 4 },
                    { 356, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6937), 29, 8, 5, null, 2 },
                    { 357, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6938), 11, 8, 1, null, 2 },
                    { 358, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6939), 27, 17, 1, null, 5 },
                    { 359, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6940), 44, 8, 0, null, 3 },
                    { 360, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6941), 31, 20, 3, null, 1 },
                    { 361, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6942), 9, 17, 5, null, 2 },
                    { 362, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6943), 9, 9, 5, null, 1 },
                    { 363, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6944), 11, 1, 3, null, 3 },
                    { 364, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6945), 20, 4, 4, null, 4 },
                    { 365, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6946), 16, 14, 4, null, 4 },
                    { 366, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6947), 8, 3, 0, null, 3 },
                    { 367, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6947), 14, 10, 2, null, 1 },
                    { 368, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6948), 25, 21, 4, null, 3 },
                    { 369, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6949), 40, 28, 5, null, 1 },
                    { 370, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6950), 35, 14, 5, null, 5 },
                    { 371, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6951), 24, 10, 4, null, 3 },
                    { 372, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6952), 31, 4, 4, null, 3 },
                    { 373, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6953), 23, 13, 5, null, 1 },
                    { 374, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6954), 12, 19, 0, null, 5 },
                    { 375, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6955), 19, 22, 0, null, 2 },
                    { 376, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6956), 20, 2, 4, null, 3 },
                    { 377, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6957), 5, 20, 1, null, 5 },
                    { 378, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6958), 19, 21, 3, null, 5 },
                    { 379, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6958), 14, 1, 1, null, 4 },
                    { 380, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6959), 16, 7, 5, null, 4 },
                    { 381, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6960), 6, 28, 5, null, 2 },
                    { 382, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6961), 22, 24, 5, null, 3 },
                    { 383, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6962), 32, 25, 1, null, 1 },
                    { 384, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6963), 33, 12, 0, null, 4 },
                    { 385, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6964), 29, 5, 1, null, 4 },
                    { 386, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6964), 5, 17, 3, null, 5 },
                    { 388, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6966), 2, 10, 5, null, 5 },
                    { 389, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6967), 23, 22, 0, null, 2 },
                    { 390, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6968), 35, 5, 0, null, 5 },
                    { 391, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6969), 17, 19, 5, null, 3 },
                    { 392, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6970), 17, 24, 4, null, 2 },
                    { 393, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6971), 3, 9, 0, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 394, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6972), 8, 24, 1, null, 5 },
                    { 395, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6973), 30, 8, 1, null, 3 },
                    { 396, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6973), 14, 25, 0, null, 2 },
                    { 397, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6974), 3, 13, 2, null, 2 },
                    { 398, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6975), 34, 22, 2, null, 5 },
                    { 399, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6976), 35, 16, 3, null, 5 },
                    { 400, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6977), 24, 17, 5, null, 5 },
                    { 401, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6978), 36, 12, 0, null, 4 },
                    { 402, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6979), 21, 23, 2, null, 2 },
                    { 403, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6980), 21, 1, 0, null, 5 },
                    { 404, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6981), 2, 22, 0, null, 5 },
                    { 405, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6982), 30, 9, 2, null, 4 },
                    { 406, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6983), 34, 1, 4, null, 3 },
                    { 407, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6984), 23, 9, 5, null, 5 },
                    { 408, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6985), 25, 16, 0, null, 2 },
                    { 410, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6987), 2, 12, 1, null, 4 },
                    { 411, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6988), 14, 28, 2, null, 1 },
                    { 412, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6989), 37, 5, 3, null, 1 },
                    { 413, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6990), 14, 15, 4, null, 1 },
                    { 414, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6991), 7, 25, 2, null, 1 },
                    { 415, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6992), 37, 14, 4, null, 1 },
                    { 417, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6993), 28, 15, 1, null, 3 },
                    { 418, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6995), 35, 27, 5, null, 2 },
                    { 419, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6995), 18, 6, 4, null, 4 },
                    { 420, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6996), 26, 5, 3, null, 3 },
                    { 421, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6997), 29, 15, 5, null, 1 },
                    { 422, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6998), 39, 22, 3, null, 4 },
                    { 423, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6999), 32, 9, 3, null, 1 },
                    { 424, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(6999), 21, 1, 0, null, 3 },
                    { 425, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7000), 24, 8, 1, null, 4 },
                    { 426, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7001), 35, 4, 5, null, 3 },
                    { 427, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7002), 14, 13, 3, null, 5 },
                    { 428, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7003), 4, 3, 3, null, 3 },
                    { 429, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7004), 3, 25, 0, null, 5 },
                    { 430, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7005), 25, 13, 0, null, 3 },
                    { 431, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7006), 5, 9, 0, null, 2 },
                    { 432, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7006), 22, 22, 2, null, 4 },
                    { 433, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7007), 40, 20, 1, null, 2 },
                    { 434, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7008), 11, 22, 2, null, 3 },
                    { 435, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7009), 32, 10, 0, null, 1 },
                    { 436, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7010), 40, 15, 2, null, 3 },
                    { 437, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7011), 42, 20, 3, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 438, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7012), 13, 8, 4, null, 2 },
                    { 439, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7013), 17, 11, 0, null, 2 },
                    { 440, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7013), 38, 25, 2, null, 2 },
                    { 441, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7014), 23, 13, 5, null, 2 },
                    { 442, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7015), 40, 18, 5, null, 3 },
                    { 443, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7016), 17, 8, 3, null, 2 },
                    { 444, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7017), 21, 18, 5, null, 2 },
                    { 445, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7018), 32, 25, 5, null, 1 },
                    { 446, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7019), 18, 28, 0, null, 4 },
                    { 447, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7020), 41, 5, 0, null, 1 },
                    { 448, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7021), 9, 2, 2, null, 3 },
                    { 449, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7022), 15, 12, 1, null, 4 },
                    { 450, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7023), 28, 28, 4, null, 1 },
                    { 451, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7024), 21, 23, 2, null, 2 },
                    { 452, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7025), 37, 1, 1, null, 4 },
                    { 453, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7025), 26, 25, 4, null, 3 },
                    { 454, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7026), 29, 28, 0, null, 3 },
                    { 455, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7027), 9, 8, 5, null, 4 },
                    { 456, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7028), 22, 25, 0, null, 1 },
                    { 457, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7032), 19, 6, 3, null, 4 },
                    { 458, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7033), 43, 11, 1, null, 5 },
                    { 459, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7034), 45, 3, 2, null, 4 },
                    { 460, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7035), 10, 13, 4, null, 4 },
                    { 461, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7036), 14, 5, 1, null, 5 },
                    { 462, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7037), 35, 11, 0, null, 1 },
                    { 463, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7038), 22, 6, 0, null, 4 },
                    { 464, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7038), 42, 27, 1, null, 4 },
                    { 465, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7039), 34, 9, 2, null, 4 },
                    { 466, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7040), 34, 24, 0, null, 3 },
                    { 467, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7041), 37, 27, 3, null, 3 },
                    { 468, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7042), 15, 25, 2, null, 5 },
                    { 469, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7043), 7, 27, 5, null, 3 },
                    { 470, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7044), 14, 21, 3, null, 1 },
                    { 471, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7045), 6, 7, 0, null, 4 },
                    { 472, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7046), 41, 8, 1, null, 5 },
                    { 473, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7047), 11, 10, 0, null, 2 },
                    { 474, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7048), 8, 11, 4, null, 5 },
                    { 475, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7049), 28, 26, 0, null, 2 },
                    { 476, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7050), 6, 14, 0, null, 5 },
                    { 477, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7050), 32, 23, 2, null, 5 },
                    { 478, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7051), 4, 10, 5, null, 4 },
                    { 479, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7052), 25, 6, 3, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 480, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7053), 2, 13, 4, null, 2 },
                    { 481, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7054), 22, 13, 1, null, 3 },
                    { 482, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7055), 20, 25, 4, null, 4 },
                    { 483, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7056), 35, 23, 4, null, 1 },
                    { 484, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7056), 22, 6, 0, null, 4 },
                    { 485, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7057), 13, 19, 0, null, 2 },
                    { 486, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7058), 15, 16, 2, null, 2 },
                    { 487, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7059), 2, 15, 5, null, 1 },
                    { 488, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7060), 27, 4, 2, null, 3 },
                    { 489, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7061), 15, 5, 1, null, 2 },
                    { 490, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7062), 40, 10, 5, null, 4 },
                    { 491, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7063), 25, 11, 5, null, 5 },
                    { 492, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7064), 32, 7, 5, null, 5 },
                    { 493, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7065), 45, 21, 4, null, 1 },
                    { 494, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7066), 45, 25, 0, null, 5 },
                    { 495, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7067), 10, 26, 5, null, 3 },
                    { 496, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7068), 45, 19, 2, null, 1 },
                    { 497, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7069), 38, 4, 3, null, 2 },
                    { 498, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7070), 2, 3, 5, null, 3 },
                    { 499, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7071), 2, 16, 2, null, 3 },
                    { 500, new DateTime(2023, 5, 13, 4, 52, 44, 843, DateTimeKind.Local).AddTicks(7072), 23, 5, 5, null, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2920), 1, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2928), 1, 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationTime", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2929), 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2929), 2, 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2930), 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2931), 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationTime", "Day", "FoodId", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2931), 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2932), 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2933), 5, 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2933), 1, 3, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2934), 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationTime", "Day", "FoodId", "PortionCount", "PortionType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2935), 1, 3, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2937), 2, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2937), 4, 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2938), 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2939), 4, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2939), 5, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CalorieFor100Gram", "CarbonhydrateAmountFor100Gram", "CreationTime", "FatRateFor100Gram", "ProteinRateFor100Gram" },
                values: new object[] { 300.1546m, 69m, new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(3514), 14m, 17m });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CalorieFor100Gram", "CarbonhydrateAmountFor100Gram", "CreationTime", "FatRateFor100Gram", "PortionGram", "ProteinRateFor100Gram" },
                values: new object[] { 186m, 30.51m, new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(3523), 4.33m, 38m, 5.84m });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CalorieFor100Gram", "CarbonhydrateAmountFor100Gram", "CreationTime", "FatRateFor100Gram", "ProteinRateFor100Gram" },
                values: new object[] { 170m, 29.71m, new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(3526), 3.5m, 4.12m });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(5345));
        }
    }
}
