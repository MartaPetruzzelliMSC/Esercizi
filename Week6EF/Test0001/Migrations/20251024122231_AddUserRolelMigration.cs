using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test0001.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRolelMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(2281), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(2587), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(2589), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4160), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4596), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4599), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4600), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4601), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4602), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4604), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4605), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3136), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3608), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3610), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3611), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3613), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3615), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3616), new DateTime(2025, 10, 24, 12, 22, 30, 260, DateTimeKind.Utc).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Role", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(5378), "admin", new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Role", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(6359), "guest", new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Email", "Role", "UpdateDate", "Username" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(6362), "abriged@example.com", "guest", new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(6363), "GiulioAbridged" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Role", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(6364), "guest", new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(6364) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9335), new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9642), new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9667), new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1241), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1666), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1668), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1669), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1670), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1671), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1673), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1674), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(292), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(774), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(776), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(777), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(778), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(780), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(781), new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2118), new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2877), new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Email", "UpdateDate", "Username" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2879), "claudio@example.com", new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2880), "GiulioAbridge" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2881), new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2881) });
        }
    }
}
