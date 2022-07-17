using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserStatistics.Migrations
{
    public partial class PercantageValueInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("0dbb3717-2247-4cba-bc15-7301a0db61ed"));

            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("4cfa3be9-0092-4303-8eb3-9c8517e4fd12"));

            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("952b6c51-3c62-4e6e-b37b-6d4d45c39207"));

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "Persentage", "UserId" },
                values: new object[] { new Guid("4863267b-cdef-43ca-9552-638d5151d7e0"), 2, 0, new Guid("b3897378-089b-4d28-9867-1caaef236ca2") });

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "Persentage", "UserId" },
                values: new object[] { new Guid("9417ecd5-ed64-45c1-b94b-221670dd3e24"), 8, 0, new Guid("b2b17a85-0b06-4ef3-9f73-2b3f5cb7108a") });

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "Persentage", "UserId" },
                values: new object[] { new Guid("c5a67a4c-c788-4b1b-ac4a-485b23e9c7b9"), 12, 0, new Guid("31c4b5c9-8420-4705-acef-ec5723bc97e1") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("4863267b-cdef-43ca-9552-638d5151d7e0"));

            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("9417ecd5-ed64-45c1-b94b-221670dd3e24"));

            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("c5a67a4c-c788-4b1b-ac4a-485b23e9c7b9"));

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "Persentage", "UserId" },
                values: new object[] { new Guid("0dbb3717-2247-4cba-bc15-7301a0db61ed"), 12, 0, new Guid("46b8f8c0-c862-4eba-8aa5-00aaad88956f") });

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "Persentage", "UserId" },
                values: new object[] { new Guid("4cfa3be9-0092-4303-8eb3-9c8517e4fd12"), 8, 0, new Guid("c9e65435-3d16-4dd1-a2be-a0e752accf3a") });

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "Persentage", "UserId" },
                values: new object[] { new Guid("952b6c51-3c62-4e6e-b37b-6d4d45c39207"), 2, 0, new Guid("5746db32-ed0c-48a4-bae5-0df5783ea60e") });
        }
    }
}
