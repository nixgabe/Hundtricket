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
                name: "DogPersonality",
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
                    LaidBack = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogPersonality", x => x.Id);
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
                name: "DogPreferences",
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
                    LaidBack = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogPreferences", x => x.Id);
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
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConversationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportedConversation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Reporter = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConversationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportedConversation", x => x.Id);
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
                    DogPersonalityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DogPreferencesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_Dogs_DogPersonality_DogPersonalityId",
                        column: x => x.DogPersonalityId,
                        principalTable: "DogPersonality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dogs_DogPicturesRelationships_DogPicturesRelationshipsId",
                        column: x => x.DogPicturesRelationshipsId,
                        principalTable: "DogPicturesRelationships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dogs_DogPreferences_DogPreferencesId",
                        column: x => x.DogPreferencesId,
                        principalTable: "DogPreferences",
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
                name: "UserPreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    LocationRange = table.Column<int>(type: "int", nullable: true),
                    YoungestAge = table.Column<int>(type: "int", nullable: true),
                    OldestAge = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPreferences_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id");
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
                name: "IX_Dogs_DogPersonalityId",
                table: "Dogs",
                column: "DogPersonalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogPicturesRelationshipsId",
                table: "Dogs",
                column: "DogPicturesRelationshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogPreferencesId",
                table: "Dogs",
                column: "DogPreferencesId");

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
                name: "IX_UserPreferences_GenderId",
                table: "UserPreferences",
                column: "GenderId");

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
                name: "DogPictures");

            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "ReportedConversation");

            migrationBuilder.DropTable(
                name: "UserDogs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DogBreeds");

            migrationBuilder.DropTable(
                name: "DogEnergyLevels");

            migrationBuilder.DropTable(
                name: "DogPersonality");

            migrationBuilder.DropTable(
                name: "DogPicturesRelationships");

            migrationBuilder.DropTable(
                name: "DogPreferences");

            migrationBuilder.DropTable(
                name: "DogSizes");

            migrationBuilder.DropTable(
                name: "UserDogRelationships");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "UserHobbies");

            migrationBuilder.DropTable(
                name: "UserPreferences");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
