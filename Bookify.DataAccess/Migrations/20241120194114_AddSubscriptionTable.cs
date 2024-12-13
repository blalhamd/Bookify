using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSubscriptionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Subscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "Subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_SubscriberId",
                table: "Subscriptions",
                column: "SubscriberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 920, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 920, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 920, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 8, 9, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 5, 1, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 9, 28, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 6, 20, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 7, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 18, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 9, 18, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 8, 19, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 12, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 23, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 10, 13, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 9, 3, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 7, 20, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 5, 21, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 5, 1, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 921, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 922, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 922, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 922, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 922, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 922, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 922, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 17, 15, 45, 17, 922, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 17, 15, 45, 17, 922, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 987, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 987, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 987, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 987, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 45, 17, 987, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 45, 17, 922, DateTimeKind.Local).AddTicks(5683), "AQAAAAIAAYagAAAAECWdu49YPYXZ4hQNzL2z9PRDEh8awPBTJ0TuTYYPCeo2UxtYVaqY9utkIQDxJ4uJQg==" });
        }
    }
}
