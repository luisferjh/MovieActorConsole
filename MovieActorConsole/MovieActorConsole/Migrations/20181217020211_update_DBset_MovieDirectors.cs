using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieActorConsole.Migrations
{
    public partial class update_DBset_MovieDirectors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_Actors_ActorId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_Movies_MovieId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirector_Directors_DirectorId",
                table: "MovieDirector");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirector_Movies_MovieId",
                table: "MovieDirector");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieDirector",
                table: "MovieDirector");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieActor",
                table: "MovieActor");

            migrationBuilder.RenameTable(
                name: "MovieDirector",
                newName: "MovieDirectors");

            migrationBuilder.RenameTable(
                name: "MovieActor",
                newName: "MovieActors");

            migrationBuilder.RenameIndex(
                name: "IX_MovieDirector_MovieId",
                table: "MovieDirectors",
                newName: "IX_MovieDirectors_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActor_MovieId",
                table: "MovieActors",
                newName: "IX_MovieActors_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieDirectors",
                table: "MovieDirectors",
                columns: new[] { "DirectorId", "MovieId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieActors",
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Actors_ActorId",
                table: "MovieActors",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Movies_MovieId",
                table: "MovieActors",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirectors_Directors_DirectorId",
                table: "MovieDirectors",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "DirectorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirectors_Movies_MovieId",
                table: "MovieDirectors",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Actors_ActorId",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Movies_MovieId",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirectors_Directors_DirectorId",
                table: "MovieDirectors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieDirectors_Movies_MovieId",
                table: "MovieDirectors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieDirectors",
                table: "MovieDirectors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieActors",
                table: "MovieActors");

            migrationBuilder.RenameTable(
                name: "MovieDirectors",
                newName: "MovieDirector");

            migrationBuilder.RenameTable(
                name: "MovieActors",
                newName: "MovieActor");

            migrationBuilder.RenameIndex(
                name: "IX_MovieDirectors_MovieId",
                table: "MovieDirector",
                newName: "IX_MovieDirector_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActors_MovieId",
                table: "MovieActor",
                newName: "IX_MovieActor_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieDirector",
                table: "MovieDirector",
                columns: new[] { "DirectorId", "MovieId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieActor",
                table: "MovieActor",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_Actors_ActorId",
                table: "MovieActor",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_Movies_MovieId",
                table: "MovieActor",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirector_Directors_DirectorId",
                table: "MovieDirector",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "DirectorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDirector_Movies_MovieId",
                table: "MovieDirector",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
