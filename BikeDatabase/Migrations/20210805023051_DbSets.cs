using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeDatabase.Migrations
{
    public partial class DbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_BikeColor_BikeColorId",
                table: "Bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_BikeSize_BikeSizeId",
                table: "Bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_BikeType_BikeTypeId",
                table: "Bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_GearNumber_GearNumberId",
                table: "Bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_TireSize_TireSizeId",
                table: "Bikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TireSize",
                table: "TireSize");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GearNumber",
                table: "GearNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BikeType",
                table: "BikeType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BikeSize",
                table: "BikeSize");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BikeColor",
                table: "BikeColor");

            migrationBuilder.RenameTable(
                name: "TireSize",
                newName: "TireSizes");

            migrationBuilder.RenameTable(
                name: "GearNumber",
                newName: "GearNumbers");

            migrationBuilder.RenameTable(
                name: "BikeType",
                newName: "BikeTypes");

            migrationBuilder.RenameTable(
                name: "BikeSize",
                newName: "BikeSizes");

            migrationBuilder.RenameTable(
                name: "BikeColor",
                newName: "BikeColors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TireSizes",
                table: "TireSizes",
                column: "TireSizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GearNumbers",
                table: "GearNumbers",
                column: "GearNumberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BikeTypes",
                table: "BikeTypes",
                column: "BikeTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BikeSizes",
                table: "BikeSizes",
                column: "BikeSizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BikeColors",
                table: "BikeColors",
                column: "BikeColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_BikeColors_BikeColorId",
                table: "Bikes",
                column: "BikeColorId",
                principalTable: "BikeColors",
                principalColumn: "BikeColorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_BikeSizes_BikeSizeId",
                table: "Bikes",
                column: "BikeSizeId",
                principalTable: "BikeSizes",
                principalColumn: "BikeSizeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_BikeTypes_BikeTypeId",
                table: "Bikes",
                column: "BikeTypeId",
                principalTable: "BikeTypes",
                principalColumn: "BikeTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_GearNumbers_GearNumberId",
                table: "Bikes",
                column: "GearNumberId",
                principalTable: "GearNumbers",
                principalColumn: "GearNumberId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_TireSizes_TireSizeId",
                table: "Bikes",
                column: "TireSizeId",
                principalTable: "TireSizes",
                principalColumn: "TireSizeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_BikeColors_BikeColorId",
                table: "Bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_BikeSizes_BikeSizeId",
                table: "Bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_BikeTypes_BikeTypeId",
                table: "Bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_GearNumbers_GearNumberId",
                table: "Bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_TireSizes_TireSizeId",
                table: "Bikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TireSizes",
                table: "TireSizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GearNumbers",
                table: "GearNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BikeTypes",
                table: "BikeTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BikeSizes",
                table: "BikeSizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BikeColors",
                table: "BikeColors");

            migrationBuilder.RenameTable(
                name: "TireSizes",
                newName: "TireSize");

            migrationBuilder.RenameTable(
                name: "GearNumbers",
                newName: "GearNumber");

            migrationBuilder.RenameTable(
                name: "BikeTypes",
                newName: "BikeType");

            migrationBuilder.RenameTable(
                name: "BikeSizes",
                newName: "BikeSize");

            migrationBuilder.RenameTable(
                name: "BikeColors",
                newName: "BikeColor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TireSize",
                table: "TireSize",
                column: "TireSizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GearNumber",
                table: "GearNumber",
                column: "GearNumberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BikeType",
                table: "BikeType",
                column: "BikeTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BikeSize",
                table: "BikeSize",
                column: "BikeSizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BikeColor",
                table: "BikeColor",
                column: "BikeColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_BikeColor_BikeColorId",
                table: "Bikes",
                column: "BikeColorId",
                principalTable: "BikeColor",
                principalColumn: "BikeColorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_BikeSize_BikeSizeId",
                table: "Bikes",
                column: "BikeSizeId",
                principalTable: "BikeSize",
                principalColumn: "BikeSizeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_BikeType_BikeTypeId",
                table: "Bikes",
                column: "BikeTypeId",
                principalTable: "BikeType",
                principalColumn: "BikeTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_GearNumber_GearNumberId",
                table: "Bikes",
                column: "GearNumberId",
                principalTable: "GearNumber",
                principalColumn: "GearNumberId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_TireSize_TireSizeId",
                table: "Bikes",
                column: "TireSizeId",
                principalTable: "TireSize",
                principalColumn: "TireSizeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
