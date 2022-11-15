using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_SLAY.Migrations
{
    public partial class AddTranNO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionNo",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionNo",
                table: "Transactions");
        }
    }
}
