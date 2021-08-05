using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeDatabase.Migrations
{
    public partial class size : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BikeTypeId",
                table: "BikeSizes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BikeTypeId",
                table: "BikeSizes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
