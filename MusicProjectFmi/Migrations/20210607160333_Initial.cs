using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicProjectFmi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: true),
                    PerformerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Performers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false),
                    AlbumId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Songs_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyPlaylists",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    SongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MyPlaylists_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SongsPerformers",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false),
                    PerformerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongsPerformers", x => new { x.PerformerId, x.SongId });
                    table.ForeignKey(
                        name: "FK_SongsPerformers_Performers_PerformerId",
                        column: x => x.PerformerId,
                        principalTable: "Performers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SongsPerformers_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Name", "PerformerId", "Year" },
                values: new object[,]
                {
                    { 1, "Elv1s", 2, 2002 },
                    { 2, "Back in Black", 3, 1982 },
                    { 3, "Ледено момиче", 4, 2000 },
                    { 4, "Дяволско желание", 5, 2000 },
                    { 5, "null", 6, 0 }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Popular music", "Pop" },
                    { 2, "Very emotional music", "Rock" },
                    { 3, "Very cheap music", "Chalga" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Веселин Маринов" },
                    { 2, "Elvis Presley" },
                    { 3, "Ad/Dc" },
                    { 4, "D2" },
                    { 5, "Преслава" },
                    { 6, "null" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "GenreId", "Name", "Year" },
                values: new object[,]
                {
                    { 1, 3, 1, "Ледено Момиче", 2000 },
                    { 2, 3, 1, "Две следи", 2000 },
                    { 3, 3, 1, "Не мога да спра да те обичам", 2000 },
                    { 4, 1, 2, "Hound Dog", 1956 },
                    { 5, 1, 2, "Heartbreak Hotel", 1968 },
                    { 6, 1, 2, "Dont't be Cruel", 1965 },
                    { 7, 2, 2, "Back in Black", 1980 },
                    { 8, 2, 2, "Shoot to thrill", 1981 },
                    { 9, 2, 2, "Hells Bells", 1982 },
                    { 10, 4, 3, "Финални думи", 2003 },
                    { 11, 4, 3, "Нямам право", 2004 },
                    { 12, 4, 3, "Дяволско желание", 2004 }
                });

            migrationBuilder.InsertData(
                table: "SongsPerformers",
                columns: new[] { "PerformerId", "SongId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 5, 10 },
                    { 5, 11 },
                    { 5, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyPlaylists_SongId",
                table: "MyPlaylists",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_SongsPerformers_SongId",
                table: "SongsPerformers",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyPlaylists");

            migrationBuilder.DropTable(
                name: "SongsPerformers");

            migrationBuilder.DropTable(
                name: "Performers");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
