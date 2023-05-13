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
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "ConsumedFoods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 19, 6, 577, DateTimeKind.Local).AddTicks(3526));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7357));

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
                column: "CreationTime",
                value: new DateTime(2023, 5, 13, 0, 13, 43, 351, DateTimeKind.Local).AddTicks(7360));

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
    }
}
