using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3963), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 23, 2, 150, DateTimeKind.Local).AddTicks(5914));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5444), 0 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(7646));
        }
    }
}
