using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateddogbreeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("154544e5-0ceb-4e0b-8a05-19a550eab0a6"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("573b0558-a071-4a70-a6ca-d2bfc67d58bf"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("636fc45b-7bb8-4c4d-9e7f-54cdb934527f"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("fc6055f3-f1af-44a9-9aef-8483cba183f4"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("4d4d96a7-1c9e-4083-8f0d-d0af3ea7667e"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("63d3830f-f3c8-48a9-9720-7ad7436928b0"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("a1ae404a-29be-492f-9fcc-e255666b6c7e"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("58d2a1d1-41c4-463e-8b03-4331d25afb19"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("6c426a0f-7479-4d0a-b859-3aa902eef68c"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("099d4186-1bd4-4609-84f0-03884995e210"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("7848a28f-de24-45dd-9c06-f025e6c64c73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("904fc15a-eeeb-45b8-9ad9-53d6e8ccd2f2"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("6e3814b0-4f69-4f6b-a1de-dc8cdca683a9"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("facd3d74-653b-411b-8da9-7d8e9641784d"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("f83e87d7-e89d-42ec-96ac-619d6f601f1d"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("f8ecea09-bc87-48b9-8a1e-efc892ae88a6"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("d697b631-4a09-4b47-82d4-8b2550bd9e3c"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("2742fb40-67ac-4e65-a959-df5895286628"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("58b59ef1-225a-4bfd-b71c-1a91ba536955"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("ef7c000d-1d12-4feb-932d-80c11067a08a"));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Dogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "Breed" },
                values: new object[,]
                {
                    { 3, "Golden Retriever" },
                    { 4, "German Shepherd" },
                    { 5, "Borzoi" },
                    { 6, "Yorkshire Terrier" },
                    { 7, "Beagle" },
                    { 8, "Great Dane" },
                    { 9, "Siberian Husky" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 9);

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
                name: "Gender",
                table: "Dogs");

            migrationBuilder.InsertData(
                table: "DogFilters",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "DogFiltersRelationshipsId", "EnergyLevel", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("154544e5-0ceb-4e0b-8a05-19a550eab0a6"), false, 0m, false, null, "Low2", false, false, false, false, false },
                    { new Guid("573b0558-a071-4a70-a6ca-d2bfc67d58bf"), false, 0m, false, null, "Medium", false, false, false, false, false },
                    { new Guid("636fc45b-7bb8-4c4d-9e7f-54cdb934527f"), false, 0m, false, null, "Medium2", false, false, false, false, false },
                    { new Guid("fc6055f3-f1af-44a9-9aef-8483cba183f4"), false, 0m, false, null, "Low", false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("6e3814b0-4f69-4f6b-a1de-dc8cdca683a9"), new Guid("573b0558-a071-4a70-a6ca-d2bfc67d58bf"), new Guid("636fc45b-7bb8-4c4d-9e7f-54cdb934527f") },
                    { new Guid("facd3d74-653b-411b-8da9-7d8e9641784d"), new Guid("fc6055f3-f1af-44a9-9aef-8483cba183f4"), new Guid("154544e5-0ceb-4e0b-8a05-19a550eab0a6") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("4d4d96a7-1c9e-4083-8f0d-d0af3ea7667e"), new Guid("eaa470cb-086e-478a-ac24-9b1867348337"), null, "Thors second profile Picture" },
                    { new Guid("63d3830f-f3c8-48a9-9720-7ad7436928b0"), new Guid("eaa470cb-086e-478a-ac24-9b1867348337"), null, "Thors first profile Picture" },
                    { new Guid("a1ae404a-29be-492f-9fcc-e255666b6c7e"), new Guid("fc36a634-28a5-450e-a1f3-dd61bf9be713"), null, "Eddies only profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("f83e87d7-e89d-42ec-96ac-619d6f601f1d"), new Guid("fc36a634-28a5-450e-a1f3-dd61bf9be713") },
                    { new Guid("f8ecea09-bc87-48b9-8a1e-efc892ae88a6"), new Guid("eaa470cb-086e-478a-ac24-9b1867348337") }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("d697b631-4a09-4b47-82d4-8b2550bd9e3c"), new Guid("93e1d209-3dac-4c60-8839-771547ce4b7d") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("099d4186-1bd4-4609-84f0-03884995e210"), new Guid("58d2a1d1-41c4-463e-8b03-4331d25afb19"), null, new Guid("93e1d209-3dac-4c60-8839-771547ce4b7d") },
                    { new Guid("7848a28f-de24-45dd-9c06-f025e6c64c73"), new Guid("6c426a0f-7479-4d0a-b859-3aa902eef68c"), null, new Guid("93e1d209-3dac-4c60-8839-771547ce4b7d") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming" },
                values: new object[] { new Guid("58b59ef1-225a-4bfd-b71c-1a91ba536955"), true, false, false, true, false, false, true });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("ef7c000d-1d12-4feb-932d-80c11067a08a"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "Name" },
                values: new object[,]
                {
                    { new Guid("58d2a1d1-41c4-463e-8b03-4331d25afb19"), null, 1, false, 1, 2, new Guid("6e3814b0-4f69-4f6b-a1de-dc8cdca683a9"), new Guid("f83e87d7-e89d-42ec-96ac-619d6f601f1d"), 3, "Eddie" },
                    { new Guid("6c426a0f-7479-4d0a-b859-3aa902eef68c"), null, 11, false, 2, 1, new Guid("facd3d74-653b-411b-8da9-7d8e9641784d"), new Guid("f8ecea09-bc87-48b9-8a1e-efc892ae88a6"), 4, "Thor" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "Gender", "Job", "Location", "Sexuality", "UserHobbiesId", "UserPreferencesId" },
                values: new object[] { new Guid("2742fb40-67ac-4e65-a959-df5895286628"), "Test Content", "Male", "Student", "Bullaren", "Bisexual", new Guid("58b59ef1-225a-4bfd-b71c-1a91ba536955"), new Guid("ef7c000d-1d12-4feb-932d-80c11067a08a") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("904fc15a-eeeb-45b8-9ad9-53d6e8ccd2f2"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("d697b631-4a09-4b47-82d4-8b2550bd9e3c"), new Guid("2742fb40-67ac-4e65-a959-df5895286628") });
        }
    }
}
