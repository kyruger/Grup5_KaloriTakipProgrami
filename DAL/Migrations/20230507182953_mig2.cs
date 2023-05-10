using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig2 : Migration
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
                    PhoneNumber = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                columns: new[] { "ID", "CalorieFor100Gram", "CarbonhydrateAmountFor100Gram", "Category", "CreationTime", "FatRateFor100Gram", "Name", "PortionGram", "ProteinRateFor100Gram" },
                values: new object[,]
                {
                    { 1, 300.1546m, 69m, 12, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(5481), 14m, "Hamburger", 190m, 17m },
                    { 2, 186m, 30.51m, 12, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(5490), 4.33m, "Pizza", 38m, 5.84m },
                    { 3, 170m, 29.71m, 9, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(5493), 3.5m, "Pizza", 190m, 4.12m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Age", "CreationTime", "FirstName", "Gender", "GoalWeight", "Height", "LastName", "Mail", "Password", "PhoneNumber", "Weight" },
                values: new object[,]
                {
                    { 1, 27, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(6578), "Enes", 1, 72m, 170m, "Kurt", "eneskurt@bilgeadam.com", "12345", "5434168", 66.5m },
                    { 2, 24, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(6585), "Baran", 1, 80m, 185m, "Oğuz", "baranoguz@bilgeadam.com", "12345", "11111", 73m }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4855), 1, 1, 3, 1 },
                    { 2, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4863), 1, 2, 3, 1 },
                    { 3, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4864), 1, 3, 2, 1 },
                    { 4, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4865), 2, 1, 2, 1 },
                    { 5, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4865), 2, 2, 2, 1 },
                    { 6, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4866), 2, 2, 3, 1 },
                    { 7, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4867), 3, 1, 1, 1 },
                    { 8, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4867), 3, 1, 1, 1 },
                    { 9, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4868), 5, 3, 3, 1 },
                    { 10, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4868), 1, 3, 2, 2 },
                    { 11, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4869), 2, 2, 2, 2 },
                    { 12, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4870), 1, 3, 1, 2 },
                    { 13, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4870), 1, 1, 3, 2 },
                    { 14, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4871), 4, 3, 2, 2 },
                    { 15, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4872), 4, 2, 2, 2 },
                    { 16, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4872), 4, 1, 1, 2 },
                    { 17, new DateTime(2023, 5, 7, 21, 29, 53, 581, DateTimeKind.Local).AddTicks(4873), 5, 1, 1, 2 }
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
