using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test0001.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookmarks",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookmarks", x => new { x.MoviesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_Bookmarks_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookmarks_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectorsMovies",
                columns: table => new
                {
                    DirectorsId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorsMovies", x => new { x.DirectorsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_DirectorsMovies_Directors_DirectorsId",
                        column: x => x.DirectorsId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectorsMovies_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9335), "Fantasy", new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9337) },
                    { 2, new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9642), "Thriller", new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9642) },
                    { 3, new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9667), "Comedy", new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(9668) }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "CreationDate", "Name", "Surname", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1241), "Phil", "Lord", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1241) },
                    { 2, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1666), "Chris", "Miller", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1666) },
                    { 3, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1668), "Alfonso", "Cuaròn", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1668) },
                    { 4, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1669), "Peter", "Jackson", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1669) },
                    { 5, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1670), "Brad", "Anderson", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1670) },
                    { 6, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1671), "Massimo", "Venier", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1672) },
                    { 7, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1673), "Chris", "Wedge", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1673) },
                    { 8, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1674), "Carlos", "Saldanha", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(1674) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Email", "UpdateDate", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2118), "marta@example.com", new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2125), "marta" },
                    { 2, new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2877), "claudio@example.com", new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2878), "spazzabilly" },
                    { 3, new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2879), "claudio@example.com", new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2880), "GiulioAbridge" },
                    { 4, new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2881), "jack@example.com", new DateTime(2025, 10, 24, 11, 1, 20, 720, DateTimeKind.Utc).AddTicks(2881), "jackomino" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreationDate", "ReleaseDate", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(292), new DateOnly(1, 1, 1), "Harry Potter and The Prisoner of Azkaban", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(293) },
                    { 2, 2, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(774), new DateOnly(1, 1, 1), "Fractured", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(774) },
                    { 3, 3, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(776), new DateOnly(1, 1, 1), "Tre uomini e una gamba", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(776) },
                    { 4, 1, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(777), new DateOnly(1, 1, 1), "The Fellowship of the Ring", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(777) },
                    { 5, 3, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(778), new DateOnly(1, 1, 1), "Ice age", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(779) },
                    { 6, 3, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(780), new DateOnly(1, 1, 1), "Cloudy with a chance of meatballs", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(780) },
                    { 7, 3, new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(781), new DateOnly(1, 1, 1), "The LEGO Movie", new DateTime(2025, 10, 24, 11, 1, 20, 721, DateTimeKind.Utc).AddTicks(781) }
                });

            migrationBuilder.InsertData(
                table: "DirectorsMovies",
                columns: new[] { "DirectorsId", "MoviesId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 1, 7 },
                    { 2, 6 },
                    { 2, 7 },
                    { 3, 1 },
                    { 4, 4 },
                    { 5, 2 },
                    { 6, 3 },
                    { 7, 5 },
                    { 8, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookmarks_UsersId",
                table: "Bookmarks",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MovieId",
                table: "Comments",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorsMovies_MoviesId",
                table: "DirectorsMovies",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookmarks");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DirectorsMovies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
