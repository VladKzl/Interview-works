using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserStatistics.Migrations
{
    public partial class NewProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("0ef53d72-d4b5-4aeb-a45c-09a45dbf8845"));

            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("885903ae-1c12-48dc-9b0a-c697e41a9313"));

            migrationBuilder.DeleteData(
                table: "UserStatistics",
                keyColumn: "Id",
                keyValue: new Guid("e26caf7d-5d9a-4309-849d-4708ed194414"));

            migrationBuilder.AddColumn<string>(
                name: "Persentage",
                table: "UserStatistics",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Persentage",
                table: "UserStatistics");

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "UserId" },
                values: new object[] { new Guid("0ef53d72-d4b5-4aeb-a45c-09a45dbf8845"), 12, new Guid("645700e9-d10b-4d78-a42b-a6a2816b1d5c") });

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "UserId" },
                values: new object[] { new Guid("885903ae-1c12-48dc-9b0a-c697e41a9313"), 2, new Guid("1e99184f-a135-4f24-a617-31ff6026cb84") });

            migrationBuilder.InsertData(
                table: "UserStatistics",
                columns: new[] { "Id", "CountSignIn", "UserId" },
                values: new object[] { new Guid("e26caf7d-5d9a-4309-849d-4708ed194414"), 8, new Guid("4964c711-a20e-4625-9b47-8e2333e9b82a") });
        }
    }
}
