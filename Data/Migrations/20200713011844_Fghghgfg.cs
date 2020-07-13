using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Data.Migrations
{
    public partial class Fghghgfg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad41a563-acd2-4283-86bb-1a1d20d156cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bade78d1-38ca-4355-a5f0-c8ed5089d85d");

            migrationBuilder.DropColumn(
                name: "PickupDay",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrashDay",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PickupDays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(nullable: true),
                    IsPickedUp = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickupDays", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "baae36ca-7772-4893-b68f-e2a1ad7d6337", "f5eb74d4-9330-4fa7-9ee5-17378494243e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "108c4c79-633e-4732-bf24-b1b464a880f4", "5722a8ec-e8bf-4125-8b3f-e2c8a5dd510a", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PickupDays");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "108c4c79-633e-4732-bf24-b1b464a880f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baae36ca-7772-4893-b68f-e2a1ad7d6337");

            migrationBuilder.DropColumn(
                name: "TrashDay",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "PickupDay",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad41a563-acd2-4283-86bb-1a1d20d156cf", "3da89faa-76b6-41a0-96e9-65fe0d540988", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bade78d1-38ca-4355-a5f0-c8ed5089d85d", "a23ab285-607c-4571-87fe-d352d492565e", "Employee", "EMPLOYEE" });
        }
    }
}
