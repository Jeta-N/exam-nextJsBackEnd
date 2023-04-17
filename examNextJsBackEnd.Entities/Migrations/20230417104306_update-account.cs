using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examNextJsBackEnd.Entities.Migrations
{
    public partial class updateaccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FF3ZDVAYZK5YV4SXHN");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FF4NA8C4EMET3F1HAX");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FF5RDYGCKQYDKXT3SN");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FF6W9Q6AYTPXJM46PS");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FF7BTGW972YVSVV2AW");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FF9B8B1B38831Z8ZAZ");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FFBZHQJPJ0SP5DT12Z");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FFMEJSJGFWFVB11EWF");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FFSBNMVXKJ4952RM8T");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FFSCRJ3FD3PWQN3G7E");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FFXSKTDGVPEQYCD9ZA");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: "01GY7424FFXYY0MKFSD55AAWRE");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "01GY7424FF3ZDVAYZK5YV4SXHN", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(765), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant C", 27000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7424FF4NA8C4EMET3F1HAX", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(743), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant B", 28000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7424FF5RDYGCKQYDKXT3SN", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant B", 25000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7424FF6W9Q6AYTPXJM46PS", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(759), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant C", 35000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7424FF7BTGW972YVSVV2AW", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(762), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant C", 17000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7424FF9B8B1B38831Z8ZAZ", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant A", 5000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7424FFBZHQJPJ0SP5DT12Z", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(733), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant A", 25000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7424FFMEJSJGFWFVB11EWF", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(730), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant A", 50000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7424FFSBNMVXKJ4952RM8T", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(740), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant A", 10000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7424FFSCRJ3FD3PWQN3G7E", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(756), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant C", 58000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7424FFXSKTDGVPEQYCD9ZA", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(750), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant B", 15000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY7424FFXYY0MKFSD55AAWRE", new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant B", 45000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBB0JSS61Q2JDBBJJJ",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(548), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBCNQCQGZ7KQSG7F84",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(574), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6Q8FKXS2QB405HFMV8MVT2",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 15, 7, 21, 839, DateTimeKind.Unspecified).AddTicks(575), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
