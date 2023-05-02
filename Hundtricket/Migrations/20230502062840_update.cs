using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("26e2922f-83cb-4f52-9ed8-9ab17c7e729f"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("9aef8b61-36e6-4320-a353-919d6607edb2"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("af55df1e-144e-4ad9-99e1-e7963a79308f"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("bfd03a4b-aaf9-4d07-a172-57a90bb4efdd"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("968d787a-5721-4a90-8e87-146f19a27503"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("9ee1fe8d-652d-427a-a1dd-67fa6dca7f5e"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("c9b55875-c1ae-420b-a5fc-b9966ff377ed"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("297b7ebd-17b2-45bd-98a4-1b0dff1af087"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("8d6bb601-7c2f-4bc8-b0e3-704758facb53"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("1dc3fbc0-0ec0-4f1e-b183-73c43cd9f0fd"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("bce4d1be-1e2a-4e9f-b143-f5ecbbc7d320"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84c98b27-fd27-4530-8ac4-a5de2ed88c45"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("24a9f4e6-85ad-4e75-85c7-4eeb407315b4"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("ac9c3e0b-23ad-4aa8-b3a7-f470395d5e50"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("9746b7e7-74cc-4d73-a8ae-2566e65411ff"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("fb195804-0a4c-4c5e-a278-cde2dfd72dbd"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("0aad4509-0236-4eca-9334-455cb02db57c"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("fbdfbaae-8d26-4eb8-9cfd-ce7322cf2311"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("f67b9a94-2a14-42b7-aedf-5fc414f4eeac"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("fe363297-0904-41b8-8ef7-e4e01208b0a0"));

            migrationBuilder.InsertData(
                table: "DogFilters",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "DogFiltersRelationshipsId", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("03b0a933-9568-441d-a7ba-0e91688e0ede"), false, 0m, false, null, false, false, false, false, false },
                    { new Guid("3e9657b0-bb3c-49e1-944d-49efaf3783b6"), false, 0m, false, null, false, false, false, false, false },
                    { new Guid("a6ea24a7-3630-4dc8-806f-9d49b5619b39"), false, 0m, false, null, false, false, false, false, false },
                    { new Guid("cc92ebca-35d1-4502-aaf7-fc3de946e8c3"), false, 0m, false, null, false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("18c979c0-4f63-4f06-95d3-270d9a079ba8"), new Guid("cc92ebca-35d1-4502-aaf7-fc3de946e8c3"), new Guid("3e9657b0-bb3c-49e1-944d-49efaf3783b6") },
                    { new Guid("4796463d-2cfc-4e5d-a36e-6d0416b07473"), new Guid("03b0a933-9568-441d-a7ba-0e91688e0ede"), new Guid("a6ea24a7-3630-4dc8-806f-9d49b5619b39") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("6d15558c-29ae-4efc-b7d0-9dbfb7097dca"), new Guid("3bd979bb-1f26-4ab2-bbc1-3f1deee4451b"), null, "Thors first profile Picture" },
                    { new Guid("acaed7cb-f399-4b90-97b6-d73cd5680c03"), new Guid("3bd979bb-1f26-4ab2-bbc1-3f1deee4451b"), null, "Thors second profile Picture" },
                    { new Guid("c6e5cf6c-65cc-4ccf-a6b3-05dc371e806b"), new Guid("fadb314c-6ba7-481e-895a-8e970009d6b4"), null, "Eddies only profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("017d061b-805c-4e41-b560-ae07bdaed8de"), new Guid("3bd979bb-1f26-4ab2-bbc1-3f1deee4451b") },
                    { new Guid("17ac59a1-93ac-45fa-97ad-abb6815d5eb6"), new Guid("fadb314c-6ba7-481e-895a-8e970009d6b4") }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("8e10901a-03f0-450d-ba77-46767aadbf34"), new Guid("e758e986-2287-4161-b034-543aefbccb26") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("44ed7340-380e-4423-be55-4579286baef4"), new Guid("9221a252-463a-4faa-ab1f-6dd7abb1e5c8"), null, new Guid("e758e986-2287-4161-b034-543aefbccb26") },
                    { new Guid("9b0428e2-a609-4e55-966c-40212b0ed775"), new Guid("47784e4b-02a7-4b06-8a92-3db141b465ea"), null, new Guid("e758e986-2287-4161-b034-543aefbccb26") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming" },
                values: new object[] { new Guid("a6cd577a-ad2b-40b4-a04b-7ba5b1e30131"), true, false, false, true, false, false, true });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("3a85de46-687b-4107-bf1a-fd2af381e325"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "GenderId", "Name" },
                values: new object[,]
                {
                    { new Guid("47784e4b-02a7-4b06-8a92-3db141b465ea"), null, 11, false, 2, 1, new Guid("18c979c0-4f63-4f06-95d3-270d9a079ba8"), new Guid("017d061b-805c-4e41-b560-ae07bdaed8de"), 4, 1, "Thor" },
                    { new Guid("9221a252-463a-4faa-ab1f-6dd7abb1e5c8"), null, 1, false, 1, 2, new Guid("4796463d-2cfc-4e5d-a36e-6d0416b07473"), new Guid("17ac59a1-93ac-45fa-97ad-abb6815d5eb6"), 3, 1, "Eddie" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "GenderId", "Job", "Location", "Sexuality", "UserHobbiesId", "UserPreferencesId" },
                values: new object[] { new Guid("6e255e05-1446-4664-9f9e-3f72568f3c4b"), "Test Content", 1, "Student", "Bullaren", "Bisexual", new Guid("a6cd577a-ad2b-40b4-a04b-7ba5b1e30131"), new Guid("3a85de46-687b-4107-bf1a-fd2af381e325") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsSignedOn", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("eebd1dcf-71f7-4407-8713-206e489d39ae"), 30, "Nixgabriel92@gmail.com", "Gabriel", false, "Nix", "Blank", new Guid("8e10901a-03f0-450d-ba77-46767aadbf34"), new Guid("6e255e05-1446-4664-9f9e-3f72568f3c4b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("03b0a933-9568-441d-a7ba-0e91688e0ede"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("3e9657b0-bb3c-49e1-944d-49efaf3783b6"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("a6ea24a7-3630-4dc8-806f-9d49b5619b39"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("cc92ebca-35d1-4502-aaf7-fc3de946e8c3"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("6d15558c-29ae-4efc-b7d0-9dbfb7097dca"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("acaed7cb-f399-4b90-97b6-d73cd5680c03"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("c6e5cf6c-65cc-4ccf-a6b3-05dc371e806b"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("47784e4b-02a7-4b06-8a92-3db141b465ea"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("9221a252-463a-4faa-ab1f-6dd7abb1e5c8"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("44ed7340-380e-4423-be55-4579286baef4"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("9b0428e2-a609-4e55-966c-40212b0ed775"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eebd1dcf-71f7-4407-8713-206e489d39ae"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("18c979c0-4f63-4f06-95d3-270d9a079ba8"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("4796463d-2cfc-4e5d-a36e-6d0416b07473"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("017d061b-805c-4e41-b560-ae07bdaed8de"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("17ac59a1-93ac-45fa-97ad-abb6815d5eb6"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("8e10901a-03f0-450d-ba77-46767aadbf34"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("6e255e05-1446-4664-9f9e-3f72568f3c4b"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("a6cd577a-ad2b-40b4-a04b-7ba5b1e30131"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("3a85de46-687b-4107-bf1a-fd2af381e325"));

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
        }
    }
}
