using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b8f8a9e-e015-2241-a14d-31f098dse1ef",
                column: "ConcurrencyStamp",
                value: "1ba61b95-71e5-4ac8-8c4f-d4523a64c072");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b8f8a9e-e015-2241-a14f-31f096ced1ef",
                column: "ConcurrencyStamp",
                value: "413de3cb-e980-49ad-a879-1070829c34d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3decbeda-ebe7-4fbe-afd2-3095a32791bc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "859c1131-04fd-405c-971a-863e2bb5cf13", "AQAAAAEAACcQAAAAEECFS1bDPV8UVsSPqIzFQSsyyfpzk8sc5eaoOjvRU/CiffYTwiOcJWWX/EddnrpAjg==", "73af551b-d005-42b8-93a8-fd71d771db32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e7b01b5-71ae-41fd-98f5-d1c8c04a4b1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9d45ada-dc10-4f80-9085-aeeae90943e5", "AQAAAAEAACcQAAAAEGIqxuMr4KlBDGPBMSLh8fR+nLEcbb98fYQ4XPAIF/lCkBjMFjfNPnm6pKkVW5uwIg==", "a5f2e48a-dfe7-4d9d-82b0-94d4941b5a67" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bbcbf1b-876f-43e3-bec5-5b624306c983", "AQAAAAEAACcQAAAAEHOzU3Y8BIS2VDduZV63LRq4CStATKIE8QOYOvc9q+uiIMZjYuAKEOvcnPYCBiEQ1A==", "6a9d1fdb-4b3e-466e-86ca-63b0929d7cdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e7b01b5-71ae-41fd-98f5-d1c8c04a4b1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "424aa8b9-3ba8-4caf-93bb-ea5b557756fb", "AQAAAAEAACcQAAAAEKDR9J4Tgr/AuX4knNKHuV7ngXsegKpzFNZ45uTTl/m88ZXI6TgCZLvNy/f5M6FvvQ==", "f5465656-c49c-40db-a4d7-8799157507c4" });
        }
    }
}
