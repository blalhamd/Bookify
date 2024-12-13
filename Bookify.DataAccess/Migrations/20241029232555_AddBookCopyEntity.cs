using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddBookCopyEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Shared");

            migrationBuilder.CreateSequence<int>(
                name: "SerialNumber",
                schema: "Shared",
                startValue: 10000001L,
                incrementBy: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "BookCopies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    IsAvailableForRental = table.Column<bool>(type: "bit", nullable: false),
                    EditionNumber = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR Shared.SerialNumber"),
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
                    table.PrimaryKey("PK_BookCopies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCopies_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "Id", "BookId", "CreatedByUserId", "CreationTime", "DeletedByUserId", "DeletionTime", "EditionNumber", "FirstModificationByUserId", "FirstModificationDate", "IsAvailableForRental", "IsDeleted", "LastModificationByUserId", "LastModificationDate" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2024, 7, 22, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2204), null, null, 1, null, null, true, false, null, null },
                    { 2, 1, 0, new DateTime(2024, 4, 13, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2212), null, null, 2, null, null, false, false, null, null },
                    { 3, 2, 0, new DateTime(2024, 9, 10, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2216), null, null, 1, null, null, true, false, null, null },
                    { 4, 2, 0, new DateTime(2024, 6, 2, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2219), null, null, 2, null, null, false, false, null, null },
                    { 5, 3, 0, new DateTime(2024, 10, 20, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2223), null, null, 1, null, null, true, false, null, null },
                    { 6, 3, 0, new DateTime(2024, 9, 30, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2229), null, null, 2, null, null, true, false, null, null },
                    { 7, 4, 0, new DateTime(2024, 8, 31, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2232), null, null, 1, null, null, false, false, null, null },
                    { 8, 4, 0, new DateTime(2024, 8, 1, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2235), null, null, 2, null, null, true, false, null, null },
                    { 9, 5, 0, new DateTime(2024, 10, 25, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2238), null, null, 1, null, null, true, false, null, null },
                    { 10, 5, 0, new DateTime(2024, 10, 5, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2242), null, null, 2, null, null, false, false, null, null },
                    { 11, 6, 0, new DateTime(2024, 9, 25, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2246), null, null, 1, null, null, true, false, null, null },
                    { 12, 6, 0, new DateTime(2024, 8, 16, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2249), null, null, 2, null, null, true, false, null, null },
                    { 13, 7, 0, new DateTime(2024, 7, 2, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2252), null, null, 1, null, null, false, false, null, null },
                    { 14, 7, 0, new DateTime(2024, 5, 3, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2256), null, null, 2, null, null, true, false, null, null },
                    { 15, 8, 0, new DateTime(2024, 4, 13, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(2259), null, null, 1, null, null, true, false, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 474, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 30, 2, 25, 54, 475, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookCopies_BookId",
                table: "BookCopies",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCopies");

            migrationBuilder.DropIndex(
                name: "IX_Categories_Name",
                table: "Categories");

            migrationBuilder.DropSequence(
                name: "SerialNumber",
                schema: "Shared");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 663, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 25, 15, 10, 19, 664, DateTimeKind.Local).AddTicks(9896));

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
        }
    }
}
