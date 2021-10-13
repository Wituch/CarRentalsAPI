using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalsAPI.Migrations
{
    public partial class RenameReservationNumberColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Rentals",
                newName: "ReservationNumber");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(5036), new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(5821), new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(5872), new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 585, DateTimeKind.Local).AddTicks(8958), new DateTime(2021, 10, 13, 20, 11, 6, 585, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 585, DateTimeKind.Local).AddTicks(9719), new DateTime(2021, 10, 13, 20, 11, 6, 585, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 585, DateTimeKind.Local).AddTicks(9752), new DateTime(2021, 10, 13, 20, 11, 6, 585, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 581, DateTimeKind.Local).AddTicks(8386), new DateTime(2021, 10, 13, 20, 11, 6, 584, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 584, DateTimeKind.Local).AddTicks(3263), new DateTime(2021, 10, 13, 20, 11, 6, 584, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 584, DateTimeKind.Local).AddTicks(3301), new DateTime(2021, 10, 13, 20, 11, 6, 584, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "PriceRates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 585, DateTimeKind.Local).AddTicks(7012), new DateTime(2021, 10, 13, 20, 11, 6, 585, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "PriceRates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 585, DateTimeKind.Local).AddTicks(7734), new DateTime(2021, 10, 13, 20, 11, 6, 585, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(1817), new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(2610), new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(2647), new DateTime(2021, 10, 13, 20, 11, 6, 586, DateTimeKind.Local).AddTicks(2651) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReservationNumber",
                table: "Rentals",
                newName: "Number");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(5640), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(6286), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(6333), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(249), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(890), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(925), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 562, DateTimeKind.Local).AddTicks(1368), new DateTime(2021, 10, 12, 21, 57, 29, 564, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 564, DateTimeKind.Local).AddTicks(5692), new DateTime(2021, 10, 12, 21, 57, 29, 564, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 564, DateTimeKind.Local).AddTicks(5727), new DateTime(2021, 10, 12, 21, 57, 29, 564, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "PriceRates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 565, DateTimeKind.Local).AddTicks(8361), new DateTime(2021, 10, 12, 21, 57, 29, 565, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "PriceRates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 565, DateTimeKind.Local).AddTicks(9058), new DateTime(2021, 10, 12, 21, 57, 29, 565, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(2821), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(3450), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(3482), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(3486) });
        }
    }
}
