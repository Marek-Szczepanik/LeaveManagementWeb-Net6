using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b8f8a9e-e015-2241-a14d-31f098dse1ef",
                column: "ConcurrencyStamp",
                value: "b9f07620-cb9c-4b89-ae38-774eb12eb332");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b8f8a9e-e015-2241-a14f-31f096ced1ef",
                column: "ConcurrencyStamp",
                value: "43087c6e-546d-4e91-a63e-e92a113af3d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3decbeda-ebe7-4fbe-afd2-3095a32791bc",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2bbcbf1b-876f-43e3-bec5-5b624306c983", "user@localhost.com", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHOzU3Y8BIS2VDduZV63LRq4CStATKIE8QOYOvc9q+uiIMZjYuAKEOvcnPYCBiEQ1A==", "6a9d1fdb-4b3e-466e-86ca-63b0929d7cdd", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e7b01b5-71ae-41fd-98f5-d1c8c04a4b1d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "424aa8b9-3ba8-4caf-93bb-ea5b557756fb", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKDR9J4Tgr/AuX4knNKHuV7ngXsegKpzFNZ45uTTl/m88ZXI6TgCZLvNy/f5M6FvvQ==", "f5465656-c49c-40db-a4d7-8799157507c4", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b8f8a9e-e015-2241-a14d-31f098dse1ef",
                column: "ConcurrencyStamp",
                value: "52a6d61a-63a0-4622-8c39-339f463dc876");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b8f8a9e-e015-2241-a14f-31f096ced1ef",
                column: "ConcurrencyStamp",
                value: "ccb31fe3-5c9c-4dfd-a5a2-e380dd350340");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3decbeda-ebe7-4fbe-afd2-3095a32791bc",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e5b33add-a888-4fc2-8bdb-28ce28583081", "admin@localhost.com", false, null, "AQAAAAEAACcQAAAAEC9XdDq4ziYGdPmQ+g5qzmf1TJyKPcKXqZjVVVF3WnAIGj814zMUJGKogiUZnLh7aw==", "01804179-7fd0-45e1-80dc-a8e0ffe6f566", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e7b01b5-71ae-41fd-98f5-d1c8c04a4b1d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "49619d5a-5edd-4e87-a153-f32d3747d5d8", false, null, "AQAAAAEAACcQAAAAEJlR1+2A6eyLQfHyCg+AuNTt0iIPMr0nn0cJiyl7XfS3SufInjAV+/usSjTr7ZAUsA==", "1ceaa89b-d01c-41d1-a4cf-d56cad6ec826", null });
        }
    }
}
