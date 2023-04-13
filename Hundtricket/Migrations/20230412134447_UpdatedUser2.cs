using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("2f9224b7-bfa2-4511-a024-185d78e3cb1b"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("307b8052-eef6-4850-b405-544360c6f558"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("84ad9f0f-b4d5-424f-b64d-6271c0b0c8a6"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("e70d9971-ef22-4615-93f7-ced18086516b"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("6ff35961-4734-4d86-8b63-71c6502823e3"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("7903c696-eb08-4f28-879a-26b5ff2303d0"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("d0777453-e242-41c9-9503-d9bc6db0097c"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("4a17dad3-dfdf-497e-9213-a5aeac6bc239"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("cc0d3fcd-cb6b-4507-89d2-d7c4ffd2a35a"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("282e6a4b-3e3b-426f-98ea-0da79e8a7c6d"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("39874334-5b28-4b84-af9e-a3d1dd5ac28e"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("00ac548e-736d-4f52-b668-205ea3f56fdf"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("8802e758-8593-4ab3-bd7e-0bd593e5839d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("709466f5-4728-4caf-9b0d-7f9959d1e160"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("58aea15e-99d7-4b3f-b81d-66f4309cb3c8"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("7735ddcf-e55e-4c35-ac93-3c92636b5927"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("adcfec61-6e4e-471b-8bce-b33ab223ce37"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("ca664022-cde0-4deb-bb47-66a2e13a8249"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("57c5863e-da48-48f8-8d0b-49d9b02b25bc"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("a8365f25-d236-4140-94c6-cce3cf4aa117"));

            migrationBuilder.DeleteData(
                table: "UserHobbiesRelationShips",
                keyColumn: "Id",
                keyValue: new Guid("cd300c8c-6f4c-4e0e-a874-4dba1c8d1520"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("4b3c21a4-3717-4280-9028-4934a3a01428"));

            migrationBuilder.AddColumn<bool>(
                name: "IsSignedOn",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "DogFilters",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "DogFiltersRelationshipsId", "EnergyLevel", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("2e9d1634-b1ac-4fc4-a8b3-29006c405614"), false, 0m, false, null, "Medium", false, false, false, false, false },
                    { new Guid("35548ddb-6808-469a-b443-6dd6430cc8e6"), false, 0m, false, null, "Low", false, false, false, false, false },
                    { new Guid("daeb54bb-961c-44e8-afe6-3f8e84211cd0"), false, 0m, false, null, "Medium2", false, false, false, false, false },
                    { new Guid("fcefd60f-f69b-405e-9517-f0faf8504750"), false, 0m, false, null, "Low2", false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("1ccd0a96-ea98-4bf7-b8dd-2e50fa5a85c3"), new Guid("2e9d1634-b1ac-4fc4-a8b3-29006c405614"), new Guid("daeb54bb-961c-44e8-afe6-3f8e84211cd0") },
                    { new Guid("d1d13618-fd1a-47ca-9710-ad27b01bf803"), new Guid("35548ddb-6808-469a-b443-6dd6430cc8e6"), new Guid("fcefd60f-f69b-405e-9517-f0faf8504750") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("2c2d2857-2f5e-4a78-9859-f160582fd9bc"), new Guid("a19a55c3-8a15-4f76-8bdd-b1bcf3655a33"), null, "Eddies only profile Picture" },
                    { new Guid("2f3c9151-b414-458c-ac46-3664ecd04275"), new Guid("52c9f07e-a2b9-4399-a7a5-d9fe48d78a4d"), null, "Thors first profile Picture" },
                    { new Guid("3a0aeb0c-49b9-41e8-a8b7-3956cf90ab82"), new Guid("52c9f07e-a2b9-4399-a7a5-d9fe48d78a4d"), null, "Thors second profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("0fba907b-ebf7-4f76-88e5-1a17324f14c9"), new Guid("52c9f07e-a2b9-4399-a7a5-d9fe48d78a4d") },
                    { new Guid("4191e2f7-efe9-4107-9fda-9fbcad710bc7"), new Guid("a19a55c3-8a15-4f76-8bdd-b1bcf3655a33") }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("f82ea372-ae29-46d7-984c-65baf533aee8"), new Guid("39aab694-2b89-45f7-b4dd-13879e7c6f49") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("5ad8543b-6ad7-4e07-8b4e-b626f6412fa0"), new Guid("24410293-4c3f-4f28-8095-b60956d84329"), null, new Guid("39aab694-2b89-45f7-b4dd-13879e7c6f49") },
                    { new Guid("f9915ca6-f4af-4e19-9101-2eacc0326584"), new Guid("7208623d-ae41-466d-ab75-e5d674e8f359"), null, new Guid("39aab694-2b89-45f7-b4dd-13879e7c6f49") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming", "UserHobbiesRelationShipsId" },
                values: new object[,]
                {
                    { new Guid("11778833-0b82-4203-964b-32f52d90c288"), true, false, false, true, false, false, true, null },
                    { new Guid("488b5d17-7cce-45c4-9d35-f10da4c0513e"), false, true, false, false, false, false, false, null }
                });

            migrationBuilder.InsertData(
                table: "UserHobbiesRelationShips",
                columns: new[] { "Id", "DislikesId", "LikesId" },
                values: new object[] { new Guid("b5e7e762-64ea-4225-a1cb-9df4899997fe"), new Guid("488b5d17-7cce-45c4-9d35-f10da4c0513e"), new Guid("11778833-0b82-4203-964b-32f52d90c288") });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("9687c10c-bac6-4fe9-bbc5-5dbceb5e2753"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "Name" },
                values: new object[,]
                {
                    { new Guid("24410293-4c3f-4f28-8095-b60956d84329"), null, 1, false, 1, 2, new Guid("1ccd0a96-ea98-4bf7-b8dd-2e50fa5a85c3"), new Guid("4191e2f7-efe9-4107-9fda-9fbcad710bc7"), 3, "Eddie" },
                    { new Guid("7208623d-ae41-466d-ab75-e5d674e8f359"), null, 11, false, 2, 1, new Guid("d1d13618-fd1a-47ca-9710-ad27b01bf803"), new Guid("0fba907b-ebf7-4f76-88e5-1a17324f14c9"), 4, "Thor" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "Gender", "Job", "Location", "Sexuality", "UserHobbiesRelationshipsId", "UserPreferencesId" },
                values: new object[] { new Guid("586a7bbd-ec3f-4cc1-8b91-267978139262"), "Test Content", "Male", "Student", "Bullaren", "Bisexual", new Guid("b5e7e762-64ea-4225-a1cb-9df4899997fe"), new Guid("9687c10c-bac6-4fe9-bbc5-5dbceb5e2753") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("1d3aa892-c2ca-4b6c-976e-aeee2a70044e"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("f82ea372-ae29-46d7-984c-65baf533aee8"), new Guid("586a7bbd-ec3f-4cc1-8b91-267978139262") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("2e9d1634-b1ac-4fc4-a8b3-29006c405614"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("35548ddb-6808-469a-b443-6dd6430cc8e6"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("daeb54bb-961c-44e8-afe6-3f8e84211cd0"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("fcefd60f-f69b-405e-9517-f0faf8504750"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("2c2d2857-2f5e-4a78-9859-f160582fd9bc"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("2f3c9151-b414-458c-ac46-3664ecd04275"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("3a0aeb0c-49b9-41e8-a8b7-3956cf90ab82"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("24410293-4c3f-4f28-8095-b60956d84329"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("7208623d-ae41-466d-ab75-e5d674e8f359"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("5ad8543b-6ad7-4e07-8b4e-b626f6412fa0"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("f9915ca6-f4af-4e19-9101-2eacc0326584"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("11778833-0b82-4203-964b-32f52d90c288"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("488b5d17-7cce-45c4-9d35-f10da4c0513e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d3aa892-c2ca-4b6c-976e-aeee2a70044e"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("1ccd0a96-ea98-4bf7-b8dd-2e50fa5a85c3"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("d1d13618-fd1a-47ca-9710-ad27b01bf803"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("0fba907b-ebf7-4f76-88e5-1a17324f14c9"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("4191e2f7-efe9-4107-9fda-9fbcad710bc7"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("f82ea372-ae29-46d7-984c-65baf533aee8"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("586a7bbd-ec3f-4cc1-8b91-267978139262"));

            migrationBuilder.DeleteData(
                table: "UserHobbiesRelationShips",
                keyColumn: "Id",
                keyValue: new Guid("b5e7e762-64ea-4225-a1cb-9df4899997fe"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("9687c10c-bac6-4fe9-bbc5-5dbceb5e2753"));

            migrationBuilder.DropColumn(
                name: "IsSignedOn",
                table: "Users");

            migrationBuilder.InsertData(
                table: "DogFilters",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "DogFiltersRelationshipsId", "EnergyLevel", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("2f9224b7-bfa2-4511-a024-185d78e3cb1b"), false, 0m, false, null, "Medium2", false, false, false, false, false },
                    { new Guid("307b8052-eef6-4850-b405-544360c6f558"), false, 0m, false, null, "Low2", false, false, false, false, false },
                    { new Guid("84ad9f0f-b4d5-424f-b64d-6271c0b0c8a6"), false, 0m, false, null, "Medium", false, false, false, false, false },
                    { new Guid("e70d9971-ef22-4615-93f7-ced18086516b"), false, 0m, false, null, "Low", false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("58aea15e-99d7-4b3f-b81d-66f4309cb3c8"), new Guid("e70d9971-ef22-4615-93f7-ced18086516b"), new Guid("307b8052-eef6-4850-b405-544360c6f558") },
                    { new Guid("7735ddcf-e55e-4c35-ac93-3c92636b5927"), new Guid("84ad9f0f-b4d5-424f-b64d-6271c0b0c8a6"), new Guid("2f9224b7-bfa2-4511-a024-185d78e3cb1b") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("6ff35961-4734-4d86-8b63-71c6502823e3"), new Guid("ae3b95d1-98d4-439f-9a39-4cf0ce5472dc"), null, "Eddies only profile Picture" },
                    { new Guid("7903c696-eb08-4f28-879a-26b5ff2303d0"), new Guid("50e16242-38f5-4c93-8833-a02e589f3206"), null, "Thors second profile Picture" },
                    { new Guid("d0777453-e242-41c9-9503-d9bc6db0097c"), new Guid("50e16242-38f5-4c93-8833-a02e589f3206"), null, "Thors first profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("adcfec61-6e4e-471b-8bce-b33ab223ce37"), new Guid("50e16242-38f5-4c93-8833-a02e589f3206") },
                    { new Guid("ca664022-cde0-4deb-bb47-66a2e13a8249"), new Guid("ae3b95d1-98d4-439f-9a39-4cf0ce5472dc") }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("57c5863e-da48-48f8-8d0b-49d9b02b25bc"), new Guid("87eac582-2b60-415c-a802-dea300d4175b") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("282e6a4b-3e3b-426f-98ea-0da79e8a7c6d"), new Guid("4a17dad3-dfdf-497e-9213-a5aeac6bc239"), null, new Guid("87eac582-2b60-415c-a802-dea300d4175b") },
                    { new Guid("39874334-5b28-4b84-af9e-a3d1dd5ac28e"), new Guid("cc0d3fcd-cb6b-4507-89d2-d7c4ffd2a35a"), null, new Guid("87eac582-2b60-415c-a802-dea300d4175b") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming", "UserHobbiesRelationShipsId" },
                values: new object[,]
                {
                    { new Guid("00ac548e-736d-4f52-b668-205ea3f56fdf"), false, true, false, false, false, false, false, null },
                    { new Guid("8802e758-8593-4ab3-bd7e-0bd593e5839d"), true, false, false, true, false, false, true, null }
                });

            migrationBuilder.InsertData(
                table: "UserHobbiesRelationShips",
                columns: new[] { "Id", "DislikesId", "LikesId" },
                values: new object[] { new Guid("cd300c8c-6f4c-4e0e-a874-4dba1c8d1520"), new Guid("00ac548e-736d-4f52-b668-205ea3f56fdf"), new Guid("8802e758-8593-4ab3-bd7e-0bd593e5839d") });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("4b3c21a4-3717-4280-9028-4934a3a01428"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "Name" },
                values: new object[,]
                {
                    { new Guid("4a17dad3-dfdf-497e-9213-a5aeac6bc239"), null, 1, false, 1, 2, new Guid("7735ddcf-e55e-4c35-ac93-3c92636b5927"), new Guid("ca664022-cde0-4deb-bb47-66a2e13a8249"), 3, "Eddie" },
                    { new Guid("cc0d3fcd-cb6b-4507-89d2-d7c4ffd2a35a"), null, 11, false, 2, 1, new Guid("58aea15e-99d7-4b3f-b81d-66f4309cb3c8"), new Guid("adcfec61-6e4e-471b-8bce-b33ab223ce37"), 4, "Thor" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "Gender", "Job", "Location", "Sexuality", "UserHobbiesRelationshipsId", "UserPreferencesId" },
                values: new object[] { new Guid("a8365f25-d236-4140-94c6-cce3cf4aa117"), "Test Content", "Male", "Student", "Bullaren", "Bisexual", new Guid("cd300c8c-6f4c-4e0e-a874-4dba1c8d1520"), new Guid("4b3c21a4-3717-4280-9028-4934a3a01428") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("709466f5-4728-4caf-9b0d-7f9959d1e160"), 30, "Nixgabriel92@gmail.com", "Gabriel", "Nix", "Blank", new Guid("57c5863e-da48-48f8-8d0b-49d9b02b25bc"), new Guid("a8365f25-d236-4140-94c6-cce3cf4aa117") });
        }
    }
}
