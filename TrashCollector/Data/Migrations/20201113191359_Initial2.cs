using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d188d1d-fb6a-4673-b84d-8094dc4f5ae9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "baf3cd45-1b23-47e2-98e1-e6bb6c716ba4", "fbcb5316-94c9-492f-b776-0c751ee79c52", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baf3cd45-1b23-47e2-98e1-e6bb6c716ba4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d188d1d-fb6a-4673-b84d-8094dc4f5ae9", "dd9fa748-b1b0-4017-88b5-01efaa53e901", "Admin", "ADMIN" });
        }
    }
}
