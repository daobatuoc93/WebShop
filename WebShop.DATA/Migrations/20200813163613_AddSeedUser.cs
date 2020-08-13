using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.DATA.Migrations
{
    public partial class AddSeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "App User Roles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("42d93ce2-e383-4ce9-9b31-e99d56ed7fa3"), new Guid("4d685845-5f78-4c41-87b6-e4f49c3d490e") });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("4d685845-5f78-4c41-87b6-e4f49c3d490e"), "286547d1-1b41-4e3b-95d1-8076a4485630", "Administrator role", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("42d93ce2-e383-4ce9-9b31-e99d56ed7fa3"), 0, "69c35d43-6215-4270-9ca2-eef9628d064f", new DateTime(1993, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuocdaoba@icloud.com", true, "Dao Ba", "Tuoc", false, null, "tuocdaoba@icloud.com", "tuocdaoba", "AQAAAAEAACcQAAAAEHNgAkuwVMH7/woT0TaQVASa4wq0ABH6yezd336wBrE6N3KV3s7J+uf3Pxq5337/6A==", null, false, "", false, "tuocdaoba" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 13, 23, 36, 12, 526, DateTimeKind.Local).AddTicks(6054));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "App User Roles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("42d93ce2-e383-4ce9-9b31-e99d56ed7fa3"), new Guid("4d685845-5f78-4c41-87b6-e4f49c3d490e") });

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4d685845-5f78-4c41-87b6-e4f49c3d490e"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("42d93ce2-e383-4ce9-9b31-e99d56ed7fa3"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 13, 23, 15, 31, 7, DateTimeKind.Local).AddTicks(8791));
        }
    }
}
