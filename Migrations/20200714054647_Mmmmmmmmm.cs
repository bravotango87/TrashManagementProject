using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Migrations
{
    public partial class Mmmmmmmmm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c22e7ae-99df-4bcf-b600-99b1773326de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "566e67ca-ae82-426f-9ddc-bae2b27c906a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExtraPickup",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0891796d-6ae7-494e-b1ee-7a42d788d2c2", "521cf0eb-24cd-42f5-9335-51f0cb8eadf8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea603a84-37df-49a0-aee0-41f27703225b", "4d07e64d-5d20-4500-a932-7f67ceb5c869", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0891796d-6ae7-494e-b1ee-7a42d788d2c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea603a84-37df-49a0-aee0-41f27703225b");

            migrationBuilder.AlterColumn<string>(
                name: "ExtraPickup",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c22e7ae-99df-4bcf-b600-99b1773326de", "da110879-7666-4fa3-9871-0556791ce872", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "566e67ca-ae82-426f-9ddc-bae2b27c906a", "0ed113fd-47be-4ec3-b4fc-1608010a8d88", "Employee", "EMPLOYEE" });
        }
    }
}
