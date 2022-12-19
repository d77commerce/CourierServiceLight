using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierService.Infrastructure.Migrations.TrackingDb
{
    public partial class trackingUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeliveryPostcode",
                table: "Tracking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrackingNo",
                table: "Tracking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Tracking",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryPostcode",
                table: "Tracking");

            migrationBuilder.DropColumn(
                name: "TrackingNo",
                table: "Tracking");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tracking");
        }
    }
}
