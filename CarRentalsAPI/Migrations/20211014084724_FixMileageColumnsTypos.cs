using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalsAPI.Migrations
{
    public partial class FixMileageColumnsTypos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarMilageAtReturn",
                table: "Rentals",
                newName: "CarMileageAtReturn");

            migrationBuilder.RenameColumn(
                name: "CarMilageAtRent",
                table: "Rentals",
                newName: "CarMileageAtRent");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(1161), new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(2154), new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(2235), new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(2878), new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(3870), new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(3922), new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 726, DateTimeKind.Local).AddTicks(5862), new DateTime(2021, 10, 14, 10, 47, 23, 730, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 730, DateTimeKind.Local).AddTicks(1644), new DateTime(2021, 10, 14, 10, 47, 23, 730, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 730, DateTimeKind.Local).AddTicks(1697), new DateTime(2021, 10, 14, 10, 47, 23, 730, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "PriceRates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(72), new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "PriceRates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(1115), new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(6848), new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(7858), new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(7907), new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(7914) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarMileageAtReturn",
                table: "Rentals",
                newName: "CarMilageAtReturn");

            migrationBuilder.RenameColumn(
                name: "CarMileageAtRent",
                table: "Rentals",
                newName: "CarMilageAtRent");

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
    }
}
