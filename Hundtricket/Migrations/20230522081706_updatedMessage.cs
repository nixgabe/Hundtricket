using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.InsertData(
                table: "DogPersonality",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("4eee9ef1-c531-4472-a112-8ee1dd0bd866"), true, 2m, true, true, true, false, true, true },
                    { new Guid("f4ad8511-795e-4dc5-96c8-e59645f719a1"), false, 4m, true, false, true, false, true, true }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("20af2d3f-50b4-4bd3-8d01-4df68d48ed3f"), new Guid("e62e7e89-d2a4-47d6-b07f-82735ec14181"), null, "Thors first profile Picture" },
                    { new Guid("61d1c576-cdf2-425e-be21-5e41638b6b6a"), new Guid("e62e7e89-d2a4-47d6-b07f-82735ec14181"), null, "Thors second profile Picture" },
                    { new Guid("a41670f8-45a8-4775-ac2a-0cf3395a1bd3"), new Guid("440b93c3-4dcf-4417-adf9-4fc066c5dcc7"), null, "Eddies only profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("063b6857-3abf-4939-af6e-fa77b3d74fc0"), new Guid("440b93c3-4dcf-4417-adf9-4fc066c5dcc7") },
                    { new Guid("fbf3499b-c9ad-44b2-aee5-edc957741025"), new Guid("e62e7e89-d2a4-47d6-b07f-82735ec14181") }
                });

            migrationBuilder.InsertData(
                table: "DogPreferences",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("b04fd782-6199-45c9-a9e9-cd0f2081a298"), true, 4m, true, true, true, false, true, true },
                    { new Guid("bcbd8c76-c019-4673-88ef-33c1a06c2491"), true, 2m, true, true, true, true, true, true }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("eb50c3ad-c5b8-412e-92a3-ba61adcb44b9"), new Guid("54bcf77a-3c90-4c2f-8f07-eefda4e7e7a2") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("54bcf77a-3c90-4c2f-8f07-eefda4e7e7a2"), new Guid("77e177d9-b3bc-447c-9b96-1c4cfa41025e"), null, new Guid("72cb553a-2117-4589-a58d-9eefb9e85dc0") },
                    { new Guid("7375641f-22a9-4ffd-b88d-15a6a548a6ff"), new Guid("babf3e11-ec06-4b56-8a9c-f7bf3fdbf138"), null, new Guid("72cb553a-2117-4589-a58d-9eefb9e85dc0") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming" },
                values: new object[] { new Guid("05f10c46-197b-4ba0-86d1-89e74e6a4905"), true, false, false, true, false, false, true });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("bf0d4139-a5ec-4b18-90ee-42f97e776962"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogPersonalityId", "DogPicturesRelationshipsId", "DogPreferencesId", "DogSizeId", "GenderId", "Name" },
                values: new object[,]
                {
                    { new Guid("77e177d9-b3bc-447c-9b96-1c4cfa41025e"), null, 1, false, 1, 2, new Guid("f4ad8511-795e-4dc5-96c8-e59645f719a1"), new Guid("063b6857-3abf-4939-af6e-fa77b3d74fc0"), new Guid("b04fd782-6199-45c9-a9e9-cd0f2081a298"), 3, 1, "Eddie" },
                    { new Guid("babf3e11-ec06-4b56-8a9c-f7bf3fdbf138"), null, 11, false, 2, 1, new Guid("4eee9ef1-c531-4472-a112-8ee1dd0bd866"), new Guid("fbf3499b-c9ad-44b2-aee5-edc957741025"), new Guid("bcbd8c76-c019-4673-88ef-33c1a06c2491"), 4, 1, "Thor" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "GenderId", "Job", "Location", "Sexuality", "UserHobbiesId", "UserPreferencesId" },
                values: new object[] { new Guid("f9b76317-63eb-4e5d-8924-50414fd95a63"), "Test Content", 1, "Student", "Bullaren", "Bisexual", new Guid("05f10c46-197b-4ba0-86d1-89e74e6a4905"), new Guid("bf0d4139-a5ec-4b18-90ee-42f97e776962") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("6bae828f-a5ff-40aa-ba7f-a6bff874edfd"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("eb50c3ad-c5b8-412e-92a3-ba61adcb44b9"), new Guid("f9b76317-63eb-4e5d-8924-50414fd95a63") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("20af2d3f-50b4-4bd3-8d01-4df68d48ed3f"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("61d1c576-cdf2-425e-be21-5e41638b6b6a"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("a41670f8-45a8-4775-ac2a-0cf3395a1bd3"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("77e177d9-b3bc-447c-9b96-1c4cfa41025e"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("babf3e11-ec06-4b56-8a9c-f7bf3fdbf138"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("54bcf77a-3c90-4c2f-8f07-eefda4e7e7a2"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("7375641f-22a9-4ffd-b88d-15a6a548a6ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bae828f-a5ff-40aa-ba7f-a6bff874edfd"));

            migrationBuilder.DeleteData(
                table: "DogPersonality",
                keyColumn: "Id",
                keyValue: new Guid("4eee9ef1-c531-4472-a112-8ee1dd0bd866"));

            migrationBuilder.DeleteData(
                table: "DogPersonality",
                keyColumn: "Id",
                keyValue: new Guid("f4ad8511-795e-4dc5-96c8-e59645f719a1"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("063b6857-3abf-4939-af6e-fa77b3d74fc0"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("fbf3499b-c9ad-44b2-aee5-edc957741025"));

            migrationBuilder.DeleteData(
                table: "DogPreferences",
                keyColumn: "Id",
                keyValue: new Guid("b04fd782-6199-45c9-a9e9-cd0f2081a298"));

            migrationBuilder.DeleteData(
                table: "DogPreferences",
                keyColumn: "Id",
                keyValue: new Guid("bcbd8c76-c019-4673-88ef-33c1a06c2491"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("eb50c3ad-c5b8-412e-92a3-ba61adcb44b9"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("f9b76317-63eb-4e5d-8924-50414fd95a63"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("05f10c46-197b-4ba0-86d1-89e74e6a4905"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("bf0d4139-a5ec-4b18-90ee-42f97e776962"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Message");

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
    }
}
