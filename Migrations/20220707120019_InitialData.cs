using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserStatistics.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserStatistics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountSignIn = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatistics", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserStatistics");
        }
    }
}
