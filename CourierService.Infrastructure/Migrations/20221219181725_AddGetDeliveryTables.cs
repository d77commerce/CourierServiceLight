using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierService.Infrastructure.Migrations
{
    public partial class AddGetDeliveryTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrackingId",
                table: "Orders");

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TrackingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GetQuickQuotes",
                columns: table => new
                {
                    QuickQuoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParcelKg = table.Column<double>(type: "float", nullable: false),
                    Parts = table.Column<int>(type: "int", nullable: false),
                    SenderCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverCity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetQuickQuotes", x => x.QuickQuoteId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_OrderId",
                table: "Deliveries",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "GetQuickQuotes");

            migrationBuilder.AddColumn<string>(
                name: "TrackingId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
