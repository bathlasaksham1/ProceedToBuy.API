using Microsoft.EntityFrameworkCore.Migrations;

namespace ProceedToBuy.API.Migrations
{
    public partial class addedQuantityInDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CustomerCarts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CustomerCarts");
        }
    }
}
