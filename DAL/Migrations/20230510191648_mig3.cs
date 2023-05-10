using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreationTime", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5442), 2 });

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
                columns: new[] { "CreationTime", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5443), 1, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(5444));

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
                columns: new[] { "CreationTime", "Name" },
                values: new object[] { new DateTime(2023, 5, 10, 22, 16, 48, 381, DateTimeKind.Local).AddTicks(6220), "Mantı" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreationTime", "Quantity" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9064), 0 });

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
                columns: new[] { "CreationTime", "PortionCount", "PortionType" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9066), 0, null });

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
                columns: new[] { "CreationTime", "Name" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 19, 3, 753, DateTimeKind.Local).AddTicks(9612), "Pizza" });

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
                column: "CreationTime",
                value: new DateTime(2023, 5, 10, 21, 19, 3, 754, DateTimeKind.Local).AddTicks(921));
        }
    }
}
