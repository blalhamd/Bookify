using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByUserId", "CreationTime", "DeletedByUserId", "DeletionTime", "FirstModificationByUserId", "FirstModificationDate", "IsDeleted", "LastModificationByUserId", "LastModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 20, 8, 14, 59, 872, DateTimeKind.Local).AddTicks(1862), null, null, null, null, false, null, null, "Fighting" },
                    { 2, 1, new DateTime(2024, 10, 20, 8, 14, 59, 872, DateTimeKind.Local).AddTicks(1933), null, null, null, null, false, null, null, "Adventure" },
                    { 3, 1, new DateTime(2024, 10, 20, 8, 14, 59, 872, DateTimeKind.Local).AddTicks(1937), null, null, null, null, false, null, null, "Fiction" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
