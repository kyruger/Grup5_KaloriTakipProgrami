using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class nmk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PortionGram = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    CalorieFor100Gram = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    ProteinRateFor100Gram = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    FatRateFor100Gram = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    CarbonhydrateAmountFor100Gram = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    ImageResource = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 120, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DailyGoalCalorie = table.Column<int>(type: "int", nullable: false),
                    GoalWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DailyGoal = table.Column<decimal>(type: "decimal(18,2)", maxLength: 90, nullable: false, defaultValue: 0m),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConsumedFoods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    PortionCount = table.Column<int>(type: "int", nullable: false),
                    PortionType = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumedFoods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ConsumedFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumedFoods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "ID", "CalorieFor100Gram", "CarbonhydrateAmountFor100Gram", "Category", "CreationTime", "FatRateFor100Gram", "ImageResource", "Name", "PortionGram", "ProteinRateFor100Gram" },
                values: new object[,]
                {
                    { 1, 300.1546m, 69m, 12, new DateTime(2023, 5, 10, 21, 55, 16, 297, DateTimeKind.Local).AddTicks(1006), 14m, null, "Hamburger", 190m, 17m },
                    { 2, 186m, 30.51m, 12, new DateTime(2023, 5, 10, 21, 55, 16, 297, DateTimeKind.Local).AddTicks(1037), 4.33m, null, "Pizza", 38m, 5.84m },
                    { 3, 170m, 29.71m, 9, new DateTime(2023, 5, 10, 21, 55, 16, 297, DateTimeKind.Local).AddTicks(1047), 3.5m, null, "Pizza", 190m, 4.12m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Age", "CreationTime", "DailyGoalCalorie", "FirstName", "Gender", "GoalWeight", "Height", "LastName", "Mail", "Password", "PhoneNumber", "Weight" },
                values: new object[,]
                {
                    { 1, 27, new DateTime(2023, 5, 10, 21, 55, 16, 297, DateTimeKind.Local).AddTicks(6830), 3000, "Enes", 1, 72m, 170m, "Kurt", "eneskurt@bilgeadam.com", "12345", "5434168", 66.5m },
                    { 2, 24, new DateTime(2023, 5, 10, 21, 55, 16, 297, DateTimeKind.Local).AddTicks(6851), 3500, "Baran", 1, 80m, 185m, "Oğuz", "baranoguz@bilgeadam.com", "12345", "11111", 73m }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "Quantity", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8342), 1, 1, 3, 0, null, 0, 1 },
                    { 2, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8369), 1, 2, 3, 0, null, 0, 1 },
                    { 3, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8371), 1, 3, 2, 0, null, 0, 1 },
                    { 4, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8372), 2, 1, 2, 0, null, 0, 1 },
                    { 5, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8373), 2, 2, 2, 0, null, 0, 1 },
                    { 6, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8374), 2, 2, 3, 0, null, 0, 1 },
                    { 7, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8375), 3, 1, 1, 0, null, 0, 1 },
                    { 8, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8377), 3, 1, 1, 0, null, 0, 1 },
                    { 9, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8378), 5, 3, 3, 0, null, 0, 1 },
                    { 10, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8379), 1, 3, 2, 0, null, 0, 2 },
                    { 11, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8381), 2, 2, 2, 0, null, 0, 2 },
                    { 12, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8382), 1, 3, 1, 0, null, 0, 2 },
                    { 13, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8383), 1, 1, 3, 0, null, 0, 2 },
                    { 14, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8385), 4, 3, 2, 0, null, 0, 2 },
                    { 15, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8386), 4, 2, 2, 0, null, 0, 2 },
                    { 16, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8387), 4, 1, 1, 0, null, 0, 2 },
                    { 17, new DateTime(2023, 5, 10, 21, 55, 16, 296, DateTimeKind.Local).AddTicks(8389), 5, 1, 1, 0, null, 0, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsumedFoods_FoodId",
                table: "ConsumedFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumedFoods_UserId",
                table: "ConsumedFoods",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumedFoods");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
