using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examNextJsBackEnd.Entities.Migrations
{
    public partial class addseedingrestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { "01GY6PXNZBB0JSS61Q2JDBBJJJ", new DateTimeOffset(new DateTime(2023, 4, 17, 4, 17, 44, 427, DateTimeKind.Unspecified).AddTicks(4142), new TimeSpan(0, 0, 0, 0, 0)), "KFC" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { "01GY6PXNZBCNQCQGZ7KQSG7F84", new DateTimeOffset(new DateTime(2023, 4, 17, 4, 17, 44, 427, DateTimeKind.Unspecified).AddTicks(4139), new TimeSpan(0, 0, 0, 0, 0)), "McDonalds" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBB0JSS61Q2JDBBJJJ");

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: "01GY6PXNZBCNQCQGZ7KQSG7F84");
        }
    }
}
