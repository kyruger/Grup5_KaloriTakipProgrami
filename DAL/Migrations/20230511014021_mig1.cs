using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig1 : Migration
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
                    DayGoal = table.Column<int>(type: "int", maxLength: 90, nullable: false, defaultValue: 0),
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
                    PortionCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PortionType = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
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
                    { 1, 300.1546m, 69m, 12, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(4447), 14m, null, "Hamburger", 190m, 17m },
                    { 2, 186m, 30.51m, 12, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(4456), 4.33m, null, "Pizza", 38m, 5.84m },
                    { 3, 170m, 29.71m, 9, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(4461), 3.5m, null, "Mantı", 190m, 4.12m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Age", "CreationTime", "DailyGoalCalorie", "FirstName", "Gender", "GoalWeight", "Height", "LastName", "Mail", "Password", "PhoneNumber", "Weight" },
                values: new object[] { 1, 27, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(6069), 3000, "Enes", 1, 72m, 170m, "Kurt", "eneskurt@bilgeadam.com", "12345", "5434168", 66.5m });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Age", "CreationTime", "DailyGoalCalorie", "DayGoal", "FirstName", "Gender", "GoalWeight", "Height", "LastName", "Mail", "Password", "PhoneNumber", "Weight" },
                values: new object[] { 2, 24, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(6077), 3500, 30, "Baran", 1, 80m, 185m, "Oğuz", "baranoguz@bilgeadam.com", "12345", "11111", 73m });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3895), 1, 1, 3, null, 1 },
                    { 2, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3904), 1, 2, 3, null, 1 },
                    { 3, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3905), 1, 3, 2, null, 1 },
                    { 4, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3906), 2, 1, 2, null, 1 },
                    { 5, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3906), 2, 2, 2, null, 1 },
                    { 6, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3907), 2, 2, 3, null, 1 },
                    { 7, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3908), 3, 1, 1, null, 1 },
                    { 8, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3908), 3, 1, 1, null, 1 },
                    { 9, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3909), 5, 3, 3, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "Quantity", "UserId" },
                values: new object[] { 10, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3910), 2, 3, 2, null, 2, 2 });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[] { 11, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3911), 2, 2, 2, null, 2 });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionCount", "PortionType", "UserId" },
                values: new object[] { 12, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3911), 1, 3, 1, 1, 2, 2 });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "Quantity", "UserId" },
                values: new object[] { 13, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3912), 2, 1, 3, null, 1, 2 });

            migrationBuilder.InsertData(
                table: "ConsumedFoods",
                columns: new[] { "ID", "CreationTime", "Day", "FoodId", "MealType", "PortionType", "UserId" },
                values: new object[,]
                {
                    { 14, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3913), 4, 3, 2, null, 2 },
                    { 15, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3914), 4, 2, 2, null, 2 },
                    { 16, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3914), 4, 1, 1, null, 2 },
                    { 17, new DateTime(2023, 5, 11, 4, 40, 21, 690, DateTimeKind.Local).AddTicks(3915), 5, 1, 1, null, 2 }
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
