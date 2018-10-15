using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class RemovingRequiredConditionFromCityinProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "759fb47e-3336-4a74-a7b5-f720e1d632fc", "200ec8fb-c75d-4cb7-ac0f-a93d833e4714" });

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c3dd9f0a-b502-495a-bff0-d97fe7aefde7", 0, "e7b88f38-8fc4-42d1-913a-46b97f7ff6fc", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENOF4QUDeb3mXCePXekzSVsJ4KRege55fznuTZK9zYVJ7a+ZoUQvJb12AZ4734H9Cg==", null, false, "105bd334-0ff2-43f1-94fe-3da37ee68e16", "123 Infinity Way", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c3dd9f0a-b502-495a-bff0-d97fe7aefde7" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c3dd9f0a-b502-495a-bff0-d97fe7aefde7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c3dd9f0a-b502-495a-bff0-d97fe7aefde7", "e7b88f38-8fc4-42d1-913a-46b97f7ff6fc" });

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "759fb47e-3336-4a74-a7b5-f720e1d632fc", 0, "200ec8fb-c75d-4cb7-ac0f-a93d833e4714", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEF5kZmZHsEHFgP4PgzeoT7beK6qoc7NZE3ZWvX0QMuCioLfiK3+Gd8RnPWrKnpFT6Q==", null, false, "ba343658-3f9c-4439-af0d-4a4e0513f470", "123 Infinity Way", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "759fb47e-3336-4a74-a7b5-f720e1d632fc" });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "759fb47e-3336-4a74-a7b5-f720e1d632fc" });
        }
    }
}
