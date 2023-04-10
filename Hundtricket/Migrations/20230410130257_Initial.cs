using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DogBreeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogBreeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DogEnergyLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnergyLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogEnergyLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DogFiltersRelationships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DogPersonality = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DogPreferences = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogFiltersRelationships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DogPicturesRelationships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DogPicturesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogPicturesRelationships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DogSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDogRelationships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersDogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDogRelationships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserHobbiesRelationShips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LikesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DislikesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHobbiesRelationShips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationRange = table.Column<int>(type: "int", nullable: false),
                    YoungestAge = table.Column<int>(type: "int", nullable: false),
                    OldestAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPreferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DogFilters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorksWithBoys = table.Column<bool>(type: "bit", nullable: false),
                    WorksWithGirls = table.Column<bool>(type: "bit", nullable: false),
                    EnergyLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageWalk = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Timid = table.Column<bool>(type: "bit", nullable: false),
                    Confident = table.Column<bool>(type: "bit", nullable: false),
                    Adaptable = table.Column<bool>(type: "bit", nullable: false),
                    Independent = table.Column<bool>(type: "bit", nullable: false),
                    LaidBack = table.Column<bool>(type: "bit", nullable: false),
                    DogFiltersRelationshipsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogFilters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DogFilters_DogFiltersRelationships_DogFiltersRelationshipsId",
                        column: x => x.DogFiltersRelationshipsId,
                        principalTable: "DogFiltersRelationships",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DogPictures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DogPicturesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogPicturesRelationshipsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DogPictures_DogPicturesRelationships_DogPicturesRelationshipsId",
                        column: x => x.DogPicturesRelationshipsId,
                        principalTable: "DogPicturesRelationships",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogBreedId = table.Column<int>(type: "int", nullable: false),
                    DogSizeId = table.Column<int>(type: "int", nullable: false),
                    DogEnergyLevelId = table.Column<int>(type: "int", nullable: false),
                    Allergenic = table.Column<bool>(type: "bit", nullable: false),
                    DogPicturesRelationshipsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DogFiltersRelationshipsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                    table.ForeignKey(
                        name: "FK_Dogs_DogBreeds_DogBreedId",
                        column: x => x.DogBreedId,
                        principalTable: "DogBreeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dogs_DogEnergyLevel_DogEnergyLevelId",
                        column: x => x.DogEnergyLevelId,
                        principalTable: "DogEnergyLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dogs_DogFiltersRelationships_DogFiltersRelationshipsId",
                        column: x => x.DogFiltersRelationshipsId,
                        principalTable: "DogFiltersRelationships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dogs_DogPicturesRelationships_DogPicturesRelationshipsId",
                        column: x => x.DogPicturesRelationshipsId,
                        principalTable: "DogPicturesRelationships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dogs_DogSize_DogSizeId",
                        column: x => x.DogSizeId,
                        principalTable: "DogSize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersDogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserDogRelationshipsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDogs_UserDogRelationships_UserDogRelationshipsId",
                        column: x => x.UserDogRelationshipsId,
                        principalTable: "UserDogRelationships",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserHobbies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nature = table.Column<bool>(type: "bit", nullable: false),
                    Hiking = table.Column<bool>(type: "bit", nullable: false),
                    Swimming = table.Column<bool>(type: "bit", nullable: false),
                    Music = table.Column<bool>(type: "bit", nullable: false),
                    Gaming = table.Column<bool>(type: "bit", nullable: false),
                    Movies = table.Column<bool>(type: "bit", nullable: false),
                    Gymming = table.Column<bool>(type: "bit", nullable: false),
                    UserHobbiesRelationShipsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHobbies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserHobbies_UserHobbiesRelationShips_UserHobbiesRelationShipsId",
                        column: x => x.UserHobbiesRelationShipsId,
                        principalTable: "UserHobbiesRelationShips",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexuality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserHobbiesRelationshipsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserPreferencesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_UserHobbiesRelationShips_UserHobbiesRelationshipsId",
                        column: x => x.UserHobbiesRelationshipsId,
                        principalTable: "UserHobbiesRelationShips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfiles_UserPreferences_UserPreferencesId",
                        column: x => x.UserPreferencesId,
                        principalTable: "UserPreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserDogRelationshipsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserDogRelationships_UserDogRelationshipsId",
                        column: x => x.UserDogRelationshipsId,
                        principalTable: "UserDogRelationships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "Breed" },
                values: new object[,]
                {
                    { 1, "Mixed" },
                    { 2, "Samoyed" }
                });

            migrationBuilder.InsertData(
                table: "DogEnergyLevel",
                columns: new[] { "Id", "EnergyLevel" },
                values: new object[,]
                {
                    { 1, "Low" },
                    { 2, "Medium" },
                    { 3, "High" }
                });

            migrationBuilder.InsertData(
                table: "DogFilters",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "DogFiltersRelationshipsId", "EnergyLevel", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("0f3a3690-9e28-46f7-af88-ce63a16986ec"), false, 0m, false, null, "Low2", false, false, false, false, false },
                    { new Guid("4d86f4ab-da1d-4e5d-958a-93d620ff12b5"), false, 0m, false, null, "Medium2", false, false, false, false, false },
                    { new Guid("6d37cc29-2c57-45df-894c-0e71b0224d12"), false, 0m, false, null, "Low", false, false, false, false, false },
                    { new Guid("74b11255-c5b3-41b3-991c-c227bcb65523"), false, 0m, false, null, "Medium", false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("ae4e1834-f846-4a21-b8aa-9cb8c3100c34"), new Guid("74b11255-c5b3-41b3-991c-c227bcb65523"), new Guid("4d86f4ab-da1d-4e5d-958a-93d620ff12b5") },
                    { new Guid("ea6e5e26-2272-436e-a2d6-13a47efbd70e"), new Guid("6d37cc29-2c57-45df-894c-0e71b0224d12"), new Guid("0f3a3690-9e28-46f7-af88-ce63a16986ec") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("14fd0136-6ddf-4168-8a06-0fe6b45c4ad0"), new Guid("8a0e4ab6-2905-446d-a1f6-25c34a49e7ad"), null, "Thors second profile Picture" },
                    { new Guid("76c324d6-224c-41ab-ad5f-acf07c727a6c"), new Guid("2700a7a4-c59a-43e9-b908-79f7648509a4"), null, "Eddies only profile Picture" },
                    { new Guid("95145914-ba83-4ebf-b5ba-8ccb041c7e69"), new Guid("8a0e4ab6-2905-446d-a1f6-25c34a49e7ad"), null, "Thors first profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("51515a17-24ae-49af-bf57-609d5ad69349"), new Guid("8a0e4ab6-2905-446d-a1f6-25c34a49e7ad") },
                    { new Guid("c9f255e4-3a7b-42de-9dfb-4e5822a8716a"), new Guid("2700a7a4-c59a-43e9-b908-79f7648509a4") }
                });

            migrationBuilder.InsertData(
                table: "DogSize",
                columns: new[] { "Id", "Size" },
                values: new object[,]
                {
                    { 1, "Mini" },
                    { 2, "Small" },
                    { 3, "Medium" },
                    { 4, "Large" },
                    { 5, "Giant" }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("dd5e5ac0-b782-4925-8314-50b9d3ddcae3"), new Guid("659fa371-154e-470c-a927-6fdae716bebf") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("6ebf9138-3792-45d6-9520-24314d596ecd"), new Guid("c997349a-a56e-4027-8e8f-d509d1601ea5"), null, new Guid("659fa371-154e-470c-a927-6fdae716bebf") },
                    { new Guid("c9b8c472-b5bd-4466-a582-0ab6430254f2"), new Guid("f4a1567e-5600-44a7-b6b8-b8804c92f191"), null, new Guid("659fa371-154e-470c-a927-6fdae716bebf") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming", "UserHobbiesRelationShipsId" },
                values: new object[,]
                {
                    { new Guid("0736a20b-a6f6-48de-a21b-415181c9751f"), false, true, false, false, false, false, false, null },
                    { new Guid("18ae64cb-2303-4b5d-aa9a-b88e95a0e6fa"), true, false, false, true, false, false, true, null }
                });

            migrationBuilder.InsertData(
                table: "UserHobbiesRelationShips",
                columns: new[] { "Id", "DislikesId", "LikesId" },
                values: new object[] { new Guid("6d14e72d-66f5-4b16-83f3-e850adbcb142"), new Guid("0736a20b-a6f6-48de-a21b-415181c9751f"), new Guid("18ae64cb-2303-4b5d-aa9a-b88e95a0e6fa") });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("21265a9c-7711-4623-a728-ba38abbabe99"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "Name" },
                values: new object[,]
                {
                    { new Guid("c997349a-a56e-4027-8e8f-d509d1601ea5"), null, 1, false, 1, 2, new Guid("ae4e1834-f846-4a21-b8aa-9cb8c3100c34"), new Guid("c9f255e4-3a7b-42de-9dfb-4e5822a8716a"), 3, "Eddie" },
                    { new Guid("f4a1567e-5600-44a7-b6b8-b8804c92f191"), null, 11, false, 2, 1, new Guid("ea6e5e26-2272-436e-a2d6-13a47efbd70e"), new Guid("51515a17-24ae-49af-bf57-609d5ad69349"), 4, "Thor" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "Gender", "Job", "Location", "Sexuality", "UserHobbiesRelationshipsId", "UserPreferencesId" },
                values: new object[] { new Guid("d517f437-12b6-4383-8977-87eba4d6ba8d"), "Test Content", "Male", "Student", "Bullaren", "Bisexual", new Guid("6d14e72d-66f5-4b16-83f3-e850adbcb142"), new Guid("21265a9c-7711-4623-a728-ba38abbabe99") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("30e5ce5c-21dd-4861-a5f7-91b4afdfd802"), 30, "Nixgabriel92@gmail.com", "Gabriel", "Nix", "Blank", new Guid("dd5e5ac0-b782-4925-8314-50b9d3ddcae3"), new Guid("d517f437-12b6-4383-8977-87eba4d6ba8d") });

            migrationBuilder.CreateIndex(
                name: "IX_DogFilters_DogFiltersRelationshipsId",
                table: "DogFilters",
                column: "DogFiltersRelationshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_DogPictures_DogPicturesRelationshipsId",
                table: "DogPictures",
                column: "DogPicturesRelationshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogBreedId",
                table: "Dogs",
                column: "DogBreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogEnergyLevelId",
                table: "Dogs",
                column: "DogEnergyLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogFiltersRelationshipsId",
                table: "Dogs",
                column: "DogFiltersRelationshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogPicturesRelationshipsId",
                table: "Dogs",
                column: "DogPicturesRelationshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogSizeId",
                table: "Dogs",
                column: "DogSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDogs_UserDogRelationshipsId",
                table: "UserDogs",
                column: "UserDogRelationshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHobbies_UserHobbiesRelationShipsId",
                table: "UserHobbies",
                column: "UserHobbiesRelationShipsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_UserHobbiesRelationshipsId",
                table: "UserProfiles",
                column: "UserHobbiesRelationshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_UserPreferencesId",
                table: "UserProfiles",
                column: "UserPreferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserDogRelationshipsId",
                table: "Users",
                column: "UserDogRelationshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserProfileId",
                table: "Users",
                column: "UserProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogFilters");

            migrationBuilder.DropTable(
                name: "DogPictures");

            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.DropTable(
                name: "UserDogs");

            migrationBuilder.DropTable(
                name: "UserHobbies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DogBreeds");

            migrationBuilder.DropTable(
                name: "DogEnergyLevel");

            migrationBuilder.DropTable(
                name: "DogFiltersRelationships");

            migrationBuilder.DropTable(
                name: "DogPicturesRelationships");

            migrationBuilder.DropTable(
                name: "DogSize");

            migrationBuilder.DropTable(
                name: "UserDogRelationships");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "UserHobbiesRelationShips");

            migrationBuilder.DropTable(
                name: "UserPreferences");
        }
    }
}
