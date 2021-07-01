using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParksApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Location = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    AreaKmSquared = table.Column<float>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "varchar(600) CHARACTER SET utf8mb4", maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "AreaKmSquared", "Description", "Location", "Name" },
                values: new object[] { 1, 956.6f, "Mount Rainier, an active stratovolcano, is the most prominent peak in the Cascades and is covered by 26 named glaciers including Carbon Glacier and Emmons Glacier, the longest and largest in the contiguous United States respectively. The mountain is popular for climbing, and more than half of the park is covered by subalpine and alpine forests and meadows seasonally in bloom with wildflowers. Paradise on the south slope is among the snowiest places on Earth. The Longmire visitor center is the start of the Wonderland Trail, which encircles the mountain.", "Washington", "Mount Rainieir" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "AreaKmSquared", "Description", "Location", "Name" },
                values: new object[] { 2, 595.9f, "4,488,268	Located at the junction of the Colorado Plateau, Great Basin, and Mojave Desert, this park contains sandstone features such as mesas, rock towers, and canyons, including the Virgin River Narrows. The various sandstone formations and the forks of the Virgin River create a wilderness divided into four ecosystems: desert, riparian, woodland, and coniferous forest.", "Utah", "Zion" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
