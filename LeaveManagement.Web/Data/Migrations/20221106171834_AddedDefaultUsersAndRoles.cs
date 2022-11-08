using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b8f8a9e-e015-2241-a14d-31f098dse1ef", "52a6d61a-63a0-4622-8c39-339f463dc876", "User", "USER" },
                    { "0b8f8a9e-e015-2241-a14f-31f096ced1ef", "ccb31fe3-5c9c-4dfd-a5a2-e380dd350340", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3decbeda-ebe7-4fbe-afd2-3095a32791bc", 0, "e5b33add-a888-4fc2-8bdb-28ce28583081", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEC9XdDq4ziYGdPmQ+g5qzmf1TJyKPcKXqZjVVVF3WnAIGj814zMUJGKogiUZnLh7aw==", null, false, "01804179-7fd0-45e1-80dc-a8e0ffe6f566", null, false, null },
                    { "6e7b01b5-71ae-41fd-98f5-d1c8c04a4b1d", 0, "49619d5a-5edd-4e87-a153-f32d3747d5d8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEJlR1+2A6eyLQfHyCg+AuNTt0iIPMr0nn0cJiyl7XfS3SufInjAV+/usSjTr7ZAUsA==", null, false, "1ceaa89b-d01c-41d1-a4cf-d56cad6ec826", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0b8f8a9e-e015-2241-a14d-31f098dse1ef", "3decbeda-ebe7-4fbe-afd2-3095a32791bc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0b8f8a9e-e015-2241-a14f-31f096ced1ef", "6e7b01b5-71ae-41fd-98f5-d1c8c04a4b1d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b8f8a9e-e015-2241-a14d-31f098dse1ef", "3decbeda-ebe7-4fbe-afd2-3095a32791bc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b8f8a9e-e015-2241-a14f-31f096ced1ef", "6e7b01b5-71ae-41fd-98f5-d1c8c04a4b1d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b8f8a9e-e015-2241-a14d-31f098dse1ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b8f8a9e-e015-2241-a14f-31f096ced1ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3decbeda-ebe7-4fbe-afd2-3095a32791bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e7b01b5-71ae-41fd-98f5-d1c8c04a4b1d");

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
