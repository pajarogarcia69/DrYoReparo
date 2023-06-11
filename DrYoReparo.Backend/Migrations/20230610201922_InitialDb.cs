using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrYoReparo.Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdersServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateIncome = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateWithdrawal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameOwner = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastnameOwner = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CommentTechnical = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RepairStatus = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    RepairValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersServices", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersServices");
        }
    }
}
