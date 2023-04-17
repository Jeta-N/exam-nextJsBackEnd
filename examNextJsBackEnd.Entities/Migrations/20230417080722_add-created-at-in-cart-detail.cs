using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examNextJsBackEnd.Entities.Migrations
{
    public partial class addcreatedatincartdetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "CartDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CartDetails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CartDetails");

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
                values: new object[] { "01GY6QYY156WPYRB5P260PCK22", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2607), new TimeSpan(0, 7, 0, 0, 0)), "Drink A Restaurant C", 17000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15ARMDF1KX6YQ65QF6", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2592), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant B", 45000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15FKQN8YHCX25XCWH7", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2601), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant C", 58000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

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
                values: new object[] { "01GY6QYY15R45782HPJ8BV9R22", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant C", 27000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15WGSR9JCXW5ZJY17J", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 7, 0, 0, 0)), "Food A Restaurant A", 50000m, "01GY6PXNZBB0JSS61Q2JDBBJJJ" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15YM2GMT9JTYZ21JA7", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2598), new TimeSpan(0, 7, 0, 0, 0)), "Drink B Restaurant B", 25000m, "01GY6PXNZBCNQCQGZ7KQSG7F84" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CreatedAt", "Name", "Price", "RestaurantId" },
                values: new object[] { "01GY6QYY15ZHCEYHWSZMTCGGXN", new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 7, 0, 0, 0)), "Food B Restaurant C", 35000m, "01GY6Q8FKXS2QB405HFMV8MVT2" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBB0JSS61Q2JDBBJJJ",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2405), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBCNQCQGZ7KQSG7F84",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2429), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6Q8FKXS2QB405HFMV8MVT2",
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 11, 35, 54, 21, DateTimeKind.Unspecified).AddTicks(2430), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
