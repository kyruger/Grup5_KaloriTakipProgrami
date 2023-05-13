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
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7357), 1, 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "MealType" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7360), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(9930));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationTime", "Day", "MealType" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3910), 2, 2 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationTime", "MealType" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3912), 3 });

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(6077));
        }
    }
}
