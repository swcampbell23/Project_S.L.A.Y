using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_SLAY.Migrations
{
    public partial class updatedStockModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StockInformation",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockInformation",
                table: "Stocks");
        }
    }
}
