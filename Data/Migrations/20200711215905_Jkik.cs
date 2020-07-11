using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Data.Migrations
{
    public partial class Jkik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b231d92-153d-42ec-94c5-7692deb7b0cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce374ad3-8027-403b-a0d7-b8a6a90b9b2a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ec44755-eebe-4316-a53b-f98787ca45c4", "9e336036-d332-4e54-a33f-23f758edfde9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5ffb583-d878-4d85-a439-133766a45a70", "c468129a-178e-4c2c-aaf7-10aacf601369", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ce374ad3-8027-403b-a0d7-b8a6a90b9b2a", "95587968-584a-46ea-b809-dacc8a675736", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b231d92-153d-42ec-94c5-7692deb7b0cc", "2fb484ff-c028-4aa3-b239-c353032e5aa5", "Employee", "EMPLOYEE" });
        }
    }
}
