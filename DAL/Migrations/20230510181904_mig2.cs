using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 754, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationTime", "DayGoal" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 19, 3, 754, DateTimeKind.Local).AddTicks(921), 30 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationTime", "DayGoal" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 15, 54, 704, DateTimeKind.Local).AddTicks(6921), 0 });
        }
    }
}
