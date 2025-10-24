using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test0001.Migrations
{
    /// <inheritdoc />
    public partial class AddOperatorMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectorsMovies_Directors_DirectorsId",
                table: "DirectorsMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_DirectorsMovies_Movies_MoviesId",
                table: "DirectorsMovies");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "OperatorId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OperatorId",
                table: "Directors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OperatorId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Operator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperatorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operator", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(6821), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(7327), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(7329), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8751), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9253), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9255), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9256), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9257), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9260), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9261), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9262), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(7896), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8332), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8334), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8335), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8336), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8337), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "OperatorId", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8341), 1, new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(8342) });

            migrationBuilder.InsertData(
                table: "Operator",
                columns: new[] { "Id", "OperatorName" },
                values: new object[] { 1, "admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(3860), new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(4630), new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(4632), new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(4633), new DateTime(2025, 10, 24, 15, 48, 51, 123, DateTimeKind.Utc).AddTicks(4633) });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_OperatorId",
                table: "Movies",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_OperatorId",
                table: "Directors",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_OperatorId",
                table: "Categories",
                column: "OperatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Operator_OperatorId",
                table: "Categories",
                column: "OperatorId",
                principalTable: "Operator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Operator_OperatorId",
                table: "Directors",
                column: "OperatorId",
                principalTable: "Operator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorsMovies_Directors_DirectorsId",
                table: "DirectorsMovies",
                column: "DirectorsId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorsMovies_Movies_MoviesId",
                table: "DirectorsMovies",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Operator_OperatorId",
                table: "Movies",
                column: "OperatorId",
                principalTable: "Operator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Operator_OperatorId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Operator_OperatorId",
                table: "Directors");

            migrationBuilder.DropForeignKey(
                name: "FK_DirectorsMovies_Directors_DirectorsId",
                table: "DirectorsMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_DirectorsMovies_Movies_MoviesId",
                table: "DirectorsMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Operator_OperatorId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Operator");

            migrationBuilder.DropIndex(
                name: "IX_Movies_OperatorId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Directors_OperatorId",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Categories_OperatorId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "Categories");

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
                columns: new[] { "CreationDate", "Role", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(6362), "guest", new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Role", "UpdateDate" },
                values: new object[] { new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(6364), "guest", new DateTime(2025, 10, 24, 12, 22, 30, 259, DateTimeKind.Utc).AddTicks(6364) });

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorsMovies_Directors_DirectorsId",
                table: "DirectorsMovies",
                column: "DirectorsId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorsMovies_Movies_MoviesId",
                table: "DirectorsMovies",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
