using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaptopsCoreMVC.Data.Migrations
{
    public partial class UpdateLaptop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laptop",
                columns: table => new
                {
                    LaptopID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(maxLength: 20, nullable: false),
                    RamSize = table.Column<int>(nullable: false),
                    MemorySize = table.Column<int>(nullable: false),
                    LaptopDimensions = table.Column<string>(maxLength: 20, nullable: false),
                    OperatingSystem = table.Column<string>(maxLength: 20, nullable: false),
                    Model = table.Column<string>(maxLength: 20, nullable: false),
                    Resolution = table.Column<string>(maxLength: 20, nullable: false),
                    Processor = table.Column<string>(maxLength: 20, nullable: false),
                    BatteryLife = table.Column<int>(maxLength: 20, nullable: false),
                    Colour = table.Column<int>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptop", x => x.LaptopID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptop");
        }
    }
}
