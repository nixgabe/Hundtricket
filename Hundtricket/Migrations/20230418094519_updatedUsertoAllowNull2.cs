using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedUsertoAllowNull2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Sexuality",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "DogFilters",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "DogFiltersRelationshipsId", "EnergyLevel", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("2bc1e9ca-29a6-4332-bb03-156a0d810818"), false, 0m, false, null, "Low", false, false, false, false, false },
                    { new Guid("654f517b-d5cc-4620-b2cf-7614734c08be"), false, 0m, false, null, "Medium", false, false, false, false, false },
                    { new Guid("9c249f11-4ee1-4d5f-bc3f-ab4611dce55b"), false, 0m, false, null, "Medium2", false, false, false, false, false },
                    { new Guid("be583850-3c88-479f-9f3a-1fd1cab29a45"), false, 0m, false, null, "Low2", false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("41c1ae82-9f5d-4125-b134-4768a4b6379a"), new Guid("2bc1e9ca-29a6-4332-bb03-156a0d810818"), new Guid("be583850-3c88-479f-9f3a-1fd1cab29a45") },
                    { new Guid("cfc573ca-9d1d-49a0-b1d8-5bcaae0b3e73"), new Guid("654f517b-d5cc-4620-b2cf-7614734c08be"), new Guid("9c249f11-4ee1-4d5f-bc3f-ab4611dce55b") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("9db96541-ca78-43ff-bb3f-8b805c8e61b1"), new Guid("eeae08b1-f64c-43f6-a944-afd481a5d208"), null, "Thors second profile Picture" },
                    { new Guid("ed0b4256-9ef8-4889-b311-d16379f6e3fb"), new Guid("eeae08b1-f64c-43f6-a944-afd481a5d208"), null, "Thors first profile Picture" },
                    { new Guid("fec5d52f-b724-47c5-8479-ab60fb4de8b0"), new Guid("6f354ed5-b90c-40ac-b755-19809199e5cb"), null, "Eddies only profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("d405858d-a2cd-4adc-afb0-4bdbf199b953"), new Guid("6f354ed5-b90c-40ac-b755-19809199e5cb") },
                    { new Guid("ee67df58-ad08-4fef-a6f8-d7e1357b1a3f"), new Guid("eeae08b1-f64c-43f6-a944-afd481a5d208") }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("a89d4696-bb8b-47cb-b531-6fd4b14610a5"), new Guid("5af92ab9-2d21-4ee8-b1fd-e71acb9cbb61") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("752342a0-5e17-4740-9a43-50f59748a89d"), new Guid("68f9fd64-8e35-4756-9b19-7ea6f7eef4a4"), null, new Guid("5af92ab9-2d21-4ee8-b1fd-e71acb9cbb61") },
                    { new Guid("f86c2f00-b6d4-4c64-8a33-f91b41ce0eb2"), new Guid("1830331f-1d41-4cc9-b321-9b40369a14a0"), null, new Guid("5af92ab9-2d21-4ee8-b1fd-e71acb9cbb61") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming", "UserHobbiesRelationShipsId" },
                values: new object[,]
                {
                    { new Guid("8e39158a-44b0-4e3e-bda2-08dda146fc8c"), false, true, false, false, false, false, false, null },
                    { new Guid("f77e7105-fa44-420d-91a3-941e2236b945"), true, false, false, true, false, false, true, null }
                });

            migrationBuilder.InsertData(
                table: "UserHobbiesRelationShips",
                columns: new[] { "Id", "DislikesId", "LikesId" },
                values: new object[] { new Guid("f5e28e93-2e8a-401c-9fea-69bf4d573695"), new Guid("8e39158a-44b0-4e3e-bda2-08dda146fc8c"), new Guid("f77e7105-fa44-420d-91a3-941e2236b945") });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("6ea11c65-c1a6-423b-8c98-bd2dcc9328b2"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "Name" },
                values: new object[,]
                {
                    { new Guid("1830331f-1d41-4cc9-b321-9b40369a14a0"), null, 11, false, 2, 1, new Guid("41c1ae82-9f5d-4125-b134-4768a4b6379a"), new Guid("ee67df58-ad08-4fef-a6f8-d7e1357b1a3f"), 4, "Thor" },
                    { new Guid("68f9fd64-8e35-4756-9b19-7ea6f7eef4a4"), null, 1, false, 1, 2, new Guid("cfc573ca-9d1d-49a0-b1d8-5bcaae0b3e73"), new Guid("d405858d-a2cd-4adc-afb0-4bdbf199b953"), 3, "Eddie" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "Gender", "Job", "Location", "Sexuality", "UserHobbiesRelationshipsId", "UserPreferencesId" },
                values: new object[] { new Guid("e8f019b9-31f3-4d1f-b1f2-0d5415829ce8"), "Test Content", "Male", "Student", "Bullaren", "Bisexual", new Guid("f5e28e93-2e8a-401c-9fea-69bf4d573695"), new Guid("6ea11c65-c1a6-423b-8c98-bd2dcc9328b2") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("042e0a2d-66eb-4e7d-965b-34c5d7e18639"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("a89d4696-bb8b-47cb-b531-6fd4b14610a5"), new Guid("e8f019b9-31f3-4d1f-b1f2-0d5415829ce8") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("2bc1e9ca-29a6-4332-bb03-156a0d810818"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("654f517b-d5cc-4620-b2cf-7614734c08be"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("9c249f11-4ee1-4d5f-bc3f-ab4611dce55b"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("be583850-3c88-479f-9f3a-1fd1cab29a45"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("9db96541-ca78-43ff-bb3f-8b805c8e61b1"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("ed0b4256-9ef8-4889-b311-d16379f6e3fb"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("fec5d52f-b724-47c5-8479-ab60fb4de8b0"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("1830331f-1d41-4cc9-b321-9b40369a14a0"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("68f9fd64-8e35-4756-9b19-7ea6f7eef4a4"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("752342a0-5e17-4740-9a43-50f59748a89d"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("f86c2f00-b6d4-4c64-8a33-f91b41ce0eb2"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("8e39158a-44b0-4e3e-bda2-08dda146fc8c"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("f77e7105-fa44-420d-91a3-941e2236b945"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("042e0a2d-66eb-4e7d-965b-34c5d7e18639"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("41c1ae82-9f5d-4125-b134-4768a4b6379a"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("cfc573ca-9d1d-49a0-b1d8-5bcaae0b3e73"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("d405858d-a2cd-4adc-afb0-4bdbf199b953"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("ee67df58-ad08-4fef-a6f8-d7e1357b1a3f"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("a89d4696-bb8b-47cb-b531-6fd4b14610a5"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("e8f019b9-31f3-4d1f-b1f2-0d5415829ce8"));

            migrationBuilder.DeleteData(
                table: "UserHobbiesRelationShips",
                keyColumn: "Id",
                keyValue: new Guid("f5e28e93-2e8a-401c-9fea-69bf4d573695"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("6ea11c65-c1a6-423b-8c98-bd2dcc9328b2"));

            migrationBuilder.AlterColumn<string>(
                name: "Sexuality",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "UserProfiles",
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
    }
}
