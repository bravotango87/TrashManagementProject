using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Migrations
{
    public partial class Kefefef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c33538a-f02f-4f6b-a95e-b93326bcad4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca3c144-53df-4419-a739-a86f36b98e1f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e08f0d10-025c-46e8-b80e-c9cf82462748", "fd0cf279-3f2e-475b-bbe4-2b83186c17ef", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aaef1f59-c17d-478e-adba-9549094f81c1", "2597f2e4-dc16-4c1f-95f4-97dfa3e3ee10", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaef1f59-c17d-478e-adba-9549094f81c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e08f0d10-025c-46e8-b80e-c9cf82462748");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c33538a-f02f-4f6b-a95e-b93326bcad4b", "de24d889-3688-4904-95d4-489151e2a567", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ca3c144-53df-4419-a739-a86f36b98e1f", "75e69b09-1044-4a62-b28d-954dac769002", "Employee", "EMPLOYEE" });
        }
    }
}
