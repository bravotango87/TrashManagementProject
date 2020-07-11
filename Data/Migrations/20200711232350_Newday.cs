using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Data.Migrations
{
    public partial class Newday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ec44755-eebe-4316-a53b-f98787ca45c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5ffb583-d878-4d85-a439-133766a45a70");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad41a563-acd2-4283-86bb-1a1d20d156cf", "3da89faa-76b6-41a0-96e9-65fe0d540988", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bade78d1-38ca-4355-a5f0-c8ed5089d85d", "a23ab285-607c-4571-87fe-d352d492565e", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad41a563-acd2-4283-86bb-1a1d20d156cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bade78d1-38ca-4355-a5f0-c8ed5089d85d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ec44755-eebe-4316-a53b-f98787ca45c4", "9e336036-d332-4e54-a33f-23f758edfde9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5ffb583-d878-4d85-a439-133766a45a70", "c468129a-178e-4c2c-aaf7-10aacf601369", "Employee", "EMPLOYEE" });
        }
    }
}
