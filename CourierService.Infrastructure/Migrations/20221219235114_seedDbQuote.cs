using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierService.Infrastructure.Migrations
{
    public partial class seedDbQuote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GetQuickQuotes",
                columns: new[] { "QuickQuoteId", "ParcelKg", "Parts", "ReceiverCity", "ReceiverCountry", "SenderCity", "SenderCountry" },
                values: new object[] { 1, 10.0, 2, "Lovech", "Bulgaria", "Sofia", "Bulgaria" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GetQuickQuotes",
                keyColumn: "QuickQuoteId",
                keyValue: 1);
        }
    }
}
