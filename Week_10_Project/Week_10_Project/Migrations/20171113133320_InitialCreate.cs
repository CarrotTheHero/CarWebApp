using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Week_10_Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    BuildYear = table.Column<int>(nullable: false),
                    CarBody = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    FuelType = table.Column<string>(nullable: true),
                    HorsePower = table.Column<int>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Seats = table.Column<int>(nullable: false),
                    Torque = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
