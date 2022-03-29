using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class seedResorceData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Large collection of new and used Calligraphy Books. Obtain your favorite Calligraphy Books at much lower prices than other booksellers.", "Calligraphy" },
                    { 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shop our collection of new & used history books from local history, to world history, ancient history books, & more! Read more & spend less on ThriftBooks.", "History" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "1f38d339-5434-4cc1-9007-649a05b84753");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "dd0d0fd5-36b2-416f-b8d2-cb1fa2f9c346");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "4751da1b-7b01-4cc8-892c-f3585814397a");

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "Name", "Price", "Quantity" },
                values: new object[] { 1, 1, 999, new DateTime(2022, 3, 29, 17, 30, 51, 882, DateTimeKind.Local).AddTicks(8643), "In an age of myriad computer fonts and instant communication, your handwriting style is increasingly a very personal creation. In this book, Margaret Shepherd, America's premier calligrapher, shows you that calligraphy is not simply a craft you can learn, but an elegant art form that you can make your own. Calligraphy remains perennially popular, often adorning wedding invitations, diplomas, and commercial signs. Whether it is Roman, Gothic, Celtic,...", "Learn Calligraphy: The Complete Book of Lettering and Design", 50000, 100 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "Name", "Price", "Quantity" },
                values: new object[] { 2, 2, 999, new DateTime(2022, 3, 29, 17, 30, 51, 882, DateTimeKind.Local).AddTicks(8668), "New World cooking is hot, hot, hot -- and very cool. At San Francisco's famous Cha Cha Cha restaurant, located in the heart of Haight-Ashbury, the big flavors of Cuba and Puerto Rico come together and dance in vibrant dishes served against a backdrop of laughter, a loud Latin beat, and fabulous altars to the voodoo saint-gods of Santeria. As colorful as the restaurant itself, this unique, festive cookbook offers sixty terrific recipes for Cha Cha...", "Cook, Eat, Cha Cha Cha: Festive New World Recipes", 100000, 50 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 100,
                column: "ConcurrencyStamp",
                value: "58194358-b397-45c8-919c-70cdcb30a936");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 101,
                column: "ConcurrencyStamp",
                value: "be1b518d-dfe5-467c-8e61-25d59bb68516");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 102,
                column: "ConcurrencyStamp",
                value: "4e6c5069-be12-47aa-a063-b5bc3732754b");
        }
    }
}
