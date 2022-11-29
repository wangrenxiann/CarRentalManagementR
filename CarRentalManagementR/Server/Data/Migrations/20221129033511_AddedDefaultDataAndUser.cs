using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagementR.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "5ffe4706-5096-4437-9466-da043f249da9", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "f5393526-67f0-4367-90e7-d54f84f74888", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6b12f75e-639c-483f-838e-efafd9cc0a2c", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEDcEnnLX21YHwofPTOwrrnaRnG976ONVJgRc/yHMKhdGlb8tU2ECrxnACGEQMlRs9w==", null, false, "303fdee1-c2ce-414d-9bf6-4dac1176b6a8", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 11, 35, 10, 513, DateTimeKind.Local).AddTicks(6069), new DateTime(2022, 11, 29, 11, 35, 10, 515, DateTimeKind.Local).AddTicks(2996), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 11, 35, 10, 515, DateTimeKind.Local).AddTicks(3889), new DateTime(2022, 11, 29, 11, 35, 10, 515, DateTimeKind.Local).AddTicks(3894), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(5254), new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(5261), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(5265), new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(5266), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(8695), new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(8700), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(8703), new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(8704), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(8706), new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(8707), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(8708), new DateTime(2022, 11, 29, 11, 35, 10, 516, DateTimeKind.Local).AddTicks(8709), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
