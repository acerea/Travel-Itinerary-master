using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travel_Itinerary.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addApplicationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BookingLocation",
                table: "Bookings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookingEmail",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ef774b5-fda0-4ede-8933-977e6b35882b", "AQAAAAIAAYagAAAAENNimyI3HKscfGZ5NKOZ0VRrg/BJegupy5OjGMzQ9fYdLTXNYHusRLoV/mR+aIIywA==", "3c714231-f9e1-4343-a00d-60912137d650" });

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 39, 56, 987, DateTimeKind.Local).AddTicks(1611), new DateTime(2024, 2, 2, 14, 39, 56, 987, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 39, 56, 987, DateTimeKind.Local).AddTicks(1636), new DateTime(2024, 2, 2, 14, 39, 56, 987, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "TravelDocs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 39, 56, 987, DateTimeKind.Local).AddTicks(2291), new DateTime(2024, 2, 2, 14, 39, 56, 987, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "TravelDocs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 39, 56, 987, DateTimeKind.Local).AddTicks(2299), new DateTime(2024, 2, 2, 14, 39, 56, 987, DateTimeKind.Local).AddTicks(2300) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BookingLocation",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "BookingEmail",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e2559e8-af8a-494c-8030-f60623ea754e", "AQAAAAIAAYagAAAAEOzNooUNJXBueb5EZISBvMlUX6GOk82DCPxoD7Qx75tLvcgnwDtepjgaaTrDYrIRUw==", "04ed65ce-a13c-41d0-b8e7-6c16dcc0e2e6" });

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 18, 45, 513, DateTimeKind.Local).AddTicks(5880), new DateTime(2024, 2, 2, 14, 18, 45, 513, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 18, 45, 513, DateTimeKind.Local).AddTicks(5899), new DateTime(2024, 2, 2, 14, 18, 45, 513, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "TravelDocs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 18, 45, 513, DateTimeKind.Local).AddTicks(6286), new DateTime(2024, 2, 2, 14, 18, 45, 513, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "TravelDocs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 18, 45, 513, DateTimeKind.Local).AddTicks(6289), new DateTime(2024, 2, 2, 14, 18, 45, 513, DateTimeKind.Local).AddTicks(6290) });
        }
    }
}
