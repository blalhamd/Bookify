using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRestrictBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Governorates_GovernorateId",
                table: "Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategories_Books_BookId",
                table: "BookCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategories_Categories_CategoryId",
                table: "BookCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCopies_Books_BookId",
                table: "BookCopies");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "UserManagement",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_Areas_AreaId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_Governorates_GovernorateId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "UserManagement",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_Users_UserId",
                schema: "UserManagement",
                table: "UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                schema: "UserManagement",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "UserManagement",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToken_Users_UserId",
                schema: "UserManagement",
                table: "UserToken");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Governorates_GovernorateId",
                table: "Areas",
                column: "GovernorateId",
                principalTable: "Governorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategories_Books_BookId",
                table: "BookCategories",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategories_Categories_CategoryId",
                table: "BookCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCopies_Books_BookId",
                table: "BookCopies",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "UserManagement",
                table: "RoleClaims",
                column: "RoleId",
                principalSchema: "UserManagement",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_Areas_AreaId",
                table: "Subscribers",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_Governorates_GovernorateId",
                table: "Subscribers",
                column: "GovernorateId",
                principalTable: "Governorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "UserManagement",
                table: "UserClaims",
                column: "UserId",
                principalSchema: "UserManagement",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_Users_UserId",
                schema: "UserManagement",
                table: "UserLogin",
                column: "UserId",
                principalSchema: "UserManagement",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                schema: "UserManagement",
                table: "UserRoles",
                column: "RoleId",
                principalSchema: "UserManagement",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "UserManagement",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "UserManagement",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToken_Users_UserId",
                schema: "UserManagement",
                table: "UserToken",
                column: "UserId",
                principalSchema: "UserManagement",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Governorates_GovernorateId",
                table: "Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategories_Books_BookId",
                table: "BookCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategories_Categories_CategoryId",
                table: "BookCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCopies_Books_BookId",
                table: "BookCopies");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "UserManagement",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_Areas_AreaId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_Governorates_GovernorateId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "UserManagement",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_Users_UserId",
                schema: "UserManagement",
                table: "UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                schema: "UserManagement",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "UserManagement",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToken_Users_UserId",
                schema: "UserManagement",
                table: "UserToken");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 663, DateTimeKind.Local).AddTicks(4290));

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

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 664, DateTimeKind.Local).AddTicks(8990));

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
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 732, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 732, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 732, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 732, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Subscribers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2024, 11, 17, 17, 35, 58, 732, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                schema: "UserManagement",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 35, 58, 665, DateTimeKind.Local).AddTicks(3205), "AQAAAAIAAYagAAAAECdeHxQ0eD2Y4fvEnAquGyT/uxHvJvoheCkpYbTaLZ/vRjO5ceH/eg35BjEhVwaZMg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Governorates_GovernorateId",
                table: "Areas",
                column: "GovernorateId",
                principalTable: "Governorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategories_Books_BookId",
                table: "BookCategories",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategories_Categories_CategoryId",
                table: "BookCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCopies_Books_BookId",
                table: "BookCopies",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "UserManagement",
                table: "RoleClaims",
                column: "RoleId",
                principalSchema: "UserManagement",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_Areas_AreaId",
                table: "Subscribers",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_Governorates_GovernorateId",
                table: "Subscribers",
                column: "GovernorateId",
                principalTable: "Governorates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "UserManagement",
                table: "UserClaims",
                column: "UserId",
                principalSchema: "UserManagement",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_Users_UserId",
                schema: "UserManagement",
                table: "UserLogin",
                column: "UserId",
                principalSchema: "UserManagement",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                schema: "UserManagement",
                table: "UserRoles",
                column: "RoleId",
                principalSchema: "UserManagement",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "UserManagement",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "UserManagement",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToken_Users_UserId",
                schema: "UserManagement",
                table: "UserToken",
                column: "UserId",
                principalSchema: "UserManagement",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
