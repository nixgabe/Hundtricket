using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationInitial : Migration
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
                    Gymming = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationRange = table.Column<int>(type: "int", nullable: true),
                    YoungestAge = table.Column<int>(type: "int", nullable: true),
                    OldestAge = table.Column<int>(type: "int", nullable: true)
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
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexuality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserHobbiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserPreferencesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_UserHobbies_UserHobbiesId",
                        column: x => x.UserHobbiesId,
                        principalTable: "UserHobbies",
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserDogRelationshipsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsSignedOn = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserDogRelationships_UserDogRelationshipsId",
                        column: x => x.UserDogRelationshipsId,
                        principalTable: "UserDogRelationships",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id");
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
                    { new Guid("1bd4aa58-743b-4bd9-93fc-2f32c1a58b04"), false, 0m, false, null, "Medium", false, false, false, false, false },
                    { new Guid("6e5e06cf-a0f8-4419-acc5-bfed17cec6d4"), false, 0m, false, null, "Low", false, false, false, false, false },
                    { new Guid("a45bba47-f35a-4882-8bf8-5116577a3d25"), false, 0m, false, null, "Medium2", false, false, false, false, false },
                    { new Guid("b40b2931-1df4-43f1-a7d2-6edfacab66c3"), false, 0m, false, null, "Low2", false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("796edc83-b48c-4645-8d4d-67da19b10c08"), new Guid("6e5e06cf-a0f8-4419-acc5-bfed17cec6d4"), new Guid("b40b2931-1df4-43f1-a7d2-6edfacab66c3") },
                    { new Guid("d7f78adb-1339-4f98-8447-aa75b4e1bf81"), new Guid("1bd4aa58-743b-4bd9-93fc-2f32c1a58b04"), new Guid("a45bba47-f35a-4882-8bf8-5116577a3d25") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("5a6fe1f0-4f81-4ac4-9fd1-eefaf293095c"), new Guid("70f1fb91-5889-46d8-b0f0-e63645fb753b"), null, "Thors second profile Picture" },
                    { new Guid("993c93ba-8db5-4048-b87a-a4b88d0418b7"), new Guid("70f1fb91-5889-46d8-b0f0-e63645fb753b"), null, "Thors first profile Picture" },
                    { new Guid("a7d2fe65-f2d3-4ea5-8a24-ba606fe99b7e"), new Guid("9e3e90e0-5a5a-48e9-8386-960c6ca95b9d"), null, "Eddies only profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("eacf642f-ff75-4eec-a437-3424765cf160"), new Guid("70f1fb91-5889-46d8-b0f0-e63645fb753b") },
                    { new Guid("fdd4c483-e7dd-4b2e-8912-3ccebfc8e32d"), new Guid("9e3e90e0-5a5a-48e9-8386-960c6ca95b9d") }
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
                values: new object[] { new Guid("838b776d-85de-456f-ae13-d7e3e6d544e4"), new Guid("1ea1ee74-cc56-478a-a8dc-c46cf7d722f7") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("0b19492f-27cf-433c-8abd-9add7dbf1ef8"), new Guid("2ddea553-f3d6-4a4b-89e7-f40fb15e8352"), null, new Guid("1ea1ee74-cc56-478a-a8dc-c46cf7d722f7") },
                    { new Guid("93022f06-02eb-4008-bb22-17010ac0e1aa"), new Guid("d15605cb-e81f-4a26-88ba-1ee1d525f719"), null, new Guid("1ea1ee74-cc56-478a-a8dc-c46cf7d722f7") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming" },
                values: new object[] { new Guid("04123a5b-5b7a-49f4-b8c3-76029bfdf687"), true, false, false, true, false, false, true });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("1c940708-a8b0-47c7-b8e1-ad6ee60b0ceb"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "Name" },
                values: new object[,]
                {
                    { new Guid("2ddea553-f3d6-4a4b-89e7-f40fb15e8352"), null, 1, false, 1, 2, new Guid("d7f78adb-1339-4f98-8447-aa75b4e1bf81"), new Guid("fdd4c483-e7dd-4b2e-8912-3ccebfc8e32d"), 3, "Eddie" },
                    { new Guid("d15605cb-e81f-4a26-88ba-1ee1d525f719"), null, 11, false, 2, 1, new Guid("796edc83-b48c-4645-8d4d-67da19b10c08"), new Guid("eacf642f-ff75-4eec-a437-3424765cf160"), 4, "Thor" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "Gender", "Job", "Location", "Sexuality", "UserHobbiesId", "UserPreferencesId" },
                values: new object[] { new Guid("934a5e3f-20fa-4efb-988b-cd7cfc4bb95c"), "Test Content", "Male", "Student", "Bullaren", "Bisexual", new Guid("04123a5b-5b7a-49f4-b8c3-76029bfdf687"), new Guid("1c940708-a8b0-47c7-b8e1-ad6ee60b0ceb") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("8293e866-0b02-4527-b121-330ff28f2cca"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("838b776d-85de-456f-ae13-d7e3e6d544e4"), new Guid("934a5e3f-20fa-4efb-988b-cd7cfc4bb95c") });

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
                name: "IX_UserProfiles_UserHobbiesId",
                table: "UserProfiles",
                column: "UserHobbiesId");

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
                name: "UserHobbies");

            migrationBuilder.DropTable(
                name: "UserPreferences");
        }
    }
}
