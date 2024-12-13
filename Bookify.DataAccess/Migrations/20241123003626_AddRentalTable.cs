using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRentalTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PenaltyPaid = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rentals_Subscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "Subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RentalCopies",
                columns: table => new
                {
                    RentalId = table.Column<int>(type: "int", nullable: false),
                    BookCopyId = table.Column<int>(type: "int", nullable: false),
                    RentalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturndedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExtendedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalCopies", x => new { x.RentalId, x.BookCopyId });
                    table.ForeignKey(
                        name: "FK_RentalCopies_BookCopies_BookCopyId",
                        column: x => x.BookCopyId,
                        principalTable: "BookCopies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RentalCopies_Rentals_RentalId",
                        column: x => x.RentalId,
                        principalTable: "Rentals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 8, 15, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 5, 7, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 4, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 6, 26, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 13, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 24, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 9, 24, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 8, 25, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 18, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 29, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 10, 19, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 9, 9, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 7, 26, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 5, 27, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 5, 7, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 107, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 23, 0, 36, 25, 108, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 23, 0, 36, 25, 108, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 172, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 172, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 172, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 172, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 23, 2, 36, 25, 172, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 23, 2, 36, 25, 108, DateTimeKind.Local).AddTicks(8301), "AQAAAAIAAYagAAAAEJlSVRMTV8G8F9dkrezFwGMGdcwVFFZx+c440RgDaznUh02R7L77+2jRdz95R5RHmg==" });

            migrationBuilder.CreateIndex(
                name: "IX_RentalCopies_BookCopyId",
                table: "RentalCopies",
                column: "BookCopyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_SubscriberId",
                table: "Rentals",
                column: "SubscriberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentalCopies");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 545, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 8, 12, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 5, 4, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 1, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 6, 23, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 10, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 21, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 9, 21, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 8, 22, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 15, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 26, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 10, 16, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 9, 6, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 7, 23, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 5, 24, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 5, 4, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 546, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 547, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 547, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 547, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 20, 19, 41, 13, 547, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 20, 19, 41, 13, 547, DateTimeKind.Utc).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 611, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 611, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 611, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 611, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 20, 21, 41, 13, 611, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 20, 21, 41, 13, 547, DateTimeKind.Local).AddTicks(4245), "AQAAAAIAAYagAAAAEPE0qunhLwpRNfeD0AmK2qjEBuJh3mhJ+NxV1mS+WCGktYY4WbCzSfYxomYUodJ3lg==" });
        }
    }
}
