using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalsAPI.Migrations
{
    public partial class UpdateNavigationPropertiesAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Categories_CategoryId",
                table: "Prices");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Cars_CarId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Rentals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "Rentals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "Modified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(249), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(565), "Compact" },
                    { 2, new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(890), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(912), "Premium" },
                    { 3, new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(925), new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(929), "Minivan" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Created", "FirstName", "LastName", "Modified" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 12, 21, 57, 29, 562, DateTimeKind.Local).AddTicks(1368), "John", "Doe", new DateTime(2021, 10, 12, 21, 57, 29, 564, DateTimeKind.Local).AddTicks(5163) },
                    { 2, new DateTime(1965, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 12, 21, 57, 29, 564, DateTimeKind.Local).AddTicks(5692), "George", "Smith", new DateTime(2021, 10, 12, 21, 57, 29, 564, DateTimeKind.Local).AddTicks(5714) },
                    { 3, new DateTime(1991, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 12, 21, 57, 29, 564, DateTimeKind.Local).AddTicks(5727), "Wiliam", "Strong", new DateTime(2021, 10, 12, 21, 57, 29, 564, DateTimeKind.Local).AddTicks(5731) }
                });

            migrationBuilder.InsertData(
                table: "PriceRates",
                columns: new[] { "Id", "Created", "Modified", "Name", "Rate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 12, 21, 57, 29, 565, DateTimeKind.Local).AddTicks(8361), new DateTime(2021, 10, 12, 21, 57, 29, 565, DateTimeKind.Local).AddTicks(8691), "BaseDayRental", 80.0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2021, 10, 12, 21, 57, 29, 565, DateTimeKind.Local).AddTicks(9058), new DateTime(2021, 10, 12, 21, 57, 29, 565, DateTimeKind.Local).AddTicks(9079), "KilometerPrice", 1.0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CategoryId", "Created", "EnginePower", "Model", "Modified", "ProductionDate" },
                values: new object[,]
                {
                    { 1, "Lancia", 1, new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(5640), 1.2, "Ypsilon", new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(5938), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "BMW", 2, new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(6286), 2.0, "320i", new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(6319), new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Citroën", 3, new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(6333), 2.2000000000000002, "C8", new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(6336), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "CategoryId", "Created", "Formula", "Modified", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(2821), "BaseDayRental * NumberOfDays", new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(3109), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(3450), "BaseDayRental * NumberOfDays * 1.2 + KilometerPrice * NumberOfKilometers", new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(3470), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(3482), "BaseDayRental * NumberOfDays * 1.7 + (KilometerPrice * NumberOfKilometers * 1.5)", new DateTime(2021, 10, 12, 21, 57, 29, 566, DateTimeKind.Local).AddTicks(3486), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Categories_CategoryId",
                table: "Prices",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Cars_CarId",
                table: "Rentals",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Categories_CategoryId",
                table: "Prices");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Cars_CarId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PriceRates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PriceRates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Rentals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "Rentals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Prices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Categories_CategoryId",
                table: "Prices",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Cars_CarId",
                table: "Rentals",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
