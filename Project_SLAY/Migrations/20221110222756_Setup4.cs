using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_SLAY.Migrations
{
    public partial class Setup4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AccountNo",
                table: "StockPortfolios",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNo",
                table: "StockPortfolios");
        }
    }
}
