using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierService.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackingId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SenderFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiverFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParcelKg = table.Column<double>(type: "float", nullable: false),
                    Parts = table.Column<int>(type: "int", nullable: false),
                    IsFragile = table.Column<bool>(type: "bit", nullable: false),
                    SenderCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderStreet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderAddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderAddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderPostcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverStreet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverAddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiverAddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiverPostcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerMessage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
