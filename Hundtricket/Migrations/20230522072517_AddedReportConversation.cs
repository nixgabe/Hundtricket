using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedReportConversation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("ce947349-0710-4e93-9526-d0459ef54cd8"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("fda3f3e1-6cf1-4cd1-80ca-3f21f8b90c3f"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("ffb78ddc-d259-4796-99d6-0e232f41afeb"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("3686310b-4206-4b54-9fda-48d16b9f8fdd"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("b112c433-2235-4ea8-9183-7aaae56b2233"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("9dae09d8-d9cf-4fad-ba92-b1e5a8c1f934"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("b645ad7f-a3b3-410d-b7cd-ad522634d50c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25e317d5-e23b-486f-a291-4ad5010bbb95"));

            migrationBuilder.DeleteData(
                table: "DogPersonality",
                keyColumn: "Id",
                keyValue: new Guid("05a01d7f-593c-4744-b222-a495726e1ee9"));

            migrationBuilder.DeleteData(
                table: "DogPersonality",
                keyColumn: "Id",
                keyValue: new Guid("a9bd9fe7-6ce7-4286-91a1-58e97b386944"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("a87c8bd0-825a-4be4-b4cd-db1826ee410b"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("bd7e9b8f-282c-4a5f-be9e-8cd94aa65cc7"));

            migrationBuilder.DeleteData(
                table: "DogPreferences",
                keyColumn: "Id",
                keyValue: new Guid("28fdcaf0-2c0b-47b3-bff7-911aca09232b"));

            migrationBuilder.DeleteData(
                table: "DogPreferences",
                keyColumn: "Id",
                keyValue: new Guid("75939895-4177-441f-a4c8-06888d8b43ac"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("5cc4785b-acbc-4830-8724-b56b30174ab7"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("9e0a9556-0725-4c31-a6d8-4cd200b37df1"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("759fc8b5-7a02-4df0-820d-56eda34e269e"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("d3e56832-8530-47d3-9f0a-3ee760b7efb5"));

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    ToUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConversationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
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

            migrationBuilder.InsertData(
                table: "DogPersonality",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("9a57dbf0-ff88-4ee8-acb2-fafdefcaad83"), true, 2m, true, true, true, false, true, true },
                    { new Guid("9d85316f-1ca8-49b2-922a-8232d39c7970"), false, 4m, true, false, true, false, true, true }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("33d21507-b0b3-48b1-9db9-b7df6045b153"), new Guid("4e081b97-4842-4bdc-a742-7e3a870b8e9b"), null, "Thors first profile Picture" },
                    { new Guid("672e7f16-f37c-4284-a4aa-c093f6efdc4f"), new Guid("4e081b97-4842-4bdc-a742-7e3a870b8e9b"), null, "Thors second profile Picture" },
                    { new Guid("7bd08def-e11f-43b7-8adf-4ec02ff0ed78"), new Guid("7bb3283f-35b0-433e-8ad5-98ef8963d24c"), null, "Eddies only profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("46747441-c429-495e-9d2a-668d55ba5059"), new Guid("4e081b97-4842-4bdc-a742-7e3a870b8e9b") },
                    { new Guid("5fd5fc0c-ccad-48ef-a728-0e17d3d24469"), new Guid("7bb3283f-35b0-433e-8ad5-98ef8963d24c") }
                });

            migrationBuilder.InsertData(
                table: "DogPreferences",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("d29cc3fc-8068-426b-b001-92967e16222d"), true, 4m, true, true, true, false, true, true },
                    { new Guid("e4591f35-4ea6-4844-9bae-57d66d5d455b"), true, 2m, true, true, true, true, true, true }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("9fdd5f62-0e25-449d-8732-3700eeceecf8"), new Guid("5a31d66b-1703-4299-b679-1f641a51e75f") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("01cab8d3-d5d4-483d-b3a2-d696133e146a"), new Guid("2d0b3842-4f03-4b06-9131-d9bfd835c1b4"), null, new Guid("73a0a762-ca4c-46d3-a7ab-10e795475816") },
                    { new Guid("5a31d66b-1703-4299-b679-1f641a51e75f"), new Guid("89aa788e-0150-4691-9de2-5cde2a4814bc"), null, new Guid("73a0a762-ca4c-46d3-a7ab-10e795475816") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming" },
                values: new object[] { new Guid("322138e8-f048-428c-b49e-527e2374b2db"), true, false, false, true, false, false, true });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("8f1e79fe-e81f-4508-ab7c-8490760d17e0"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogPersonalityId", "DogPicturesRelationshipsId", "DogPreferencesId", "DogSizeId", "GenderId", "Name" },
                values: new object[,]
                {
                    { new Guid("2d0b3842-4f03-4b06-9131-d9bfd835c1b4"), null, 11, false, 2, 1, new Guid("9a57dbf0-ff88-4ee8-acb2-fafdefcaad83"), new Guid("46747441-c429-495e-9d2a-668d55ba5059"), new Guid("e4591f35-4ea6-4844-9bae-57d66d5d455b"), 4, 1, "Thor" },
                    { new Guid("89aa788e-0150-4691-9de2-5cde2a4814bc"), null, 1, false, 1, 2, new Guid("9d85316f-1ca8-49b2-922a-8232d39c7970"), new Guid("5fd5fc0c-ccad-48ef-a728-0e17d3d24469"), new Guid("d29cc3fc-8068-426b-b001-92967e16222d"), 3, 1, "Eddie" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "GenderId", "Job", "Location", "Sexuality", "UserHobbiesId", "UserPreferencesId" },
                values: new object[] { new Guid("11403190-bccb-4707-898c-92bcf803d059"), "Test Content", 1, "Student", "Bullaren", "Bisexual", new Guid("322138e8-f048-428c-b49e-527e2374b2db"), new Guid("8f1e79fe-e81f-4508-ab7c-8490760d17e0") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("a120b94a-a13c-4a20-a662-e501cdf48daa"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("9fdd5f62-0e25-449d-8732-3700eeceecf8"), new Guid("11403190-bccb-4707-898c-92bcf803d059") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "ReportedConversation");

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("33d21507-b0b3-48b1-9db9-b7df6045b153"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("672e7f16-f37c-4284-a4aa-c093f6efdc4f"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("7bd08def-e11f-43b7-8adf-4ec02ff0ed78"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("2d0b3842-4f03-4b06-9131-d9bfd835c1b4"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("89aa788e-0150-4691-9de2-5cde2a4814bc"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("01cab8d3-d5d4-483d-b3a2-d696133e146a"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("5a31d66b-1703-4299-b679-1f641a51e75f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a120b94a-a13c-4a20-a662-e501cdf48daa"));

            migrationBuilder.DeleteData(
                table: "DogPersonality",
                keyColumn: "Id",
                keyValue: new Guid("9a57dbf0-ff88-4ee8-acb2-fafdefcaad83"));

            migrationBuilder.DeleteData(
                table: "DogPersonality",
                keyColumn: "Id",
                keyValue: new Guid("9d85316f-1ca8-49b2-922a-8232d39c7970"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("46747441-c429-495e-9d2a-668d55ba5059"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("5fd5fc0c-ccad-48ef-a728-0e17d3d24469"));

            migrationBuilder.DeleteData(
                table: "DogPreferences",
                keyColumn: "Id",
                keyValue: new Guid("d29cc3fc-8068-426b-b001-92967e16222d"));

            migrationBuilder.DeleteData(
                table: "DogPreferences",
                keyColumn: "Id",
                keyValue: new Guid("e4591f35-4ea6-4844-9bae-57d66d5d455b"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("9fdd5f62-0e25-449d-8732-3700eeceecf8"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("11403190-bccb-4707-898c-92bcf803d059"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("322138e8-f048-428c-b49e-527e2374b2db"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("8f1e79fe-e81f-4508-ab7c-8490760d17e0"));

            migrationBuilder.InsertData(
                table: "DogPersonality",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("05a01d7f-593c-4744-b222-a495726e1ee9"), true, 2m, true, true, true, false, true, true },
                    { new Guid("a9bd9fe7-6ce7-4286-91a1-58e97b386944"), false, 4m, true, false, true, false, true, true }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("ce947349-0710-4e93-9526-d0459ef54cd8"), new Guid("2ee94d6a-1f77-49f8-9d90-a689ffb27af8"), null, "Eddies only profile Picture" },
                    { new Guid("fda3f3e1-6cf1-4cd1-80ca-3f21f8b90c3f"), new Guid("26f31ab2-0db8-4364-9f23-c50c76974f9c"), null, "Thors second profile Picture" },
                    { new Guid("ffb78ddc-d259-4796-99d6-0e232f41afeb"), new Guid("26f31ab2-0db8-4364-9f23-c50c76974f9c"), null, "Thors first profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("a87c8bd0-825a-4be4-b4cd-db1826ee410b"), new Guid("2ee94d6a-1f77-49f8-9d90-a689ffb27af8") },
                    { new Guid("bd7e9b8f-282c-4a5f-be9e-8cd94aa65cc7"), new Guid("26f31ab2-0db8-4364-9f23-c50c76974f9c") }
                });

            migrationBuilder.InsertData(
                table: "DogPreferences",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("28fdcaf0-2c0b-47b3-bff7-911aca09232b"), true, 2m, true, true, true, true, true, true },
                    { new Guid("75939895-4177-441f-a4c8-06888d8b43ac"), true, 4m, true, true, true, false, true, true }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("5cc4785b-acbc-4830-8724-b56b30174ab7"), new Guid("b645ad7f-a3b3-410d-b7cd-ad522634d50c") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("9dae09d8-d9cf-4fad-ba92-b1e5a8c1f934"), new Guid("b112c433-2235-4ea8-9183-7aaae56b2233"), null, new Guid("5efca5bb-d6b7-4d67-8008-b92971e5fdd1") },
                    { new Guid("b645ad7f-a3b3-410d-b7cd-ad522634d50c"), new Guid("3686310b-4206-4b54-9fda-48d16b9f8fdd"), null, new Guid("5efca5bb-d6b7-4d67-8008-b92971e5fdd1") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming" },
                values: new object[] { new Guid("759fc8b5-7a02-4df0-820d-56eda34e269e"), true, false, false, true, false, false, true });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("d3e56832-8530-47d3-9f0a-3ee760b7efb5"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogPersonalityId", "DogPicturesRelationshipsId", "DogPreferencesId", "DogSizeId", "GenderId", "Name" },
                values: new object[,]
                {
                    { new Guid("3686310b-4206-4b54-9fda-48d16b9f8fdd"), null, 1, false, 1, 2, new Guid("a9bd9fe7-6ce7-4286-91a1-58e97b386944"), new Guid("a87c8bd0-825a-4be4-b4cd-db1826ee410b"), new Guid("75939895-4177-441f-a4c8-06888d8b43ac"), 3, 1, "Eddie" },
                    { new Guid("b112c433-2235-4ea8-9183-7aaae56b2233"), null, 11, false, 2, 1, new Guid("05a01d7f-593c-4744-b222-a495726e1ee9"), new Guid("bd7e9b8f-282c-4a5f-be9e-8cd94aa65cc7"), new Guid("28fdcaf0-2c0b-47b3-bff7-911aca09232b"), 4, 1, "Thor" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "GenderId", "Job", "Location", "Sexuality", "UserHobbiesId", "UserPreferencesId" },
                values: new object[] { new Guid("9e0a9556-0725-4c31-a6d8-4cd200b37df1"), "Test Content", 1, "Student", "Bullaren", "Bisexual", new Guid("759fc8b5-7a02-4df0-820d-56eda34e269e"), new Guid("d3e56832-8530-47d3-9f0a-3ee760b7efb5") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("25e317d5-e23b-486f-a291-4ad5010bbb95"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("5cc4785b-acbc-4830-8724-b56b30174ab7"), new Guid("9e0a9556-0725-4c31-a6d8-4cd200b37df1") });
        }
    }
}
