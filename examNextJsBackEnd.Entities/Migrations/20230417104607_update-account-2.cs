using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examNextJsBackEnd.Entities.Migrations
{
    public partial class updateaccount2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQ5C6AEB7SKTXHJ7GF");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQ60DB2YM44N882XCR");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQ6E7FGEJBC5MMT80Z");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQAG6GEPM69PDW88Y8");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQCV2XVZ5KMHYYJKA9");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQJGT2QTMGZEAMS3R8");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQJXE1RN39KNQ2ZVHB");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQK149N6AHX9CXRR59");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQM3Z7EX14B4WZDDEG");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQP6XG0SK3N8WJ0BMQ");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQT3009995NGZCQAMF");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7CZ9TQVCPKQMDV58JXDTSF");

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T7627YEPXVRWFAS1XZ4", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant A", 50000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T763YBD6QCN45SBJT04", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant C", 58000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T76H16WSJXH0XRV9Z3K", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant B", 15000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T76H4MQYG54FAD3PCH6", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7735), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant C", 35000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T76MCF89G4AJ04DWFZT", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7695), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant B", 28000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T76N0G94FX24BFG44VQ", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7744), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant C", 27000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T76N8HN2J408GXJGM97", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7687), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant A", 25000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T76R0YTWPQQ8C34YMX7", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7741), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant C", 17000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T76RNVRYJ11BS2QK89M", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7697), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant B", 45000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T76VA3YZ5H590JP5WBX", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7701), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant B", 25000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T76VVHNHPNWBQQKJP6C", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7692), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant A", 10000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7D4T76W4SC1QEJN1625KJE", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant A", 5000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBB0JSS61Q2JDBBJJJ",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7549), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBCNQCQGZ7KQSG7F84",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7573), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6Q8FKXS2QB405HFMV8MVT2",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 17, 46, 6, 822, DateTimeKind.Unspecified).AddTicks(7575), new TimeSpan(0, 7, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T7627YEPXVRWFAS1XZ4");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T763YBD6QCN45SBJT04");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T76H16WSJXH0XRV9Z3K");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T76H4MQYG54FAD3PCH6");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T76MCF89G4AJ04DWFZT");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T76N0G94FX24BFG44VQ");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T76N8HN2J408GXJGM97");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T76R0YTWPQQ8C34YMX7");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T76RNVRYJ11BS2QK89M");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T76VA3YZ5H590JP5WBX");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T76VVHNHPNWBQQKJP6C");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7D4T76W4SC1QEJN1625KJE");

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQ5C6AEB7SKTXHJ7GF", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8295), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant A", 10000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQ60DB2YM44N882XCR", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8304), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant B", 45000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQ6E7FGEJBC5MMT80Z", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8317), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant C", 17000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQAG6GEPM69PDW88Y8", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8292), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant A", 5000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQCV2XVZ5KMHYYJKA9", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8283), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant A", 50000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQJGT2QTMGZEAMS3R8", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8287), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant A", 25000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQJXE1RN39KNQ2ZVHB", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8312), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant C", 58000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQK149N6AHX9CXRR59", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8297), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant B", 28000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQM3Z7EX14B4WZDDEG", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8307), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant B", 15000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQP6XG0SK3N8WJ0BMQ", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8315), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant C", 35000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQT3009995NGZCQAMF", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8310), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant B", 25000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7CZ9TQVCPKQMDV58JXDTSF", new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8319), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant C", 27000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBB0JSS61Q2JDBBJJJ",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8139), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBCNQCQGZ7KQSG7F84",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8162), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6Q8FKXS2QB405HFMV8MVT2",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 17, 43, 6, 199, DateTimeKind.Unspecified).AddTicks(8164), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
