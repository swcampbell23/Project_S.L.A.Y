using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_SLAY.Migrations
{
    public partial class updateStockTransaction2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalTransactionPrice",
                table: "StockTransactions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalTransactionPrice",
                table: "StockTransactions");
        }
    }
}
