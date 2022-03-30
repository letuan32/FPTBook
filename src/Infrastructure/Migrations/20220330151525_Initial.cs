using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: false),
                    State = table.Column<byte>(type: "tinyint", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Category",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Book",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItem_Order",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "signal_processing" },
                    { 2, 999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "data_science" },
                    { 3, 999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "mathematics" },
                    { 4, 999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "economics" },
                    { 5, 999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "history" },
                    { 6, 999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "science" },
                    { 7, 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "psychology" },
                    { 8, 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "fiction" },
                    { 9, 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "computer_science" },
                    { 10, 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "nonfiction" },
                    { 11, 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "philosophy" },
                    { 12, 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "comic" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 100, "db719744-73b3-4286-b04b-de0de1007388", "Admin", "ADMIN" },
                    { 101, "ecd71ca6-77ae-4124-a719-3c459b0a1da4", "StoreOwner", "STOREOWNER" },
                    { 102, "c48105ec-0223-4e5c-8670-4b2e7b18c5d2", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 100, 0, "Le Duan, Da Nang", "a10aa020-eed9-44dc-84c4-0db5f705c252", "customer@gmail.com", false, false, null, null, "CUSTOMER@GMAIL.COM", "AQAAAAEAACcQAAAAEK6U5WpH/1lF7b+S3wlfQ3BDZR3JYy2SbRx3vGv3SXMMpkOmGFMZKUiJPm9kB7WXrg==", null, false, null, false, "customer@gmail.com" },
                    { 201, 0, "Le Duan, Da Nang", "142935aa-ec32-45d7-9c04-b716da0a5b16", "storeowner201@gmail.com", false, false, null, null, "STOREOWNER201@GMAIL.COM", "AQAAAAEAACcQAAAAEC79D7erpSUwUw4YhCbl/iSOShJFEcd6LzRvAfxZIcR9ojp0orz3CBl7JaHUeVI66A==", null, false, null, false, "storeowner201@gmail.com" },
                    { 202, 0, "Le Duan, Da Nang", "f83b4d45-70ab-46aa-b038-ea94b33ffaef", "storeowner202@gmail.com", false, false, null, null, "STOREOWNER202@GMAIL.COM", "AQAAAAEAACcQAAAAEHcpTb1LfZb27Jk8dv3cEpe6t/OVETzJzj7BFeXbj4t7VZWOkhFAy4xRrSqr7HaT6g==", null, false, null, false, "storeowner202@gmail.com" },
                    { 999, 0, "Le Duan, Da Nang", "318945e6-0412-494d-acc2-3d92905ef31c", "admin@gmail.com", false, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEE75cKKFN3GKT7ZUsxiIwA9Jx36EXrBKvd74U8Gjt/lFPcK05wbKtje7//rlxbmHKg==", null, false, null, false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 2, 201, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(8947), "WINNING MEANS FAME AND FORTUNE.LOSING MEANS CERTAIN DEATH.THE HUNGER GAMES HAVE BEGUN. . . .In the ruins of a place once known as North America lies the nation of Panem, a shining Capitol surrounded by twelve outlying districts. The Capitol is harsh and cruel and keeps the districts in line by forcing them all to send one boy and once girl between the ages of twelve and eighteen to participate in the annual Hunger Games, a fight to the death on live TV.Sixteen-year-old Katniss Everdeen regards it as a death sentence when she steps forward to take her sister's place in the Games. But Katniss ha", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1586722975l/2767052.jpg", "The Hunger Games", 51000, 128 },
                    { 2, 10, 202, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9095), "There is a door at the end of a silent corridor. And it�s haunting Harry Pottter�s dreams. Why else would he be waking in the middle of the night, screaming in terror?Harry has a lot on his mind for this, his fifth year at Hogwarts: a Defense Against the Dark Arts teacher with a personality like poisoned honey; a big surprise on the Gryffindor Quidditch team; and the looming terror of the Ordinary Wizarding Level exams. But all these things pale next to the growing threat of He-Who-Must-Not-Be-Named - a threat that neither the magical government nor the authorities at Hogwarts can stop.As the", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1546910265l/2.jpg", "Harry Potter and the Order of the Phoenix", 261000, 50 },
                    { 3, 6, 203, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9208), "The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1553383690l/2657.jpg", "To Kill a Mockingbird", 289000, 53 },
                    { 4, 11, 202, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9309), "Alternate cover edition of ISBN 9780679783268Since its immediate success in 1813, Pride and Prejudice has remained one of the most popular novels in the English language. Jane Austen called this brilliant work \"her own darling child\" and its vivacious heroine, Elizabeth Bennet, \"as delightful a creature as ever appeared in print.\" The romantic clash between the opinionated Elizabeth and her proud beau, Mr. Darcy, is a splendid performance of civilized sparring. And Jane Austen's radiant wit sparkles as her characters dance a delicate quadrille of flirtation and intrigue, making this book the m", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1320399351l/1885.jpg", "Pride and Prejudice", 80000, 76 },
                    { 5, 4, 202, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9411), "About three things I was absolutely positive.\n\nFirst, Edward was a vampire.\n\nSecond, there was a part of him�and I didn't know how dominant that part might be�that thirsted for my blood.\n\nAnd third, I was unconditionally and irrevocably in love with him.\n\nDeeply seductive and extraordinarily suspenseful, Twilight is a love story with bite.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1361039443l/41865.jpg", "Twilight", 89000, 81 },
                    { 6, 10, 202, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9486), "Librarian's note: An alternate cover edition can be found hereIt is 1939. Nazi Germany. The country is holding its breath. Death has never been busier, and will be busier still.By her brother's graveside, Liesel's life is changed when she picks up a single object, partially hidden in the snow. It is The Gravedigger's Handbook, left behind there by accident, and it is her first act of book thievery. So begins a love affair with books and words, as Liesel, with the help of her accordian-playing foster father, learns to read. Soon she is stealing books from Nazi book-burnings, the mayor's wife's", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1522157426l/19063._SY475_.jpg", "The Book Thief", 38000, 113 },
                    { 7, 4, 201, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9550), "Librarian's note: There is an Alternate Cover Edition for this edition of this book here.A farm is taken over by its overworked, mistreated animals. With flaming idealism and stirring slogans, they set out to create a paradise of progress, justice, and equality. Thus the stage is set for one of the most telling satiric fables ever penned �a razor-edged fairy tale for grown-ups that records the evolution from revolution against tyranny to a totalitarianism just as terrible. When Animal Farm was first published, Stalinist Russia was seen as its target. Today it is devastatingly clear that wherev", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1325861570l/170448.jpg", "Animal Farm", 70000, 110 },
                    { 8, 3, 201, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9612), "Journeys to the end of the world, fantastic creatures, and epic battles between good and evil�what more could any reader ask for in one book? The book that has it all is The Lion, the Witch and the Wardrobe, written in 1949 by Clive Staples Lewis. But Lewis did not stop there. Six more books followed, and together they became known as The Chronicles of Narnia.For the past fifty years, The Chronicles of Narnia have transcended the fantasy genre to become part of the canon of classic literature. Each of the seven books is a masterpiece, drawing the reader into a land where magic meets reality, a", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1449868701l/11127._SY475_.jpg", "The Chronicles of Narnia", 40000, 53 },
                    { 9, 12, 203, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9672), "This four-volume, boxed set contains J.R.R. Tolkien's epic masterworks The Hobbit and the three volumes of The Lord of the Rings (The Fellowship of the Ring, The Two Towers, and The Return of the King).In The Hobbit, Bilbo Baggins is whisked away from his comfortable, unambitious life in Hobbiton by the wizard Gandalf and a company of dwarves. He finds himself caught up in a plot to raid the treasure hoard of Smaug the Magnificent, a large and very dangerous dragon.The Lord of the Rings tells of the great quest undertaken by Frodo Baggins and the Fellowship of the Ring: Gandalf the wizard; the", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1346072396l/30.jpg", "J.R.R. Tolkien 4-Book Boxed Set: The Hobbit and The Lord of the Rings", 238000, 60 },
                    { 10, 4, 202, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9774), "Scarlett O'Hara, the beautiful, spoiled daughter of a well-to-do Georgia plantation owner, must use every means at her disposal to claw her way out of the poverty she finds herself in after Sherman's March to the Sea.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1551144577l/18405._SY475_.jpg", "Gone with the Wind", 297000, 59 },
                    { 11, 9, 201, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9835), "Despite the tumor-shrinking medical miracle that has bought her a few years, Hazel has never been anything but terminal, her final chapter inscribed upon diagnosis. But when a gorgeous plot twist named Augustus Waters suddenly appears at Cancer Kid Support Group, Hazel's story is about to be completely rewritten.Insightful, bold, irreverent, and raw, The Fault in Our Stars is award-winning author John Green's most ambitious and heartbreaking work yet, brilliantly exploring the funny, thrilling, and tragic business of being alive and in love.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1360206420l/11870085.jpg", "The Fault in Our Stars", 86000, 150 },
                    { 12, 5, 203, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9896), "Seconds before the Earth is demolished to make way for a galactic freeway, Arthur Dent is plucked off the planet by his friend Ford Prefect, a researcher for the revised edition of The Hitchhiker's Guide to the Galaxy who, for the last fifteen years, has been posing as an out-of-work actor.Together this dynamic pair begin a journey through space aided by quotes from The Hitchhiker's Guide (\"A towel is about the most massively useful thing an interstellar hitchhiker can have\") and a galaxy-full of fellow travelers: Zaphod Beeblebrox�the two-headed, three-armed ex-hippie and totally out-to-lunch", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1559986152l/386162.jpg", "The Hitchhiker's Guide to the Galaxy", 108000, 78 },
                    { 13, 3, 202, new DateTime(2022, 3, 30, 22, 15, 24, 831, DateTimeKind.Local).AddTicks(9960), "Once there was a tree...and she loved a little boy.\"So begins a story of unforgettable perception, beautifully written and illustrated by the gifted and versatile Shel Silverstein.Every day the boy would come to the tree to eat her apples, swing from her branches, or slide down her trunk...and the tree was happy. But as the boy grew older he began to want more from the tree, and the tree gave and gave and gave.This is a tender story, touched with sadness, aglow with consolation. Shel Silverstein has created a moving parable for readers of all ages that offers an affecting interpretation of th", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1174210942l/370493._SX318_.jpg", "The Giving Tree", 206000, 56 },
                    { 14, 6, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(53), "You can find the redesigned cover of this edition HERE.This best-selling Norton Critical Edition is based on the 1847 first edition of the novel. For the Fourth Edition, the editor has collated the 1847 text with several modern editions and has corrected a number of variants, including accidentals. The text is accompanied by entirely new explanatory annotations.New to the fourth Edition are twelve of Emily Bronte's letters regarding the publication of the 1847 edition of Wuthering Heights as well as the evolution of the 1850 edition, prose and poetry selections by the author, four reviews of t", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1587655304l/6185._SY475_.jpg", "Wuthering Heights", 235000, 150 },
                    { 15, 7, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(117), "ISBN 9780307277671 moved to this edition.While in Paris, Harvard symbologist Robert Langdon is awakened by a phone call in the dead of the night. The elderly curator of the Louvre has been murdered inside the museum, his body covered in baffling symbols. As Langdon and gifted French cryptologist Sophie Neveu sort through the bizarre riddles, they are stunned to discover a trail of clues hidden in the works of Leonardo da Vinci�clues visible for all to see and yet ingeniously disguised by the painter.Even more startling, the late curator was involved in the Priory of Sion�a secret society whose", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1579621267l/968.jpg", "The Da Vinci Code", 27000, 74 },
                    { 16, 3, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(181), "A literary sensation and runaway bestseller, this brilliant debut novel presents with seamless authenticity and exquisite lyricism the true confessions of one of Japan's most celebrated geisha.In Memoirs of a Geisha, we enter a world where appearances are paramount; where a girl's virginity is auctioned to the highest bidder; where women are trained to beguile the most powerful men; and where love is scorned as illusion. It is a unique and triumphant work of fiction - at once romantic, erotic, suspenseful - and completely unforgettable.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1409595968l/929.jpg", "Memoirs of a Geisha", 266000, 54 },
                    { 17, 2, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(241), "Written in his distinctively dazzling manner, Oscar Wilde�s story of a fashionable young man who sells his soul for eternal youth and beauty is the author�s most popular work. The tale of Dorian Gray�s moral disintegration caused a scandal when it ?rst appeared in 1890, but though Wilde was attacked for the novel�s corrupting in?uence, he responded that there is, in fact, �a terrible moral in Dorian Gray.� Just a few years later, the book and the aesthetic/moral dilemma it presented became issues in the trials occasioned by Wilde�s homosexual liaisons, which resulted in his imprisonment. Of Do", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1546103428l/5297.jpg", "The Picture of Dorian Gray", 131000, 62 },
                    { 18, 9, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(303), "I can't explain myself, I'm afraid, sir,\" said Alice, \"Because I'm not myself, you see.\"When Alice sees a white rabbit take a watch out of its waistcoat pocket she decides to follow it, and a sequence of most unusual events is set in motion. This mini book contains the entire topsy-turvy stories of Alice's Adventures in Wonderland and Through the Looking-Glass, accompanied by practical notes and Martina Pelouso's memorable full-colour illustrations.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327872220l/24213.jpg", "Alice's Adventures in Wonderland & Through the Looking-Glass", 260000, 141 },
                    { 19, 5, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(415), "Orphaned as a child, Jane has felt an outcast her whole young life. Her courage is tested once again when she arrives at Thornfield Hall, where she has been hired by the brooding, proud Edward Rochester to care for his ward Ad�le. Jane finds herself drawn to his troubled yet kind spirit. She falls in love. Hard. But there is a terrifying secret inside the gloomy, forbidding Thornfield Hall. Is Rochester hiding from Jane? Will Jane be left heartbroken and exiled once again?", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1557343311l/10210._SY475_.jpg", "Jane Eyre", 295000, 54 },
                    { 20, 4, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(480), "Introducing one of the most famous characters in literature, Jean Valjean�the noble peasant imprisoned for stealing a loaf of bread�Les Mis�rables ranks among the greatest novels of all time. In it, Victor Hugo takes readers deep into the Parisian underworld, immerses them in a battle between good and evil, and carries them to the barricades during the uprising of 1832 with a breathtaking realism that is unsurpassed in modern prose. Within his dramatic story are themes that capture the intellect and the emotions: crime and punishment, the relentless persecution of Valjean by Inspector Javert,", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1411852091l/24280.jpg", "Les Mis�rables", 88000, 70 },
                    { 21, 6, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(541), "Guy Montag is a fireman. In his world, where television rules and literature is on the brink of extinction, firemen start fires rather than put them out. His job is to destroy the most illegal of commodities, the printed book, along with the houses in which they are hidden.Montag never questions the destruction and ruin his actions produce, returning each day to his bland life and wife, Mildred, who spends all day with her television 'family'. But then he meets an eccentric young neighbor, Clarisse, who introduces him to a past where people did not live in fear and to a present where one sees", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1383718290l/13079982.jpg", "Fahrenheit 451", 276000, 60 },
                    { 22, 5, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(603), "In Beatrice Prior's dystopian Chicago world, society is divided into five factions, each dedicated to the cultivation of a particular virtue�Candor (the honest), Abnegation (the selfless), Dauntless (the brave), Amity (the peaceful), and Erudite (the intelligent). On an appointed day of every year, all sixteen-year-olds must select the faction to which they will devote the rest of their lives. For Beatrice, the decision is between staying with her family and being who she really is�she can't have both. So she makes a choice that surprises everyone, including herself.During the highly competiti", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1588455221l/13335037._SY475_.jpg", "Divergent", 197000, 144 },
                    { 23, 1, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(718), "At the dawn of the next world war, a plane crashes on an uncharted island, stranding a group of schoolboys. At first, with no adult supervision, their freedom is something to celebrate; this far from civilization the boys can do anything they want. Anything. They attempt to forge their own society, failing, however, in the face of terror, sin and evil. And as order collapses, as strange howls echo in the night, as terror begins its reign, the hope of adventure seems as far from reality as the hope of being rescued. Labeled a parable, an allegory, a myth, a morality tale, a parody, a political", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327869409l/7624.jpg", "Lord of the Flies", 245000, 117 },
                    { 24, 12, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(781), "In Romeo and Juliet, Shakespeare creates a violent world, in which two young people fall in love. It is not simply that their families disapprove; the Montagues and the Capulets are engaged in a blood feud.In this death-filled setting, the movement from love at first sight to the lovers� final union in death seems almost inevitable. And yet, this play set in an extraordinary world has become the quintessential story of young love. In part because of its exquisite language, it is easy to respond as if it were about all young lovers.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1572098085l/18135._SY475_.jpg", "Romeo and Juliet", 226000, 129 },
                    { 25, 12, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(843), "Paulo Coelho's enchanting novel has inspired a devoted following around the world. This story, dazzling in its powerful simplicity and soul-stirring wisdom, is about an Andalusian shepherd boy named Santiago who travels from his homeland in Spain to the Egyptian desert in search of a treasure buried near the Pyramids. Along the way he meets a Gypsy woman, a man who calls himself king, and an alchemist, all of whom point Santiago in the direction of his quest. No one knows what the treasure is, or if Santiago will be able to surmount the obstacles in his path. But what starts out as a journey t", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1466865542l/18144590._SY475_.jpg", "The Alchemist", 74000, 119 },
                    { 26, 2, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(902), "Raskolnikov, a destitute and desperate former student, wanders through the slums of St Petersburg and commits a random murder without remorse or regret. He imagines himself to be a great man, a Napoleon: acting for a higher purpose beyond conventional moral law. But as he embarks on a dangerous game of cat and mouse with a suspicious police investigator, Raskolnikov is pursued by the growing voice of his conscience and finds the noose of his own guilt tightening around his neck. Only Sonya, a downtrodden prostitute, can offer the chance of redemption.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1382846449l/7144.jpg", "Crime and Punishment", 70000, 60 },
                    { 27, 6, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(963), "standing on the fringes of life...offers a unique perspective. But there comes a time to seewhat it looks like from the dance floor.This haunting novel about the dilemma of passivity vs. passion marks the stunning debut of a provocative new voice in contemporary fiction: The Perks of Being A WALLFLOWERThis is the story of what it's like to grow up in high school. More intimate than a diary, Charlie's letters are singular and unique, hilarious and devastating. We may not know where he lives. We may not know to whom he is writing. All we know is the world he shares. Caught between trying to live", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1520093244l/22628.jpg", "The Perks of Being a Wallflower", 69000, 102 },
                    { 28, 10, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1079), "Alternate Cover Edition ISBN: 0743273567 (ISBN13: 9780743273565)The Great Gatsby, F. Scott Fitzgerald's third book, stands as the supreme achievement of his career. This exemplary novel of the Jazz Age has been acclaimed by generations of readers. The story is of the fabulously wealthy Jay Gatsby and his new love for the beautiful Daisy Buchanan, of lavish parties on Long Island at a time when The New York Times noted \"gin was the national drink and sex the national obsession,\" it is an exquisitely crafted tale of America in the 1920s.The Great Gatsby is one of the great classics of twentieth-", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1490528560l/4671._SY475_.jpg", "The Great Gatsby", 290000, 137 },
                    { 29, 8, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1150), "When fifteen-year-old Clary Fray heads out to the Pandemonium Club in New York City, she hardly expects to witness a murder- much less a murder committed by three teenagers covered with strange tattoos and brandishing bizarre weapons. Then the body disappears into thin air. It's hard to call the police when the murderers are invisible to everyone else and when there is nothing-not even a smear of blood-to show that a boy has died. Or was he a boy?This is Clary's first meeting with the Shadowhunters, warriors dedicated to ridding the earth of demons. It's also her first encounter with Jace, a S", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1432730315l/256683._SY475_.jpg", "City of Bones", 157000, 58 },
                    { 30, 5, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1212), "Andrew \"Ender\" Wiggin thinks he is playing computer simulated war games; he is, in fact, engaged in something far more desperate. The result of genetic experimentation, Ender may be the military genius Earth desperately needs in a war against an alien enemy seeking to destroy all human life. The only way to find out is to throw Ender into ever harsher training, to chip away and find the diamond inside, or destroy him utterly. Ender Wiggin is six years old when it begins. He will grow up fast.But Ender is not the only result of the experiment. The war with the Buggers has been raging for a hund", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1408303130l/375802.jpg", "Ender's Game", 259000, 111 },
                    { 31, 7, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1276), "Librarian's note: An alternate cover edition can be found hereThree ordinary women are about to take one extraordinary step.Twenty-two-year-old Skeeter has just returned home after graduating from Ole Miss. She may have a degree, but it is 1962, Mississippi, and her mother will not be happy till Skeeter has a ring on her finger. Skeeter would normally find solace with her beloved maid Constantine, the woman who raised her, but Constantine has disappeared and no one will tell Skeeter where she has gone.Aibileen is a black maid, a wise, regal woman raising her seventeenth white child. Something", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1572940430l/4667024._SY475_.jpg", "The Help", 104000, 92 },
                    { 32, 6, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1381), "As soon as Anne Shirley arrives at the snug white farmhouse called Green Gables, she is sure she wants to stay forever . . . but will the Cuthberts send her back to to the orphanage? Anne knows she's not what they expected�a skinny girl with fiery red hair and a temper to match. If only she can convince them to let her stay, she'll try very hard not to keep rushing headlong into scrapes and blurting out the first thing that comes to her mind. Anne is not like anyone else, the Cuthberts agree; she is special�a girl with an enormous imagination. This orphan girl dreams of the day when she can ca", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390789015l/8127.jpg", "Anne of Green Gables", 207000, 51 },
                    { 33, 9, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1446), "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.After a lifetime of bottling up his magical powers, Harry finally feels like a normal kid. But even within the Wizarding community, he is special. He is the boy who lived: the only person to have ever survived a", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1474154022l/3._SY475_.jpg", "Harry Potter and the Sorcerer's Stone", 199000, 115 },
                    { 34, 10, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1518), "A PBS Great American Read Top 100 PickFew stories are as widely read and as universally cherished by children and adults alike as The Little Prince. Richard Howard's translation of the beloved classic beautifully reflects Saint-Exup�ry's unique and gifted style. Howard, an acclaimed poet and one of the preeminent translators of our time, has excelled in bringing the English text as close as possible to the French, in language, style, and most important, spirit. The artwork in this edition has been restored to match in detail and in color Saint-Exup�ry's original artwork. Combining Richard Howa", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1367545443l/157993.jpg", "The Little Prince", 142000, 107 },
                    { 35, 7, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1585), "This beloved book by E. B. White, author of Stuart Little and The Trumpet of the Swan, is a classic of children's literature that is \"just about perfect.\" This high-quality paperback features vibrant illustrations colorized by Rosemary Wells!Some Pig. Humble. Radiant. These are the words in Charlotte's Web, high up in Zuckerman's barn. Charlotte's spiderweb tells of her feelings for a little pig named Wilbur, who simply wants a friend. They also express the love of a girl named Fern, who saved Wilbur's life when he was born the runt of his litter.E. B. White's Newbery Honor Book is a tender no", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1439632243l/24178._SY475_.jpg", "Charlotte's Web", 156000, 80 },
                    { 36, 4, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1683), "The compelling story of two outsiders striving to find their place in an unforgiving world. Drifters in search of work, George and his simple-minded friend Lennie have nothing in the world except each other and a dream -- a dream that one day they will have some land of their own. Eventually they find work on a ranch in California�s Salinas Valley, but their hopes are doomed as Lennie, struggling against extreme cruelty, misunderstanding and feelings of jealousy, becomes a victim of his own strength. Tackling universal themes such as the friendship of a shared vision, and giving voice to Ameri", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1511302904l/890._SX318_.jpg", "Of Mice and Men", 50000, 59 },
                    { 37, 1, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1745), "A funny, often poignant tale of boy meets girl with a twist: what if one of them couldn't stop slipping in and out of time? Highly original and imaginative, this debut novel raises questions about life, love, and the effects of time on relationships.Audrey Niffenegger�s innovative debut, The Time Traveler�s Wife, is the story of Clare, a beautiful art student, and Henry, an adventuresome librarian, who have known each other since Clare was six and Henry was thirty-six, and were married when Clare was twenty-three and Henry thirty-one. Impossible but true, because Henry is one of the first peop", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1380660571l/18619684.jpg", "The Time Traveler's Wife", 208000, 73 },
                    { 38, 12, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1870), "You can find an alternative cover edition for this ISBN here and here.A rich selection of background and source materials is provided in three areas: Contexts includes probable inspirations for Dracula in the earlier works of James Malcolm Rymer and Emily Gerard. Also included are a discussion of Stoker's working notes for the novel and \"Dracula's Guest,\" the original opening chapter to Dracula. Reviews and Reactions reprints five early reviews of the novel. \"Dramatic and Film Variations\" focuses on theater and film adaptations of Dracula, two indications of the novel's unwavering appeal. Davi", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1387151694l/17245.jpg", "Dracula", 118000, 115 },
                    { 39, 7, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(1935), "Brave New World is a dystopian novel by English author Aldous Huxley, written in 1931 and published in 1932. Largely set in a futuristic World State, inhabited by genetically modified citizens and an intelligence-based social hierarchy, the novel anticipates huge scientific advancements in reproductive technology, sleep-learning, psychological manipulation and classical conditioning that are combined to make a dystopian society which is challenged by only a single individual: the story's protagonist.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1575509280l/5129._SY475_.jpg", "Brave New World", 270000, 111 },
                    { 40, 9, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2038), "The brilliant, bestselling, landmark novel that tells the story of the Buendia family, and chronicles the irreconcilable conflict between the desire for solitude and the need for love�in rich, imaginative prose that has come to define an entire genre known as \"magical realism.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327881361l/320.jpg", "One Hundred Years of Solitude", 173000, 61 },
                    { 41, 4, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2098), "The hero-narrator of The Catcher in the Rye is an ancient child of sixteen, a native New Yorker named Holden Caulfield. Through circumstances that tend to preclude adult, secondhand description, he leaves his prep school in Pennsylvania and goes underground in New York City for three days. The boy himself is at once too simple and too complex for us to make any final comment about him or his story. Perhaps the safest thing we can say about Holden is that he was born in the world not just strongly attracted to beauty but, almost, hopelessly impaled on it. There are many voices in this novel: ch", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1398034300l/5107.jpg", "The Catcher in the Rye", 245000, 112 },
                    { 42, 6, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2160), "What happens when the most beautiful girl in the world marries the handsomest prince of all time and he turns out to be...well...a lot less than the man of her dreams?As a boy, William Goldman claims, he loved to hear his father read the S. Morgenstern classic, The Princess Bride. But as a grown-up he discovered that the boring parts were left out of good old Dad's recitation, and only the \"good parts\" reached his ears.Now Goldman does Dad one better. He's reconstructed the \"Good Parts Version\" to delight wise kids and wide-eyed grownups everywhere.What's it about? Fencing. Fighting. True Love", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327903636l/21787.jpg", "The Princess Bride", 195000, 80 }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 43, 9, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2231), "Alternate cover for this ISBN can be found herePercy Jackson is a good kid, but he can't seem to focus on his schoolwork or control his temper. And lately, being away at boarding school is only getting worse - Percy could have sworn his pre-algebra teacher turned into a monster and tried to kill him. When Percy's mom finds out, she knows it's time that he knew the truth about where he came from, and that he go to the one place he'll be safe. She sends Percy to Camp Half Blood, a summer camp for demigods (on Long Island), where he learns that the father he never knew is Poseidon, God of the Sea", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1400602609l/28187.jpg", "The Lightning Thief", 161000, 60 },
                    { 44, 5, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2291), "One of the most delightful and enduring classics of children's literature, The Secret Garden by Victorian author Frances Hodgson Burnett has remained a firm favorite with children the world over ever since it made its first appearance. Initially published as a serial story in 1910 in The American Magazine, it was brought out in novel form in 1911.  The plot centers round Mary Lennox, a young English girl who returns to England from India, having suffered the immense trauma by losing both her parents in a cholera epidemic. However, her memories of her parents are not pleasant, as they were a s", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327873635l/2998.jpg", "The Secret Garden", 215000, 149 },
                    { 45, 9, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2383), "A Thousand Splendid Suns is a breathtaking story set against the volatile events of Afghanistan's last thirty years�from the Soviet invasion to the reign of the Taliban to post-Taliban rebuilding�that puts the violence, fear, hope, and faith of this country in intimate, human terms. It is a tale of two generations of characters brought jarringly together by the tragic sweep of war, where personal lives�the struggle to survive, raise a family, find happiness�are inextricable from the history playing out around them.Propelled by the same storytelling instinct that made The Kite Runner a beloved", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1345958969l/128029.jpg", "A Thousand Splendid Suns", 172000, 69 },
                    { 46, 2, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2444), "It was a dark and stormy night.Out of this wild night, a strange visitor comes to the Murry house and beckons Meg, her brother Charles Wallace, and their friend Calvin O'Keefe on a most dangerous and extraordinary adventure�one that will threaten their lives and our universe.Winner of the 1963 Newbery Medal, A Wrinkle in Time is the first book in Madeleine L'Engle's classic Time Quintet.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1507963312l/33574273._SX318_.jpg", "A Wrinkle in Time", 119000, 108 },
                    { 47, 10, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2503), "Here is the first volume in George R. R. Martin�s magnificent cycle of novels that includes A Clash of Kings and A Storm of Swords. As a whole, this series comprises a genuine masterpiece of modern fantasy, bringing together the best the genre has to offer. Magic, mystery, intrigue, romance, and adventure fill these pages and transport us to a world unlike any we have ever experienced. Already hailed as a classic, George R. R. Martin�s stunning series is destined to stand as one of the great achievements of imaginative fiction.A GAME OF THRONESLong ago, in a time forgotten, a preternatural eve", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1562726234l/13496.jpg", "A Game of Thrones", 114000, 116 },
                    { 48, 4, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2565), "A nineteenth-century boy from a Mississippi River town recounts his adventures as he travels down the river with a runaway slave, encountering a family involved in a feud, two scoundrels pretending to be royalty, and Tom Sawyer's aunt who mistakes him for Tom.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1546096879l/2956.jpg", "The Adventures of Huckleberry Finn", 294000, 136 },
                    { 49, 12, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2621), "My name was Salmon, like the fish; first name, Susie. I was fourteen when I was murdered on December 6, 1973.\"So begins the story of Susie Salmon, who is adjusting to her new home in heaven, a place that is not at all what she expected, even as she is watching life on earth continue without her -- her friends trading rumors about her disappearance, her killer trying to cover his tracks, her grief-stricken family unraveling. Out of unspeakable tragedy and loss, The Lovely Bones succeeds, miraculously, in building a tale filled with hope, humor, suspense, even joy.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1457810586l/12232938.jpg", "The Lovely Bones", 233000, 105 },
                    { 50, 3, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2723), "The Outsiders is about two weeks in the life of a 14-year-old boy. The novel tells the story of Ponyboy Curtis and his struggles with right and wrong in a society in which he believes that he is an outsider. According to Ponyboy, there are two kinds of people in the world: greasers and socs. A soc (short for \"social\") has money, can get away with just about anything, and has an attitude longer than a limousine. A greaser, on the other hand, always lives on the outside and needs to watch his back. Ponyboy is a greaser, and he's always been proud of it, even willing to rumble against a gang of s", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1442129426l/231804.jpg", "The Outsiders", 298000, 141 },
                    { 51, 4, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2789), "Max, a wild and naughty boy, is sent to bed without his supper by his exhausted mother. In his room, he imagines sailing far away to a land of Wild Things. Instead of eating him, the Wild Things make Max their king.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1384434560l/19543.jpg", "Where the Wild Things Are", 196000, 60 },
                    { 52, 10, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2846), "�Do you like green eggs and ham?� asks Sam-I-am in this Beginner Book by Dr. Seuss. In a house or with a mouse? In a boat or with a goat? On a train or in a tree? Sam keeps asking persistently. With unmistakable characters and signature rhymes, Dr. Seuss�s beloved favorite has cemented its place as a children�s classic. In this most famous of cumulative tales, the list of places to enjoy green eggs and ham, and friends to enjoy them with, gets longer and longer. Follow Sam-I-am as he insists that this unusual treat is indeed a delectable snack to be savored everywhere and in every way. Origina", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1468680100l/23772.jpg", "Green Eggs and Ham", 88000, 110 },
                    { 53, 12, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2916), "Sing to me of the man, Muse, the man of twists and turnsdriven time and again off course, once he had plunderedthe hallowed heights of Troy.So begins Robert Fagles' magnificent translation of the Odyssey, which Jasper Griffin in The New York Times Review of Books hails as \"a distinguished achievement.\"If the Iliad is the world's greatest war epic, then the Odyssey is literature's grandest evocation of everyman's journey though life. Odysseus' reliance on his wit and wiliness for survival in his encounters with divine and natural forces, during his ten-year voyage home to Ithaca after the Troja", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390173285l/1381.jpg", "The Odyssey", 257000, 58 },
                    { 54, 2, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(2981), "Life of Pi is a fantasy adventure novel by Yann Martel published in 2001. The protagonist, Piscine Molitor \"Pi\" Patel, a Tamil boy from Pondicherry, explores issues of spirituality and practicality from an early age. He survives 227 days after a shipwreck while stranded on a boat in the Pacific Ocean with a Bengal tiger named Richard Parker.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1320562005l/4214.jpg", "Life of Pi", 137000, 138 },
                    { 55, 9, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3091), "After eighteen years as a political prisoner in the Bastille, the ageing Doctor Manette is finally released and reunited with his daughter in England. There the lives of two very different men, Charles Darnay, an exiled French aristocrat, and Sydney Carton, a disreputable but brilliant English lawyer, become enmeshed through their love for Lucie Manette. From the tranquil roads of London, they are drawn against their will to the vengeful, bloodstained streets of Paris at the height of the Reign of Terror, and they soon fall under the lethal shadow of La Guillotine.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1344922523l/1953.jpg", "A Tale of Two Cities", 173000, 83 },
                    { 56, 3, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3153), "Winner of the 2007 BookBrowse Award for Most Popular Book.An atmospheric, gritty, and compelling novel of star-crossed lovers, set in the circus world circa 1932, by the bestselling author of Riding Lessons. When Jacob Jankowski, recently orphaned and suddenly adrift, jumps onto a passing train, he enters a world of freaks, drifters, and misfits, a second-rate circus struggling to survive during the Great Depression, making one-night stands in town after endless town. A veterinary student who almost earned his degree, Jacob is put in charge of caring for the circus menagerie. It is there that", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1494428973l/43641._SY475_.jpg", "Water for Elephants", 120000, 139 },
                    { 57, 4, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3214), "Humbert Humbert - scholar, aesthete and romantic - has fallen completely and utterly in love with Lolita Haze, his landlady's gum-snapping, silky skinned twelve-year-old daughter. Reluctantly agreeing to marry Mrs Haze just to be close to Lolita, Humbert suffers greatly in the pursuit of romance; but when Lo herself starts looking for attention elsewhere, he will carry her off on a desperate cross-country misadventure, all in the name of Love. Hilarious, flamboyant, heart-breaking and full of ingenious word play, Lolita is an immaculate, unforgettable masterpiece of obsession, delusion and lus", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1377756377l/7604.jpg", "Lolita", 106000, 88 },
                    { 58, 10, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3276), "Selected by the Modern Library as one of the 100 best novels of all time, Slaughterhouse-Five, an American classic, is one of the world's great antiwar books. Centering on the infamous firebombing of Dresden, Billy Pilgrim's odyssey through time reflects the mythic journey of our own fractured lives as we search for meaning in what we fear most.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1440319389l/4981.jpg", "Slaughterhouse-Five", 232000, 71 },
                    { 59, 7, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3361), "Mary Shelley's seminal novel of the scientist whose creation becomes a monsterThis edition is the original 1818 text, which preserves the hard-hitting and politically charged aspects of Shelley's original writing, as well as her unflinching wit and strong female voice. This edition also includes a new introduction and suggestions for further reading by author and Shelley expert Charlotte Gordon, literary excerpts and reviews selected by Gordon and a chronology and essay by preeminent Shelley scholar Charles E. Robinson.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1498841231l/35031085.jpg", "Frankenstein: The 1818 Text", 298000, 100 },
                    { 60, 7, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3425), "The unforgettable, heartbreaking story of the unlikely friendship between a wealthy boy and the son of his father�s servant, The Kite Runner is a beautifully crafted novel set in a country that is in the process of being destroyed. It is about the power of reading, the price of betrayal, and the possibility of redemption; and an exploration of the power of fathers over sons�their love, their sacrifices, their lies.A sweeping story of family, love, and friendship told against the devastating backdrop of the history of Afghanistan over the last thirty years, The Kite Runner is an unusual and pow", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1579036753l/77203._SY475_.jpg", "The Kite Runner", 228000, 55 },
                    { 61, 8, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3487), "Offred is a Handmaid in the Republic of Gilead. She may leave the home of the Commander and his wife once a day to walk to food markets whose signs are now pictures instead of words because women are no longer allowed to read. She must lie on her back once a month and pray that the Commander makes her pregnant, because in an age of declining births, Offred and the other Handmaids are valued only if their ovaries are viable. Offred can remember the years before, when she lived and made love with her husband, Luke; when she played with and protected her daughter; when she had a job, money of her", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1578028274l/38447._SY475_.jpg", "The Handmaid's Tale", 67000, 54 },
                    { 62, 5, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3555), "Twelve-year-old Jonas lives in a seemingly ideal world. Not until he is given his life assignment as the Receiver does he begin to understand the dark secrets behind this fragile community.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1342493368l/3636.jpg", "The Giver", 99000, 67 },
                    { 63, 3, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3609), "The novel is set during World War II, from 1942 to 1944. It mainly follows the life of Captain John Yossarian, a U.S. Army Air Forces B-25 bombardier. Most of the events in the book occur while the fictional 256th Squadron is based on the island of Pianosa, in the Mediterranean Sea, west of Italy. The novel looks into the experiences of Yossarian and the other airmen in the camp, who attempt to maintain their sanity while fulfilling their service requirements so that they may return home.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1463157317l/168668.jpg", "Catch-22", 162000, 116 },
                    { 64, 2, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3697), "Set on the desert planet Arrakis, Dune is the story of the boy Paul Atreides, heir to a noble family tasked with ruling an inhospitable world where the only thing of value is the �spice� melange, a drug capable of extending life and enhancing consciousness. Coveted across the known universe, melange is a prize worth killing for...When House Atreides is betrayed, the destruction of Paul�s family will set the boy on a journey toward a destiny greater than he could ever have imagined. And as he evolves into the mysterious man known as Muad�Dib, he will bring to fruition humankind�s most ancient a", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1555447414l/44767458.jpg", "Dune", 148000, 79 },
                    { 65, 9, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3761), "Ken Follett is known worldwide as the master of split-second suspense, but his most beloved and bestselling book tells the magnificent tale of a twelfth-century monk driven to do the seemingly impossible: build the greatest Gothic cathedral the world has ever known.Everything readers expect from Follett is here: intrigue, fast-paced action, and passionate romance. But what makes The Pillars of the Earth extraordinary is the time the twelfth century; the place feudal England; and the subject the building of a glorious cathedral. Follett has re-created the crude, flamboyant England of the Middle", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1576956100l/5043.jpg", "The Pillars of the Earth", 233000, 143 },
                    { 66, 5, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3824), "This is the way the world ends: with a nanosecond of computer error in a Defense Department laboratory and a million casual contacts that form the links in a chain letter of death. And here is the bleak new world of the day after: a world stripped of its institutions and emptied of 99 percent of its people. A world in which a handful of panicky survivors choose sides -- or are chosen.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1213131305l/149267.jpg", "The Stand", 87000, 79 },
                    { 67, 10, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3882), "The Adventures of Sherlock Holmes is the series of short stories that made the fortunes of the Strand magazine, in which they were first published, and won immense popularity for Sherlock Holmes and Dr Watson. The detective is at the height of his powers and the volume is full of famous cases, including 'The Red-Headed League', 'The Blue Carbuncle', and 'The Speckled Band'. Although Holmes gained a reputation for infallibility, Conan Doyle showed his own realism and feminism by having the great detective defeated by Irene Adler - the woman - in the very first story, 'A Scandal in Bohemia'. The", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1164045516l/3590.jpg", "The Adventures of Sherlock Holmes", 147000, 119 },
                    { 68, 8, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(3972), "Librarian's note: See alternate cover edition of ISBN13 9780380395866 here.Set in England's Downs, a once idyllic rural landscape, this stirring tale of adventure, courage and survival follows a band of very special creatures on their flight from the intrusion of man and the certain destruction of their home. Led by a stouthearted pair of friends, they journey forth from their native Sandleford Warren through the harrowing trials posed by predators and adversaries, to a mysterious promised land and a more perfect society.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1405136931l/76620.jpg", "Watership Down", 99000, 138 },
                    { 69, 4, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(4032), "'In what may be Dickens's best novel, humble, orphaned Pip is apprenticed to the dirty work of the forge but dares to dream of becoming a gentleman � and one day, under sudden and enigmatic circumstances, he finds himself in possession of \"great expectations.\" In this gripping tale of crime and guilt, revenge and reward, the compelling characters include Magwitch, the fearful and fearsome convict; Estella, whose beauty is excelled only by her haughtiness; and the embittered Miss Havisham, an eccentric jilted bride", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327920219l/2623.jpg", "Great Expectations", 228000, 82 },
                    { 70, 1, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(4092), "Generations of readers young and old, male and female, have fallen in love with the March sisters of Louisa May Alcott�s most popular and enduring novel, Little Women. Here are talented tomboy and author-to-be Jo, tragically frail Beth, beautiful Meg, and romantic, spoiled Amy, united in their devotion to each other and their struggles to survive in New England during the Civil War.It is no secret that Alcott based Little Women on her own early life. While her father, the freethinking reformer and abolitionist Bronson Alcott, hobnobbed with such eminent male authors as Emerson, Thoreau, and Ha", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1562690475l/1934._SY475_.jpg", "Little Women", 294000, 80 },
                    { 71, 8, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(4154), "The Bell Jar chronicles the crack-up of Esther Greenwood: brilliant, beautiful, enormously talented, and successful, but slowly going under�maybe for the last time. Sylvia Plath masterfully draws the reader into Esther's breakdown with such intensity that Esther's insanity becomes completely real and even rational, as probable and accessible an experience as going to the movies. Such deep penetration into the dark and harrowing corners of the psyche is an extraordinary accomplishment and has made The Bell Jar a haunting American classic.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1554582218l/6514._SY475_.jpg", "The Bell Jar", 55000, 87 },
                    { 72, 4, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(4222), "Harry Potter is leaving Privet Drive for the last time. But as he climbs into the sidecar of Hagrid�s motorbike and they take to the skies, he knows Lord Voldemort and the Death Eaters will not be far behind.The protective charm that has kept him safe until now is broken. But the Dark Lord is breathing fear into everything he loves. And he knows he can�t keep hiding.To stop Voldemort, Harry knows he must find the remaining Horcruxes and destroy them.He will have to face his enemy in one final battle.--jkrowling.com", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1474171184l/136251._SY475_.jpg", "Harry Potter and the Deathly Hallows", 115000, 80 },
                    { 73, 4, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(4313), "Tyrannical Nurse Ratched rules her ward in an Oregon State mental hospital with a strict and unbending routine, unopposed by her patients, who remain cowed by mind-numbing medication and the threat of electric shock therapy. But her regime is disrupted by the arrival of McMurphy � the swaggering, fun-loving trickster with a devilish grin who resolves to oppose her rules on behalf of his fellow inmates. His struggle is seen through the eyes of Chief Bromden, a seemingly mute half-Indian patient who understands McMurphy's heroic attempt to do battle with the powers that keep them imprisoned. Ken", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1516211014l/332613._SX318_.jpg", "One Flew Over the Cuckoo's Nest", 110000, 79 },
                    { 74, 12, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(4375), "Acclaimed by many as the world's greatest novel, Anna Karenina provides a vast panorama of contemporary life in Russia and of humanity in general. In it Tolstoy uses his intense imaginative insight to create some of the most memorable characters in all of literature. Anna is a sophisticated woman who abandons her empty existence as the wife of Karenin and turns to Count Vronsky to fulfil her passionate nature - with tragic consequences. Levin is a reflection of Tolstoy himself, often expressing the author's own views and convictions.Throughout, Tolstoy points no moral, merely inviting us not t", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1601352433l/15823480._SY475_.jpg", "Anna Karenina", 41000, 77 },
                    { 75, 11, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(4437), "The year is 1945. Claire Randall, a former combat nurse, is just back from the war and reunited with her husband on a second honeymoon when she walks through a standing stone in one of the ancient circles that dot the British Isles. Suddenly she is a Sassenach�an �outlander��in a Scotland torn by war and raiding border clans in the year of Our Lord...1743. Hurled back in time by forces she cannot understand, Claire is catapulted into the intrigues of lairds and spies that may threaten her life, and shatter her heart. For here James Fraser, a gallant young Scots warrior, shows her a love so abs", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1529065012l/10964._SY475_.jpg", "Outlander", 42000, 132 },
                    { 76, 8, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(4499), "Anna is not sick, but she might as well be. By age thirteen, she has undergone countless surgeries, transfusions, and shots so that her older sister, Kate, can somehow fight the leukemia that has plagued her since childhood. The product of preimplantation genetic diagnosis, Anna was conceived as a bone marrow match for Kate�a life and a role that she has never challenged... until now. Like most teenagers, Anna is beginning to question who she truly is. But unlike most teenagers, she has always been defined in terms of her sister�and so Anna makes a decision that for most would be unthinkable,", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1369504683l/10917.jpg", "My Sister's Keeper", 79000, 59 },
                    { 77, 11, 202, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(4602), "Matilda is a little girl who is far too good to be true. At age five-and-a-half she's knocking off double-digit multiplication problems and blitz-reading Dickens. Even more remarkably, her classmates love her even though she's a super-nerd and the teacher's pet. But everything is not perfect in Matilda's world. For starters she has two of the most idiotic, self-centered parents who ever lived. Then there's the large, busty nightmare of a school principal, Miss (\"The\") Trunchbull, a former hammer-throwing champion who flings children at will and is approximately as sympathetic as a bulldozer. F", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1388793265l/39988.jpg", "Matilda", 99000, 54 },
                    { 78, 4, 201, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(4666), "One Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkeness bind themIn ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, The Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell into the hands of Bilbo Baggins, as told in The Hobbit.In a sleepy village in the Shire, young Frodo Baggins finds himself faced with an immense task, as his elderly cousin Bil", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1486871542l/3263607._SY475_.jpg", "The Fellowship of the Ring", 153000, 117 },
                    { 79, 7, 203, new DateTime(2022, 3, 30, 22, 15, 24, 832, DateTimeKind.Local).AddTicks(4727), "Harriet Vanger, a scion of one of Sweden�s wealthiest families disappeared over forty years ago. All these years later, her aged uncle continues to seek the truth. He hires Mikael Blomkvist, a crusading journalist recently trapped by a libel conviction, to investigate. He is aided by the pierced and tattooed punk prodigy Lisbeth Salander. Together they tap into a vein of unfathomable iniquity and astonishing corruption.An international publishing sensation, Stieg Larsson�s The Girl with the Dragon Tattoo combines murder mystery, family saga, love story, and financial intrigue into one satisfyi", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327868566l/2429135.jpg", "The Girl with the Dragon Tattoo", 184000, 60 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 102, 100 },
                    { 101, 201 },
                    { 101, 202 },
                    { 100, 999 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_BookId",
                table: "OrderItem",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderHistory");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
