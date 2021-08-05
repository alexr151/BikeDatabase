using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeDatabase.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BikeColor",
                columns: table => new
                {
                    BikeColorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeColor", x => x.BikeColorId);
                });

            migrationBuilder.CreateTable(
                name: "BikeSize",
                columns: table => new
                {
                    BikeSizeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BikeTypeId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeSize", x => x.BikeSizeId);
                });

            migrationBuilder.CreateTable(
                name: "BikeType",
                columns: table => new
                {
                    BikeTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeType", x => x.BikeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "GearNumber",
                columns: table => new
                {
                    GearNumberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Gear = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearNumber", x => x.GearNumberId);
                });

            migrationBuilder.CreateTable(
                name: "TireSize",
                columns: table => new
                {
                    TireSizeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tire = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TireSize", x => x.TireSizeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    BikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BikeSizeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GearNumberId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BikeColorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BikeTypeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TireSizeId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.BikeId);
                    table.ForeignKey(
                        name: "FK_Bikes_BikeColor_BikeColorId",
                        column: x => x.BikeColorId,
                        principalTable: "BikeColor",
                        principalColumn: "BikeColorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bikes_BikeSize_BikeSizeId",
                        column: x => x.BikeSizeId,
                        principalTable: "BikeSize",
                        principalColumn: "BikeSizeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bikes_BikeType_BikeTypeId",
                        column: x => x.BikeTypeId,
                        principalTable: "BikeType",
                        principalColumn: "BikeTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bikes_GearNumber_GearNumberId",
                        column: x => x.GearNumberId,
                        principalTable: "GearNumber",
                        principalColumn: "GearNumberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bikes_TireSize_TireSizeId",
                        column: x => x.TireSizeId,
                        principalTable: "TireSize",
                        principalColumn: "TireSizeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BikeColor",
                columns: new[] { "BikeColorId", "Color" },
                values: new object[,]
                {
                    { "red", "Red" },
                    { "org", "Orange" },
                    { "brz", "Bronze" },
                    { "slv", "Silver" },
                    { "blk", "Black" },
                    { "wht", "White" },
                    { "gld", "Gold" },
                    { "pnk", "Pink" },
                    { "purp", "Purple" },
                    { "grn", "Green" },
                    { "blue", "Blue" },
                    { "ylw", "Yellow" }
                });

            migrationBuilder.InsertData(
                table: "BikeSize",
                columns: new[] { "BikeSizeId", "BikeTypeId", "Size" },
                values: new object[,]
                {
                    { "17", null, "17in" },
                    { "13", null, "13in" },
                    { "14", null, "14in" },
                    { "15", null, "15in" },
                    { "16", null, "16in" },
                    { "18", null, "18in" },
                    { "24", null, "24in" },
                    { "20", null, "20in" },
                    { "21", null, "21in" },
                    { "22", null, "22in" },
                    { "23", null, "23in" },
                    { "63", null, "63cm" },
                    { "19", null, "19in" },
                    { "62", null, "62cm" },
                    { "58", null, "58cm" },
                    { "60", null, "60cm" },
                    { "47", null, "47cm" },
                    { "48", null, "48cm" },
                    { "49", null, "49cm" },
                    { "50", null, "50cm" },
                    { "61", null, "61cm" },
                    { "52", null, "52cm" },
                    { "51", null, "51cm" },
                    { "54", null, "54cm" },
                    { "55", null, "55cm" },
                    { "56", null, "56cm" },
                    { "57", null, "57cm" },
                    { "59", null, "59cm" },
                    { "53", null, "53cm" }
                });

            migrationBuilder.InsertData(
                table: "BikeType",
                columns: new[] { "BikeTypeId", "Type" },
                values: new object[] { "hyb", "Hybrid" });

            migrationBuilder.InsertData(
                table: "BikeType",
                columns: new[] { "BikeTypeId", "Type" },
                values: new object[,]
                {
                    { "rec", "Recumbant" },
                    { "elc", "Electric" },
                    { "bmx", "BMX" },
                    { "kid", "Children's" },
                    { "fit", "Fitness" },
                    { "cc", "CycloCross" },
                    { "cmf", "Comfort" },
                    { "com", "Commuter" },
                    { "mtn", "Mountain" },
                    { "rd", "Road" },
                    { "cru", "Cruiser" }
                });

            migrationBuilder.InsertData(
                table: "GearNumber",
                columns: new[] { "GearNumberId", "Gear" },
                values: new object[,]
                {
                    { "3x12", "3 X 12" },
                    { "3x11", "3 X 11" },
                    { "3x10", "3 X 10" },
                    { "3x9", "3 X 9" },
                    { "3x8", "3 X 8" },
                    { "3x7", "3 X 7" },
                    { "3x6", "3 X 6" },
                    { "2x12", "2 X 12" },
                    { "2x11", "2 X 11" },
                    { "2x9", "2 X 9" },
                    { "2x8", "2 X 8" },
                    { "2x10", "2 X 10" },
                    { "2x6", "2 X 6" },
                    { "2x7", "2 X 7" },
                    { "1x1", "Single Speed" },
                    { "1x4", "1x4" },
                    { "1x6", "1x6" },
                    { "1x7", "1x7" },
                    { "1x3", "1x3" },
                    { "1x9", "1x9" },
                    { "1x10", "1x10" },
                    { "1x11", "1x11" },
                    { "1x12", "1x12" },
                    { "1x8", "1x8" }
                });

            migrationBuilder.InsertData(
                table: "TireSize",
                columns: new[] { "TireSizeId", "Tire" },
                values: new object[,]
                {
                    { "12.5x2.25", "12 1/2 x 2 1/4" },
                    { "12x1.75", "12 x 1.75" },
                    { "12x1.9", "12 x 1.90" },
                    { "12.5x1.75", "12 1/2 x 1.75" },
                    { "12.5x1.9", "12 1/2 x 1.90" },
                    { "12x2", "12 x 2.00" },
                    { "12x1.95", "12 x 1.95" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "DOB", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2, new DateTime(1997, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ashley@green.com", "Ashley", "Green" },
                    { 3, new DateTime(2016, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "olive@green.com", "Olive", "Green" },
                    { 1, new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "alex@ryberg.com", "Alex", "Ryberg" },
                    { 4, new DateTime(1997, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "nick@gunther.com", "Nick", "Gunther" }
                });

            migrationBuilder.InsertData(
                table: "Bikes",
                columns: new[] { "BikeId", "BikeColorId", "BikeSizeId", "BikeTypeId", "GearNumberId", "Make", "Model", "TireSizeId" },
                values: new object[,]
                {
                    { 1, "blue", "58", "rd", "2x7", "Masi", "Inizio", "12x2" },
                    { 2, "grn", "60", "com", "2x11", "Trek", "520", "12x2" },
                    { 3, "red", "56", "hyb", "3x8", "Giant", "Escape 3", "12x2" },
                    { 4, "gld", "16", "cru", "1x3", "Townie", "Cruiser 2", "12x2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_BikeColorId",
                table: "Bikes",
                column: "BikeColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_BikeSizeId",
                table: "Bikes",
                column: "BikeSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_BikeTypeId",
                table: "Bikes",
                column: "BikeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_GearNumberId",
                table: "Bikes",
                column: "GearNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_TireSizeId",
                table: "Bikes",
                column: "TireSizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bikes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BikeColor");

            migrationBuilder.DropTable(
                name: "BikeSize");

            migrationBuilder.DropTable(
                name: "BikeType");

            migrationBuilder.DropTable(
                name: "GearNumber");

            migrationBuilder.DropTable(
                name: "TireSize");
        }
    }
}
