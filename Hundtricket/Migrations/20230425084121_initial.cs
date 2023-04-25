using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                name: "DogEnergyLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnergyLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogEnergyLevels", x => x.Id);
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
                name: "DogSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderOption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
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
                    GenderId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Dogs_DogEnergyLevels_DogEnergyLevelId",
                        column: x => x.DogEnergyLevelId,
                        principalTable: "DogEnergyLevels",
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
                        name: "FK_Dogs_DogSizes_DogSizeId",
                        column: x => x.DogSizeId,
                        principalTable: "DogSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dogs_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
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
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserHobbiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserPreferencesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id");
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
                    { 2, "Samoyed" },
                    { 3, "Golden Retriever" },
                    { 4, "German Shepherd" },
                    { 5, "Borzoi" },
                    { 6, "Yorkshire Terrier" },
                    { 7, "Beagle" },
                    { 8, "Great Dane" },
                    { 9, "Siberian Husky" }
                });

            migrationBuilder.InsertData(
                table: "DogEnergyLevels",
                columns: new[] { "Id", "EnergyLevel" },
                values: new object[,]
                {
                    { 1, "Low" },
                    { 2, "Medium" },
                    { 3, "High" }
                });

            migrationBuilder.InsertData(
                table: "DogFilters",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "DogFiltersRelationshipsId", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("26e2922f-83cb-4f52-9ed8-9ab17c7e729f"), false, 0m, false, null, false, false, false, false, false },
                    { new Guid("9aef8b61-36e6-4320-a353-919d6607edb2"), false, 0m, false, null, false, false, false, false, false },
                    { new Guid("af55df1e-144e-4ad9-99e1-e7963a79308f"), false, 0m, false, null, false, false, false, false, false },
                    { new Guid("bfd03a4b-aaf9-4d07-a172-57a90bb4efdd"), false, 0m, false, null, false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("24a9f4e6-85ad-4e75-85c7-4eeb407315b4"), new Guid("bfd03a4b-aaf9-4d07-a172-57a90bb4efdd"), new Guid("af55df1e-144e-4ad9-99e1-e7963a79308f") },
                    { new Guid("ac9c3e0b-23ad-4aa8-b3a7-f470395d5e50"), new Guid("26e2922f-83cb-4f52-9ed8-9ab17c7e729f"), new Guid("9aef8b61-36e6-4320-a353-919d6607edb2") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("968d787a-5721-4a90-8e87-146f19a27503"), new Guid("cebb355a-922c-4287-844a-4bec229c681d"), null, "Eddies only profile Picture" },
                    { new Guid("9ee1fe8d-652d-427a-a1dd-67fa6dca7f5e"), new Guid("e7c0a7ab-5211-4d9b-8405-d10eb4e4fff7"), null, "Thors second profile Picture" },
                    { new Guid("c9b55875-c1ae-420b-a5fc-b9966ff377ed"), new Guid("e7c0a7ab-5211-4d9b-8405-d10eb4e4fff7"), null, "Thors first profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("9746b7e7-74cc-4d73-a8ae-2566e65411ff"), new Guid("e7c0a7ab-5211-4d9b-8405-d10eb4e4fff7") },
                    { new Guid("fb195804-0a4c-4c5e-a278-cde2dfd72dbd"), new Guid("cebb355a-922c-4287-844a-4bec229c681d") }
                });

            migrationBuilder.InsertData(
                table: "DogSizes",
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
                table: "Genders",
                columns: new[] { "Id", "GenderOption" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("0aad4509-0236-4eca-9334-455cb02db57c"), new Guid("ba1b76e0-75c7-464e-a4d5-481360ea00b5") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("1dc3fbc0-0ec0-4f1e-b183-73c43cd9f0fd"), new Guid("297b7ebd-17b2-45bd-98a4-1b0dff1af087"), null, new Guid("ba1b76e0-75c7-464e-a4d5-481360ea00b5") },
                    { new Guid("bce4d1be-1e2a-4e9f-b143-f5ecbbc7d320"), new Guid("8d6bb601-7c2f-4bc8-b0e3-704758facb53"), null, new Guid("ba1b76e0-75c7-464e-a4d5-481360ea00b5") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming" },
                values: new object[] { new Guid("f67b9a94-2a14-42b7-aedf-5fc414f4eeac"), true, false, false, true, false, false, true });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("fe363297-0904-41b8-8ef7-e4e01208b0a0"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "GenderId", "Name" },
                values: new object[,]
                {
                    { new Guid("297b7ebd-17b2-45bd-98a4-1b0dff1af087"), null, 11, false, 2, 1, new Guid("24a9f4e6-85ad-4e75-85c7-4eeb407315b4"), new Guid("9746b7e7-74cc-4d73-a8ae-2566e65411ff"), 4, 1, "Thor" },
                    { new Guid("8d6bb601-7c2f-4bc8-b0e3-704758facb53"), null, 1, false, 1, 2, new Guid("ac9c3e0b-23ad-4aa8-b3a7-f470395d5e50"), new Guid("fb195804-0a4c-4c5e-a278-cde2dfd72dbd"), 3, 1, "Eddie" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "GenderId", "Job", "Location", "Sexuality", "UserHobbiesId", "UserPreferencesId" },
                values: new object[] { new Guid("fbdfbaae-8d26-4eb8-9cfd-ce7322cf2311"), "Test Content", 1, "Student", "Bullaren", "Bisexual", new Guid("f67b9a94-2a14-42b7-aedf-5fc414f4eeac"), new Guid("fe363297-0904-41b8-8ef7-e4e01208b0a0") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("84c98b27-fd27-4530-8ac4-a5de2ed88c45"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("0aad4509-0236-4eca-9334-455cb02db57c"), new Guid("fbdfbaae-8d26-4eb8-9cfd-ce7322cf2311") });

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
                name: "IX_Dogs_GenderId",
                table: "Dogs",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDogs_UserDogRelationshipsId",
                table: "UserDogs",
                column: "UserDogRelationshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_GenderId",
                table: "UserProfiles",
                column: "GenderId");

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
                name: "DogEnergyLevels");

            migrationBuilder.DropTable(
                name: "DogFiltersRelationships");

            migrationBuilder.DropTable(
                name: "DogPicturesRelationships");

            migrationBuilder.DropTable(
                name: "DogSizes");

            migrationBuilder.DropTable(
                name: "UserDogRelationships");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "UserHobbies");

            migrationBuilder.DropTable(
                name: "UserPreferences");
        }
    }
}
