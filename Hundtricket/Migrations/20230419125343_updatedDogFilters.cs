using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedDogFilters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("1e312692-c7cd-43b2-b9aa-6486fab4d2cb"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("29c7ee0a-36fd-4218-ba53-01e99cee40ea"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("65db0298-478b-410d-b99d-f72cdaf8ffc8"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("eef40999-df7f-4423-a525-63285414b75e"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("46741b7c-7ab8-48fa-85e5-d62bf04ba235"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("60a3793a-6162-4f03-8e25-dfe32432b937"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("61fb9267-d3b8-4a40-8ef4-de8b4c3e8483"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("835bb5bd-b6e0-43ad-bb01-8f94b3e7ee1d"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("b7a35587-b850-4a4c-9194-4c43f9848ddf"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("3655b749-ffd3-4192-a39c-8a9d2fb6cd58"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("c2b9fae1-a885-4abe-8779-46c31863af4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("254e7415-9c69-4db1-8b7f-870c7215a288"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("0b0d5e86-5e69-4a75-a855-2b7734288701"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("e3b05007-769e-4bbe-b120-9616026320cb"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("0affa998-69f8-418b-9f03-4797cb0cdc0b"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("c980ec65-548c-46c9-a47e-8a1b809aa7ab"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("286e6c89-bf6f-4a79-bb4c-78b468547200"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("7429b0a4-772d-482e-bac5-f89d7c87e8ad"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("b0cee314-f5f7-4822-85c7-35f5b934b460"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("84c237b1-1ceb-4826-810e-069976702dc8"));

            migrationBuilder.DropColumn(
                name: "EnergyLevel",
                table: "DogFilters");

            migrationBuilder.InsertData(
                table: "DogFilters",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "DogFiltersRelationshipsId", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("00730a5f-fb76-4581-9457-e415750a0ff7"), false, 0m, false, null, false, false, false, false, false },
                    { new Guid("99c416cf-0bfe-40fc-9efd-56a8ddd09722"), false, 0m, false, null, false, false, false, false, false },
                    { new Guid("afca829a-ab8c-4019-bf05-cc99e943ff7b"), false, 0m, false, null, false, false, false, false, false },
                    { new Guid("fe917ee2-86d0-4388-8904-03334e8a764c"), false, 0m, false, null, false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("658d7b9d-764d-4c3a-96d4-4631183c087a"), new Guid("00730a5f-fb76-4581-9457-e415750a0ff7"), new Guid("afca829a-ab8c-4019-bf05-cc99e943ff7b") },
                    { new Guid("ff78fa13-a3a8-41f4-bd09-337b8ceff040"), new Guid("fe917ee2-86d0-4388-8904-03334e8a764c"), new Guid("99c416cf-0bfe-40fc-9efd-56a8ddd09722") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("01e79d1b-06dc-4ed8-9690-0d05c11ec117"), new Guid("e35a3fca-5608-41a3-9aad-1c84f45827ee"), null, "Thors first profile Picture" },
                    { new Guid("2e80ea6b-bd2a-4e0f-8300-3985f96039e2"), new Guid("5811871d-4e99-46c8-99fb-1729ec0efceb"), null, "Eddies only profile Picture" },
                    { new Guid("bf0d8d12-43f4-421b-875c-113b653f72c2"), new Guid("e35a3fca-5608-41a3-9aad-1c84f45827ee"), null, "Thors second profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("7e748001-5f32-4c81-8020-685108ffa788"), new Guid("5811871d-4e99-46c8-99fb-1729ec0efceb") },
                    { new Guid("f517bb3e-5929-4528-9290-92c6932a9c77"), new Guid("e35a3fca-5608-41a3-9aad-1c84f45827ee") }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("02d033b1-bb7f-488b-9004-4f2a22f29910"), new Guid("21e87474-15bd-45a7-9c66-e655444252f5") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("06955abf-86a1-404b-b3a2-c0957f8f7e2d"), new Guid("2d4f88ff-e248-435e-b655-1a6b29e65f57"), null, new Guid("21e87474-15bd-45a7-9c66-e655444252f5") },
                    { new Guid("ebb82248-2fbe-44b6-b6e1-5b36db21699e"), new Guid("b444dec1-8d1b-4d46-b9a9-2e876b81490a"), null, new Guid("21e87474-15bd-45a7-9c66-e655444252f5") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming" },
                values: new object[] { new Guid("142d377e-fc31-4061-af75-d3a0b06f3338"), true, false, false, true, false, false, true });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("f33f6ecf-e294-4f8c-9ad8-4a745bb61fbd"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "Gender", "Name" },
                values: new object[,]
                {
                    { new Guid("2d4f88ff-e248-435e-b655-1a6b29e65f57"), null, 1, false, 1, 2, new Guid("ff78fa13-a3a8-41f4-bd09-337b8ceff040"), new Guid("7e748001-5f32-4c81-8020-685108ffa788"), 3, "Male", "Eddie" },
                    { new Guid("b444dec1-8d1b-4d46-b9a9-2e876b81490a"), null, 11, false, 2, 1, new Guid("658d7b9d-764d-4c3a-96d4-4631183c087a"), new Guid("f517bb3e-5929-4528-9290-92c6932a9c77"), 4, "Male", "Thor" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "Gender", "Job", "Location", "Sexuality", "UserHobbiesId", "UserPreferencesId" },
                values: new object[] { new Guid("79c948be-2c7c-42e7-8f7c-76dd97d5b661"), "Test Content", "Male", "Student", "Bullaren", "Bisexual", new Guid("142d377e-fc31-4061-af75-d3a0b06f3338"), new Guid("f33f6ecf-e294-4f8c-9ad8-4a745bb61fbd") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("34c7f006-d10a-4f77-85b3-b3d73675a4f0"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("02d033b1-bb7f-488b-9004-4f2a22f29910"), new Guid("79c948be-2c7c-42e7-8f7c-76dd97d5b661") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("00730a5f-fb76-4581-9457-e415750a0ff7"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("99c416cf-0bfe-40fc-9efd-56a8ddd09722"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("afca829a-ab8c-4019-bf05-cc99e943ff7b"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("fe917ee2-86d0-4388-8904-03334e8a764c"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("01e79d1b-06dc-4ed8-9690-0d05c11ec117"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("2e80ea6b-bd2a-4e0f-8300-3985f96039e2"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("bf0d8d12-43f4-421b-875c-113b653f72c2"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("2d4f88ff-e248-435e-b655-1a6b29e65f57"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("b444dec1-8d1b-4d46-b9a9-2e876b81490a"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("06955abf-86a1-404b-b3a2-c0957f8f7e2d"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("ebb82248-2fbe-44b6-b6e1-5b36db21699e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34c7f006-d10a-4f77-85b3-b3d73675a4f0"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("658d7b9d-764d-4c3a-96d4-4631183c087a"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("ff78fa13-a3a8-41f4-bd09-337b8ceff040"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("7e748001-5f32-4c81-8020-685108ffa788"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("f517bb3e-5929-4528-9290-92c6932a9c77"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("02d033b1-bb7f-488b-9004-4f2a22f29910"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("79c948be-2c7c-42e7-8f7c-76dd97d5b661"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("142d377e-fc31-4061-af75-d3a0b06f3338"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("f33f6ecf-e294-4f8c-9ad8-4a745bb61fbd"));

            migrationBuilder.AddColumn<string>(
                name: "EnergyLevel",
                table: "DogFilters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "DogFilters",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "DogFiltersRelationshipsId", "EnergyLevel", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("1e312692-c7cd-43b2-b9aa-6486fab4d2cb"), false, 0m, false, null, "Medium2", false, false, false, false, false },
                    { new Guid("29c7ee0a-36fd-4218-ba53-01e99cee40ea"), false, 0m, false, null, "Low2", false, false, false, false, false },
                    { new Guid("65db0298-478b-410d-b99d-f72cdaf8ffc8"), false, 0m, false, null, "Low", false, false, false, false, false },
                    { new Guid("eef40999-df7f-4423-a525-63285414b75e"), false, 0m, false, null, "Medium", false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("0b0d5e86-5e69-4a75-a855-2b7734288701"), new Guid("eef40999-df7f-4423-a525-63285414b75e"), new Guid("1e312692-c7cd-43b2-b9aa-6486fab4d2cb") },
                    { new Guid("e3b05007-769e-4bbe-b120-9616026320cb"), new Guid("65db0298-478b-410d-b99d-f72cdaf8ffc8"), new Guid("29c7ee0a-36fd-4218-ba53-01e99cee40ea") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("46741b7c-7ab8-48fa-85e5-d62bf04ba235"), new Guid("097f5cf3-6f56-4170-9fc0-3fff404fca57"), null, "Eddies only profile Picture" },
                    { new Guid("60a3793a-6162-4f03-8e25-dfe32432b937"), new Guid("53d6ac1a-b04a-4d01-849b-f7b3b4840616"), null, "Thors first profile Picture" },
                    { new Guid("61fb9267-d3b8-4a40-8ef4-de8b4c3e8483"), new Guid("53d6ac1a-b04a-4d01-849b-f7b3b4840616"), null, "Thors second profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("0affa998-69f8-418b-9f03-4797cb0cdc0b"), new Guid("53d6ac1a-b04a-4d01-849b-f7b3b4840616") },
                    { new Guid("c980ec65-548c-46c9-a47e-8a1b809aa7ab"), new Guid("097f5cf3-6f56-4170-9fc0-3fff404fca57") }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("286e6c89-bf6f-4a79-bb4c-78b468547200"), new Guid("32d74158-c1d5-4bb0-a4b2-f8e8be50253c") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("3655b749-ffd3-4192-a39c-8a9d2fb6cd58"), new Guid("b7a35587-b850-4a4c-9194-4c43f9848ddf"), null, new Guid("32d74158-c1d5-4bb0-a4b2-f8e8be50253c") },
                    { new Guid("c2b9fae1-a885-4abe-8779-46c31863af4d"), new Guid("835bb5bd-b6e0-43ad-bb01-8f94b3e7ee1d"), null, new Guid("32d74158-c1d5-4bb0-a4b2-f8e8be50253c") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming" },
                values: new object[] { new Guid("b0cee314-f5f7-4822-85c7-35f5b934b460"), true, false, false, true, false, false, true });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("84c237b1-1ceb-4826-810e-069976702dc8"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "Gender", "Name" },
                values: new object[,]
                {
                    { new Guid("835bb5bd-b6e0-43ad-bb01-8f94b3e7ee1d"), null, 1, false, 1, 2, new Guid("0b0d5e86-5e69-4a75-a855-2b7734288701"), new Guid("c980ec65-548c-46c9-a47e-8a1b809aa7ab"), 3, "Male", "Eddie" },
                    { new Guid("b7a35587-b850-4a4c-9194-4c43f9848ddf"), null, 11, false, 2, 1, new Guid("e3b05007-769e-4bbe-b120-9616026320cb"), new Guid("0affa998-69f8-418b-9f03-4797cb0cdc0b"), 4, "Male", "Thor" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "Gender", "Job", "Location", "Sexuality", "UserHobbiesId", "UserPreferencesId" },
                values: new object[] { new Guid("7429b0a4-772d-482e-bac5-f89d7c87e8ad"), "Test Content", "Male", "Student", "Bullaren", "Bisexual", new Guid("b0cee314-f5f7-4822-85c7-35f5b934b460"), new Guid("84c237b1-1ceb-4826-810e-069976702dc8") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("254e7415-9c69-4db1-8b7f-870c7215a288"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("286e6c89-bf6f-4a79-bb4c-78b468547200"), new Guid("7429b0a4-772d-482e-bac5-f89d7c87e8ad") });
        }
    }
}
