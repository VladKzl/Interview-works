using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserStatistics.Migrations
{
    public partial class NewPropertyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("2e71572f-d8a1-44d0-8410-88f108dca28a"));

            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("ec2c642a-143b-475e-81a2-8198cc090859"));

            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("edae53e4-936c-4e69-aa06-0366cd58f429"));

            migrationBuilder.AlterColumn<int>(
                name: "Persentage",
                table: "UserStatistics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Persentage",
                table: "UserStatistics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "Persentage", "UserId" },
                values: new object[] { new Guid("2e71572f-d8a1-44d0-8410-88f108dca28a"), 2, null, new Guid("c22384cf-499e-49f5-ae69-1bbb73e31753") });

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "Persentage", "UserId" },
                values: new object[] { new Guid("ec2c642a-143b-475e-81a2-8198cc090859"), 8, null, new Guid("94a4c1d0-de86-4b47-946e-76c824b9ea71") });

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "Persentage", "UserId" },
                values: new object[] { new Guid("edae53e4-936c-4e69-aa06-0366cd58f429"), 12, null, new Guid("0627d950-2d3f-421e-be7c-8bf5ad53a7c4") });
        }
    }
}
