using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValueData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name","Country" },
                values: new object[] { 1, "Lizette Munoz","Costa Rica" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name","Country" },
                values: new object[] { 5, "Halle", "Japan"});

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name","Country" },
                values: new object[] { 12, "Brewski", "Greece" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
