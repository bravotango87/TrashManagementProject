using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Migrations
{
    public partial class newsw1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0891796d-6ae7-494e-b1ee-7a42d788d2c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea603a84-37df-49a0-aee0-41f27703225b");

            migrationBuilder.AddColumn<string>(
                name: "PickupType",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PropertyType",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c33538a-f02f-4f6b-a95e-b93326bcad4b", "de24d889-3688-4904-95d4-489151e2a567", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ca3c144-53df-4419-a739-a86f36b98e1f", "75e69b09-1044-4a62-b28d-954dac769002", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c33538a-f02f-4f6b-a95e-b93326bcad4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca3c144-53df-4419-a739-a86f36b98e1f");

            migrationBuilder.DropColumn(
                name: "PickupType",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PropertyType",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0891796d-6ae7-494e-b1ee-7a42d788d2c2", "521cf0eb-24cd-42f5-9335-51f0cb8eadf8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea603a84-37df-49a0-aee0-41f27703225b", "4d07e64d-5d20-4500-a932-7f67ceb5c869", "Employee", "EMPLOYEE" });
        }
    }
}
