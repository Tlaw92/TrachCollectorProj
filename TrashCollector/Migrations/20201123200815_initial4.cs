using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01e71493-04d2-4254-bdb2-186050e4d332");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8c57e6b-5022-4abe-b5d6-83320a364b9a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36ed2b64-e030-4d28-8c42-3e971ae100f3", "f90b59bd-6fc1-4312-8ef8-9a365a485a9e", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbe1796b-1f88-4aa5-b5c8-76ba6866bf75", "1208bb77-3a8e-4746-bca6-3825a53eed92", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36ed2b64-e030-4d28-8c42-3e971ae100f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbe1796b-1f88-4aa5-b5c8-76ba6866bf75");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f8c57e6b-5022-4abe-b5d6-83320a364b9a", "76614496-f28d-4c34-b19d-c069ac3ac05b", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01e71493-04d2-4254-bdb2-186050e4d332", "841dc516-bcc5-4812-b058-ece133f8c6aa", "Customer", "CUSTOMER" });
        }
    }
}
