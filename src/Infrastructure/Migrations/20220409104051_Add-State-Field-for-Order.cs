using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AddStateFieldforOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Order",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 553, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OrderDate", "State" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(6249), 1 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OrderDate", "State" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(6283), 1 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OrderDate", "State" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(6315), 1 });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OrderDate", "State" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 40, 50, 554, DateTimeKind.Local).AddTicks(6348), 2 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "82c8f028-8434-4e1a-b6a6-58dc92be7bba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "db89b5e7-1515-4a7e-b419-8282e1ecd32d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "9850a3f3-9118-40fe-9b83-37479d1a8a22");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bde0acc-5ec9-4d63-9fbd-88499a0e53fb", "AQAAAAEAACcQAAAAEDv5D6/bPqpbTAlNs9ylN1Afl2K2HwvQ1bVNLY3xMKqlqEbMK/pAuW3x4iaJlmY4VQ==", "3b29a7e2-2614-413d-a2f3-23145b7969f8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7de5cf8-9df8-48c9-89e6-4fec91835cb5", "AQAAAAEAACcQAAAAEMY9GXP4mIltCC1+mUvVoGAI/q/QiRnTB7X07VkwZtq+KMKGApAlreFY0EE8KZAqdw==", "f1460a57-4d2a-4a6d-906b-0945eae97f32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c294077-533b-43f3-b23f-975821031c54", "AQAAAAEAACcQAAAAEIXJXvk88s6y57zepqouqv3QgIC6Sq3J9A3tIENq69QurMtzfFZDZ6qCqWZuaqWYSg==", "d0f77a98-bb84-4cf7-a242-12229386426d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c368191e-3ca2-4370-9dff-b09220f9d541", "AQAAAAEAACcQAAAAEDJnW3+WZaN2u/vt7PVkfCzZWk0cdxSHTIhIBG6mR8QarREI/xgL2N49BaUgeiTAYg==", "d9bb7527-6322-4c8c-8d24-ffc54d7df342" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9bd0307-00c6-47c5-88d3-f591aac55f70", "AQAAAAEAACcQAAAAECz/ZtiEHIrONQeN2KCoIVPkMETfixuW8ewblgqc5t6qu0IWRNNdQ/ad4UrimRPSbA==", "39f5864e-7336-47f1-a49e-2b1f265e14a3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aafefb1-470a-44c5-8f56-efffe3e8d6f7", "AQAAAAEAACcQAAAAELATUAn7lrulJ2hgJyAvfSeFs6ArLi28Sayr8S6WJNlIvg/yIpoZ6WWNq/+p5CDMbw==", "1d4a5f4d-1847-4763-b291-50d7ae2409c5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ba5d72c-14cd-44b5-9fdc-40fabb55262c", "AQAAAAEAACcQAAAAEE64+eejxLMgqWlyYB2VI41LCnjs+eYx8CyGaRIT5IJ9qzkOy49/4bfyExmg40/Ltw==", "5e6eb983-1b6e-49eb-8139-b28096e120e2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 443, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 443, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 443, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2022, 4, 9, 15, 40, 18, 444, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "c9d7e7f8-f33f-4bde-ae6d-1a8c75b504a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "bf418e59-c2aa-4a0d-85c1-5ed76af9c4bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "43630e27-7a09-4f92-830f-2dd6a50df606");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e4ea940-34a0-4913-b297-922b1116f882", "AQAAAAEAACcQAAAAEALAnqpqL5rpzrBZ5bKa8JLdIs6ff6iK1tmKgAyLb5FfxbTBC3yOwUSh5AW4etRdJw==", "e0c612ca-d07b-4505-915e-a46355f8b4c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3101e60f-22e1-407b-be1d-d360cb50c098", "AQAAAAEAACcQAAAAEFn4HZ+eikc8C5D7oBNBhv7U+EcBKIYQFt/PHMPG9kiHacJH2JOyPJI+HKyRaAOonw==", "31473c8a-5cbd-4ef7-b81a-33ae07f56672" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a243af6-952e-4bd9-9776-f6d7dd64f8be", "AQAAAAEAACcQAAAAEOO6qIyUgtSETn7Q7V04T0SPGIIo71yoBDBruaKZpbeOfw+HQWXOoqQyTr+Z7fjQ/g==", "e1768209-4e4a-46c3-b71a-f52a90a96f12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4db8cff2-64f3-4ca3-b8f7-0eb9f9cc561e", "AQAAAAEAACcQAAAAENxJBzQBGsdLxryWdrzUz4rQtSPkns3Bv0dxoEWvHQUA2zfcnMxCfcvKXpNaBFGZXA==", "1a204cc9-718b-46ed-8705-3237b3f32670" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a651e91-8d31-4ca7-8df3-ff30c5c74315", "AQAAAAEAACcQAAAAEOiZOpjYFn/savhpJcBk4QdZXEn8ejklLvjmtxqXOrEIQtYS6yNcXUkEdqDG5OpRNg==", "abe41084-f12c-4bf3-83f3-3f8114d7b5cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5b5e304-9036-40a0-9632-9a2f82e26b02", "AQAAAAEAACcQAAAAEOujwia19Q2AxSqF4diLhx/POzLzHHPB7cKTfm9UU6QoSRnddI8C+ovdaV0Nva4yRA==", "971e53e8-aab8-4d15-aa62-82aeb32e76a4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aa87a82-ef66-4af5-ad8a-932610dacc50", "AQAAAAEAACcQAAAAEK1Xj4GUptKX7iy9UGIVBuophSISQNPpOmuXgqe9jDTEMG1H2InIcGevN3jpqy66sg==", "7a3def90-8cb3-429c-81fc-146c7f7c6159" });
        }
    }
}
