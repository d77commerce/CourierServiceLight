using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierService.Infrastructure.Migrations
{
    public partial class seedOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerMessage", "DateTime", "IsFragile", "ParcelKg", "Parts", "ReceiverAddressLine1", "ReceiverAddressLine2", "ReceiverCity", "ReceiverCountry", "ReceiverFirstName", "ReceiverLastName", "ReceiverPhone", "ReceiverPostcode", "ReceiverStreet", "SenderAddressLine1", "SenderAddressLine2", "SenderCity", "SenderCountry", "SenderFirstName", "SenderLastName", "SenderMail", "SenderPhone", "SenderPostcode", "SenderStreet" },
                values: new object[] { 1, "Delivery all day before 12:00 !", new DateTime(2022, 12, 23, 1, 30, 37, 857, DateTimeKind.Local).AddTicks(6831), true, 2.456, 2, null, null, "Pleven", "Bulgaria", "Radka", "Piratka", "+359896121478", "5400", "Nezabravka 4", null, null, "Sofia", "Bulgaria", "Pepo", "Ivanov", "kakapepa@abv.bg", "+4478976746", "1000", "Vitosha 23" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
