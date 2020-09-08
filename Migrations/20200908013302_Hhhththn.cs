using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Migrations
{
    public partial class Hhhththn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaef1f59-c17d-478e-adba-9549094f81c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e08f0d10-025c-46e8-b80e-c9cf82462748");

            migrationBuilder.AddColumn<string>(
                name: "CustomerKey",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e345c9df-86a4-4b3e-ad5e-d90bf1a1d897", "c35e38b8-6f11-44ad-9c2d-e5fabbf9e0e3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61111a4f-d586-4e96-9b10-b5b8d71aafd8", "5fd6a8af-2c9e-4666-844e-37d238b33aed", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61111a4f-d586-4e96-9b10-b5b8d71aafd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e345c9df-86a4-4b3e-ad5e-d90bf1a1d897");

            migrationBuilder.DropColumn(
                name: "CustomerKey",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e08f0d10-025c-46e8-b80e-c9cf82462748", "fd0cf279-3f2e-475b-bbe4-2b83186c17ef", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aaef1f59-c17d-478e-adba-9549094f81c1", "2597f2e4-dc16-4c1f-95f4-97dfa3e3ee10", "Employee", "EMPLOYEE" });
        }
    }
}
