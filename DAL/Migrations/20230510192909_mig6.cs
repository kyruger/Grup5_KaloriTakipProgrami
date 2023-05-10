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
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day" },
                values: new object[] { new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4925), 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationTime", "Day" },
                values: new object[] { new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4927), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 29, 9, 161, DateTimeKind.Local).AddTicks(6830));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day" },
                values: new object[] { new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6959), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationTime", "Day" },
                values: new object[] { new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6961), 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 28, 13, 376, DateTimeKind.Local).AddTicks(9092));
        }
    }
}
