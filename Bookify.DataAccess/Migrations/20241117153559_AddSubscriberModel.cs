using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSubscriberModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Governorates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Areas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Areas_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasWhatsApp = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBlackListed = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Subscribers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscribers_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscribers_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 8, 9, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 5, 1, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 9, 28, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 6, 20, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 7, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 18, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 9, 18, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 8, 19, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 12, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 23, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 10, 13, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 9, 3, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 7, 20, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 5, 21, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 5, 1, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.InsertData(
                table: "Governorates",
                columns: new[] { "Id", "CreatedByUserId", "CreationTime", "DeletedByUserId", "DeletionTime", "FirstModificationByUserId", "FirstModificationDate", "IsDeleted", "LastModificationByUserId", "LastModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(8975), null, null, null, null, false, null, null, "Cairo" },
                    { 2, 0, new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(8988), null, null, null, null, false, null, null, "Giza" },
                    { 3, 0, new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(8990), null, null, null, null, false, null, null, "Beni Suef" }
                });

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 17, 15, 35, 58, 665, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 17, 15, 35, 58, 665, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 35, 58, 665, DateTimeKind.Local).AddTicks(3205), "AQAAAAIAAYagAAAAECdeHxQ0eD2Y4fvEnAquGyT/uxHvJvoheCkpYbTaLZ/vRjO5ceH/eg35BjEhVwaZMg==" });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "CreatedByUserId", "CreationTime", "DeletedByUserId", "DeletionTime", "FirstModificationByUserId", "FirstModificationDate", "GovernorateId", "IsDeleted", "LastModificationByUserId", "LastModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(4236), null, null, null, null, 1, false, null, null, "Area 1" },
                    { 2, 0, new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(4287), null, null, null, null, 2, false, null, null, "Area 2" },
                    { 3, 0, new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(4290), null, null, null, null, 3, false, null, null, "Area 3" }
                });

            migrationBuilder.InsertData(
                table: "Subscribers",
                columns: new[] { "Id", "Address", "AreaId", "CreatedByUserId", "CreationTime", "DateOfBirth", "DeletedByUserId", "DeletionTime", "Email", "FirstModificationByUserId", "FirstModificationDate", "FirstName", "Gender", "GovernorateId", "HasWhatsApp", "ImageUrl", "IsBlackListed", "IsDeleted", "LastModificationByUserId", "LastModificationDate", "LastName", "NationalId", "Phone" },
                values: new object[,]
                {
                    { 1, "123 Elm St Apt 4B", 1, 0, new DateTime(2024, 11, 17, 17, 35, 58, 732, DateTimeKind.Local).AddTicks(4477), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "john.doe@example.com", null, null, "John", "Male", 1, true, "https://example.com/johndoe.jpg", false, false, null, null, "Doe", "12345678901234", "123-456-7890" },
                    { 2, "456 Oak St Unit 12", 2, 0, new DateTime(2024, 11, 17, 17, 35, 58, 732, DateTimeKind.Local).AddTicks(4533), new DateTime(1985, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "jane.smith@example.com", null, null, "Jane", "Female", 1, false, "https://example.com/janesmith.jpg", false, false, null, null, "Smith", "23456789012345", "987-654-3210" },
                    { 3, "789 Pine St House 10", 1, 0, new DateTime(2024, 11, 17, 17, 35, 58, 732, DateTimeKind.Local).AddTicks(4538), new DateTime(1992, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "alice.j@example.com", null, null, "Alice", "Female", 2, true, "https://example.com/alicejohnson.jpg", true, false, null, null, "Johnson", "34567890123456", "555-555-5555" },
                    { 4, "321 Maple St Villa 3", 3, 0, new DateTime(2024, 11, 17, 17, 35, 58, 732, DateTimeKind.Local).AddTicks(4541), new DateTime(1980, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "bob.brown@example.com", null, null, "Bob", "Male", 2, false, "https://example.com/bobbrown.jpg", false, false, null, null, "Brown", "45678901234567", "444-444-4444" },
                    { 5, "321 Maple St Villa 4", 2, 0, new DateTime(2024, 11, 17, 17, 35, 58, 732, DateTimeKind.Local).AddTicks(4545), new DateTime(1995, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "charlie.d@example.com", null, null, "Charlie", "Male", 3, true, "https://example.com/charliedavis.jpg", false, false, null, null, "Davis", "56789012345678", "222-222-2222" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_GovernorateId",
                table: "Areas",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_Name_GovernorateId",
                table: "Areas",
                columns: new[] { "Name", "GovernorateId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Governorates_Name",
                table: "Governorates",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_AreaId",
                table: "Subscribers",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_GovernorateId",
                table: "Subscribers",
                column: "GovernorateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Governorates");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 7, 24, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 4, 15, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 9, 12, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 6, 4, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 10, 22, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 2, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 9, 2, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 8, 3, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 10, 27, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 7, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 9, 27, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 8, 18, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 7, 4, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 5, 5, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 4, 15, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 914, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 1, 23, 57, 13, 915, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 1, 21, 57, 13, 915, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 1, 21, 57, 13, 915, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 1, 21, 57, 13, 916, DateTimeKind.Utc).AddTicks(971), "AQAAAAIAAYagAAAAEBea2/0J0OOBEQM19s69CJ51OpW1orVxt2lld5k9GOO0D59RmVOD+0Dx+NXzabpY0A==" });
        }
    }
}
