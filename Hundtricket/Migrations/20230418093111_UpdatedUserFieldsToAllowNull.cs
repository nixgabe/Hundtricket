using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUserFieldsToAllowNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "YoungestAge",
                table: "UserPreferences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OldestAge",
                table: "UserPreferences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LocationRange",
                table: "UserPreferences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "UserPreferences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "DogFilters",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "DogFiltersRelationshipsId", "EnergyLevel", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("3d2e69eb-f5de-45f4-b0a5-b7ac107d65ac"), false, 0m, false, null, "Low2", false, false, false, false, false },
                    { new Guid("aaee55ff-4bf6-4a0e-9268-64f56da1a636"), false, 0m, false, null, "Low", false, false, false, false, false },
                    { new Guid("e59d20c1-944c-4c3d-834c-d3dbc75fd7b8"), false, 0m, false, null, "Medium", false, false, false, false, false },
                    { new Guid("fe0adf40-e1fe-4b1c-a209-030f8bcf2029"), false, 0m, false, null, "Medium2", false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("0e916c39-702e-45b9-9dad-b1205c9368b0"), new Guid("e59d20c1-944c-4c3d-834c-d3dbc75fd7b8"), new Guid("fe0adf40-e1fe-4b1c-a209-030f8bcf2029") },
                    { new Guid("30133280-dd9b-42a8-bed0-f43ff3d7090d"), new Guid("aaee55ff-4bf6-4a0e-9268-64f56da1a636"), new Guid("3d2e69eb-f5de-45f4-b0a5-b7ac107d65ac") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("13e17db0-1b80-4fae-a896-0936aa8c5e51"), new Guid("8306c8ce-c7fc-41e4-a2db-4687bc0cb6b8"), null, "Eddies only profile Picture" },
                    { new Guid("1824c023-fec8-4a77-94cf-bc40683bdd2b"), new Guid("8298f4ad-b9ca-402f-9af4-66abddc4dfe8"), null, "Thors first profile Picture" },
                    { new Guid("4dcf3242-b024-49df-98c5-b317f7377e72"), new Guid("8298f4ad-b9ca-402f-9af4-66abddc4dfe8"), null, "Thors second profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("2debb987-2bbf-4279-ab1b-cab02d28c87c"), new Guid("8298f4ad-b9ca-402f-9af4-66abddc4dfe8") },
                    { new Guid("af288ea8-299c-41b0-934e-a53962633839"), new Guid("8306c8ce-c7fc-41e4-a2db-4687bc0cb6b8") }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("ec373f9d-f29a-48cd-b8b1-eb77bba5368c"), new Guid("f532bb06-52c4-4132-ab76-c35499ab550c") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("5ff8184e-ba7d-457e-80ab-a1dfce3121b1"), new Guid("b1c7db48-f13f-4eaa-911c-947a7b4f1789"), null, new Guid("f532bb06-52c4-4132-ab76-c35499ab550c") },
                    { new Guid("aa02d354-e7e1-427e-9a4c-4b00e811fe2d"), new Guid("f63bc64b-81dd-4692-9d61-50f4c1521ef4"), null, new Guid("f532bb06-52c4-4132-ab76-c35499ab550c") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming", "UserHobbiesRelationShipsId" },
                values: new object[,]
                {
                    { new Guid("3239d03e-e43e-4d16-ab0c-3b777ee0892f"), true, false, false, true, false, false, true, null },
                    { new Guid("ca69a174-e48d-4b7d-85b8-324d44303959"), false, true, false, false, false, false, false, null }
                });

            migrationBuilder.InsertData(
                table: "UserHobbiesRelationShips",
                columns: new[] { "Id", "DislikesId", "LikesId" },
                values: new object[] { new Guid("431efe1a-7cb1-47dd-ba45-aebf2aeaf6b0"), new Guid("ca69a174-e48d-4b7d-85b8-324d44303959"), new Guid("3239d03e-e43e-4d16-ab0c-3b777ee0892f") });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("6e928a9a-9b8c-4f12-a47a-3fa4bafece90"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "Name" },
                values: new object[,]
                {
                    { new Guid("b1c7db48-f13f-4eaa-911c-947a7b4f1789"), null, 11, false, 2, 1, new Guid("30133280-dd9b-42a8-bed0-f43ff3d7090d"), new Guid("2debb987-2bbf-4279-ab1b-cab02d28c87c"), 4, "Thor" },
                    { new Guid("f63bc64b-81dd-4692-9d61-50f4c1521ef4"), null, 1, false, 1, 2, new Guid("0e916c39-702e-45b9-9dad-b1205c9368b0"), new Guid("af288ea8-299c-41b0-934e-a53962633839"), 3, "Eddie" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "Gender", "Job", "Location", "Sexuality", "UserHobbiesRelationshipsId", "UserPreferencesId" },
                values: new object[] { new Guid("faa6ad97-c323-4f67-accc-989502410aa4"), "Test Content", "Male", "Student", "Bullaren", "Bisexual", new Guid("431efe1a-7cb1-47dd-ba45-aebf2aeaf6b0"), new Guid("6e928a9a-9b8c-4f12-a47a-3fa4bafece90") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("b4808f30-4cd4-492c-bda8-fc491187931f"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("ec373f9d-f29a-48cd-b8b1-eb77bba5368c"), new Guid("faa6ad97-c323-4f67-accc-989502410aa4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("3d2e69eb-f5de-45f4-b0a5-b7ac107d65ac"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("aaee55ff-4bf6-4a0e-9268-64f56da1a636"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("e59d20c1-944c-4c3d-834c-d3dbc75fd7b8"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("fe0adf40-e1fe-4b1c-a209-030f8bcf2029"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("13e17db0-1b80-4fae-a896-0936aa8c5e51"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("1824c023-fec8-4a77-94cf-bc40683bdd2b"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("4dcf3242-b024-49df-98c5-b317f7377e72"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("b1c7db48-f13f-4eaa-911c-947a7b4f1789"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("f63bc64b-81dd-4692-9d61-50f4c1521ef4"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("5ff8184e-ba7d-457e-80ab-a1dfce3121b1"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("aa02d354-e7e1-427e-9a4c-4b00e811fe2d"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("3239d03e-e43e-4d16-ab0c-3b777ee0892f"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("ca69a174-e48d-4b7d-85b8-324d44303959"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4808f30-4cd4-492c-bda8-fc491187931f"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("0e916c39-702e-45b9-9dad-b1205c9368b0"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("30133280-dd9b-42a8-bed0-f43ff3d7090d"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("2debb987-2bbf-4279-ab1b-cab02d28c87c"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("af288ea8-299c-41b0-934e-a53962633839"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("ec373f9d-f29a-48cd-b8b1-eb77bba5368c"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("faa6ad97-c323-4f67-accc-989502410aa4"));

            migrationBuilder.DeleteData(
                table: "UserHobbiesRelationShips",
                keyColumn: "Id",
                keyValue: new Guid("431efe1a-7cb1-47dd-ba45-aebf2aeaf6b0"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("6e928a9a-9b8c-4f12-a47a-3fa4bafece90"));

            migrationBuilder.AlterColumn<int>(
                name: "YoungestAge",
                table: "UserPreferences",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OldestAge",
                table: "UserPreferences",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocationRange",
                table: "UserPreferences",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "UserPreferences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
