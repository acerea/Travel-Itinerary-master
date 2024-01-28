using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travel_Itinerary.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Bookings",
                newName: "DateOut");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Bookings",
                newName: "DateIn");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a984a918-7262-4f69-abbe-d833f2f2f949", "AQAAAAIAAYagAAAAEL2YrZSkfQtzs/QTj+NYb3vuBBq4bgEAZL7EEa4k+NrAjN+CiSrttCuk/5sYRFv7zA==", "86518cf9-0466-4e13-bcfa-8afed626111e" });

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 12, 43, 41, 833, DateTimeKind.Local).AddTicks(713), new DateTime(2024, 1, 27, 12, 43, 41, 833, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 12, 43, 41, 833, DateTimeKind.Local).AddTicks(738), new DateTime(2024, 1, 27, 12, 43, 41, 833, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "TravelDocs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 12, 43, 41, 833, DateTimeKind.Local).AddTicks(1417), new DateTime(2024, 1, 27, 12, 43, 41, 833, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "TravelDocs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 12, 43, 41, 833, DateTimeKind.Local).AddTicks(1422), new DateTime(2024, 1, 27, 12, 43, 41, 833, DateTimeKind.Local).AddTicks(1423) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOut",
                table: "Bookings",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DateIn",
                table: "Bookings",
                newName: "EndDate");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e4a7921-29a7-4903-826d-0a692ad411b8", "AQAAAAIAAYagAAAAEGoQ4nXnmvXmwDC1D2q7RyH1qpnpbUzS2At5CA9RBklIIJCmRQMO2M0Rj69NsqCJZQ==", "c8f250c8-c977-403a-8f97-e5e41f3e7e92" });

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 0, 20, 369, DateTimeKind.Local).AddTicks(4177), new DateTime(2024, 1, 24, 17, 0, 20, 369, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 0, 20, 369, DateTimeKind.Local).AddTicks(4194), new DateTime(2024, 1, 24, 17, 0, 20, 369, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "TravelDocs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 0, 20, 369, DateTimeKind.Local).AddTicks(4576), new DateTime(2024, 1, 24, 17, 0, 20, 369, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "TravelDocs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 0, 20, 369, DateTimeKind.Local).AddTicks(4578), new DateTime(2024, 1, 24, 17, 0, 20, 369, DateTimeKind.Local).AddTicks(4579) });
        }
    }
}
