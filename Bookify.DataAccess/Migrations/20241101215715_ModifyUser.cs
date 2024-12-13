using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModifyUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "UserManagement",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: DateTime.Now);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "UserManagement",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "UserManagement",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: DateTime.Now);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "UserManagement",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 11, 1, 21, 57, 13, 915, DateTimeKind.Utc).AddTicks(7879), false });

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 11, 1, 21, 57, 13, 915, DateTimeKind.Utc).AddTicks(7935), false });

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "IsDeleted", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 1, 21, 57, 13, 916, DateTimeKind.Utc).AddTicks(971), false, "AQAAAAIAAYagAAAAEBea2/0J0OOBEQM19s69CJ51OpW1orVxt2lld5k9GOO0D59RmVOD+0Dx+NXzabpY0A==" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                schema: "UserManagement",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                schema: "UserManagement",
                table: "Users",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                schema: "UserManagement",
                table: "Roles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                schema: "UserManagement",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                schema: "UserManagement",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Roles_Name",
                schema: "UserManagement",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "UserManagement",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "UserManagement",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "UserManagement",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "UserManagement",
                table: "Roles");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 695, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 7, 23, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 4, 14, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 9, 11, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 6, 3, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 10, 21, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 1, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 9, 1, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 8, 2, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 10, 26, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 6, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2024, 9, 26, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2024, 8, 17, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2024, 7, 3, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2024, 5, 4, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "BookCopies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2024, 4, 14, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 10, 31, 23, 30, 5, 696, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM/WLu8nYCrVGzMjTONE7m+lt9D7hWuWdeuOpxViDjNEn++S7hbGEIALd7MikIbxxA==");
        }
    }
}
