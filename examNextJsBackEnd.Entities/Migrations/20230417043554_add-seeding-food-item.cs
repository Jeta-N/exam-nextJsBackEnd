using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examNextJsBackEnd.Entities.Migrations
{
    public partial class addseedingfooditem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY1506VHNV9TCSQEKHE5", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant A", 25000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY1544S304RMXQPC0SWW", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2595), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant B", 15000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY155B346PJ4843SY6NP", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant A", 5000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15ARMDF1KX6YQ65QF6", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2592), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant B", 45000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15FV7WC3R1GGG0PK1Z", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant A", 10000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15P2QGQFKRSN0JB5RV", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant B", 28000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15WGSR9JCXW5ZJY17J", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant A", 50000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15YM2GMT9JTYZ21JA7", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2598), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant B", 25000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBB0JSS61Q2JDBBJJJ",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2405), new TimeSpan(0, 7, 0, 0, 0)), "McDonalds" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBCNQCQGZ7KQSG7F84",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2429), new TimeSpan(0, 7, 0, 0, 0)), "KFC" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { "01GY6Q8FKXS2QB405HFMV8MVT2", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2430), new TimeSpan(0, 7, 0, 0, 0)), "A&W" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY156WPYRB5P260PCK22", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2607), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant C", 17000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15FKQN8YHCX25XCWH7", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2601), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant C", 58000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15R45782HPJ8BV9R22", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant C", 27000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15ZHCEYHWSZMTCGGXN", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant C", 35000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY1506VHNV9TCSQEKHE5");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY1544S304RMXQPC0SWW");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY155B346PJ4843SY6NP");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY156WPYRB5P260PCK22");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY15ARMDF1KX6YQ65QF6");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY15FKQN8YHCX25XCWH7");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY15FV7WC3R1GGG0PK1Z");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY15P2QGQFKRSN0JB5RV");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY15R45782HPJ8BV9R22");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY15WGSR9JCXW5ZJY17J");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY15YM2GMT9JTYZ21JA7");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY6QYY15ZHCEYHWSZMTCGGXN");

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6Q8FKXS2QB405HFMV8MVT2");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBB0JSS61Q2JDBBJJJ",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 4, 17, 44, 427, DateTimeKind.Unspecified).AddTicks(4142), new TimeSpan(0, 0, 0, 0, 0)), "KFC" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBCNQCQGZ7KQSG7F84",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 4, 17, 44, 427, DateTimeKind.Unspecified).AddTicks(4139), new TimeSpan(0, 0, 0, 0, 0)), "McDonalds" });
        }
    }
}
