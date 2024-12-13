using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddBookAndAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstModificationByUserId = table.Column<int>(type: "int", nullable: true),
                    LastModificationByUserId = table.Column<int>(type: "int", nullable: true),
                    FirstModificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    DeletedByUserId = table.Column<int>(type: "int", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hall = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailableForRental = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstModificationByUserId = table.Column<int>(type: "int", nullable: true),
                    LastModificationByUserId = table.Column<int>(type: "int", nullable: true),
                    FirstModificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    DeletedByUserId = table.Column<int>(type: "int", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => new { x.CategoryId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedByUserId", "CreationTime", "DeletedByUserId", "DeletionTime", "FirstModificationByUserId", "FirstModificationDate", "IsDeleted", "LastModificationByUserId", "LastModificationDate", "Name", "Nationality" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4651), null, null, null, null, false, null, null, "Taha Hussien", "Egypt" },
                    { 2, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4663), null, null, null, null, false, null, null, "Naguib Mahfouz", "Egypt" },
                    { 3, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4671), null, null, null, null, false, null, null, "Mahmoud Darwish", "Palestine" },
                    { 4, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4678), null, null, null, null, false, null, null, "Khalil Gibran", "Lebanon" },
                    { 5, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4686), null, null, null, null, false, null, null, "Adonis", "Syria" },
                    { 6, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4697), null, null, null, null, false, null, null, "Hanan al-Shaykh", "Lebanon" },
                    { 7, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4707), null, null, null, null, false, null, null, "Ahlam Mosteghanemi", "Algeria" },
                    { 8, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4714), null, null, null, null, false, null, null, "Ibrahim Nasrallah", "Palestine" },
                    { 9, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4722), null, null, null, null, false, null, null, "Hanan al-Shaykh", "Lebanon" },
                    { 10, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4732), null, null, null, null, false, null, null, "Nawal El Saadawi", "Egypt" },
                    { 11, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4739), null, null, null, null, false, null, null, "Yasmina Khadra", "Algeria" },
                    { 12, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4746), null, null, null, null, false, null, null, "Salman Rushdie", "India" },
                    { 13, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4754), null, null, null, null, false, null, null, "Orhan Pamuk", "Turkey" },
                    { 14, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4761), null, null, null, null, false, null, null, "Elif Shafak", "Turkey" },
                    { 15, 1, new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4768), null, null, null, null, false, null, null, "Amitav Ghosh", "India" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 665, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 665, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 665, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CreatedByUserId", "CreationTime", "DeletedByUserId", "DeletionTime", "Description", "FirstModificationByUserId", "FirstModificationDate", "Hall", "ImageUrl", "IsAvailableForRental", "IsDeleted", "LastModificationByUserId", "LastModificationDate", "Price", "PublishedOn", "Publisher", "Title", "Type" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9780), null, null, "A sweeping saga of a family in Cairo during the early 20th century.", null, null, "Main Hall", "https://example.com/cairo_trilogy.jpg", false, false, null, null, 150m, new DateTime(1956, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Publishing House", "The Cairo Trilogy", "Drama" },
                    { 2, 1, 1, new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9812), null, null, "The first book in the Cairo Trilogy, focusing on family life in Cairo.", null, null, "Main Hall", "https://example.com/palace_walk.jpg", false, false, null, null, 120m, new DateTime(1956, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Publishing House", "Palace Walk", "Drama" },
                    { 3, 2, 1, new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9823), null, null, "A postcolonial narrative exploring identity and belonging.", null, null, "Main Hall", "https://example.com/season_of_migration.jpg", false, false, null, null, 130m, new DateTime(1966, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Publishing House", "Season of Migration to the North", "Fiction" },
                    { 4, 3, 1, new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9832), null, null, "A collection of poetic essays covering various aspects of life.", null, null, "Poetry Section", "https://example.com/the_prophet.jpg", false, false, null, null, 90m, new DateTime(1923, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Publishing House", "The Prophet", "Poetry" },
                    { 5, 4, 1, new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9842), null, null, "A historical novel set in Egypt and America, intertwining love stories.", null, null, "Main Hall", "https://example.com/map_of_love.jpg", false, false, null, null, 140m, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Publishing House", "The Map of Love", "HistoricalFiction" },
                    { 6, 5, 1, new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9855), null, null, "A novel set in a once-grand building in downtown Cairo.", null, null, "Main Hall", "https://example.com/yacoubian_building.jpg", false, false, null, null, 110m, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Publishing House", "The Yacoubian Building", "Fiction" },
                    { 7, 6, 1, new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9865), null, null, "A poignant coming-of-age story set in Egypt.", null, null, "Main Hall", "https://example.com/open_door.jpg", false, false, null, null, 100m, new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Publishing House", "The Open Door", "Fiction" },
                    { 8, 7, 1, new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9875), null, null, "A novel that blends Eastern and Western philosophies.", null, null, "Main Hall", "https://example.com/book_of_khalid.jpg", false, false, null, null, 85m, new DateTime(1911, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Publishing House", "The Book of Khalid", "Fiction" },
                    { 9, 8, 1, new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9884), null, null, "An exploration of spirituality and identity.", null, null, "Main Hall", "https://example.com/return_of_the_spirit.jpg", false, false, null, null, 125m, new DateTime(1933, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Publishing House", "The Return of the Spirit", "Fiction" },
                    { 10, 9, 1, new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9896), null, null, "A novel set in the Ottoman Empire, blending art and politics.", null, null, "Main Hall", "https://example.com/my_name_is_red.jpg", false, false, null, null, 135m, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Publishing House", "My Name is Red", "Fiction" }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 9, 2 },
                    { 10, 2 },
                    { 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_BookId",
                table: "BookCategories",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Title_AuthorId",
                table: "Books",
                columns: new[] { "Title", "AuthorId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 10, 20, 8, 14, 59, 872, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 10, 20, 8, 14, 59, 872, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 20, 8, 14, 59, 872, DateTimeKind.Local).AddTicks(1937));
        }
    }
}
