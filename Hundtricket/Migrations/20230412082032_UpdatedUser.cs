using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserDogRelationships_UserDogRelationshipsId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserProfiles_UserProfileId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("0f3a3690-9e28-46f7-af88-ce63a16986ec"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("4d86f4ab-da1d-4e5d-958a-93d620ff12b5"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("6d37cc29-2c57-45df-894c-0e71b0224d12"));

            migrationBuilder.DeleteData(
                table: "DogFilters",
                keyColumn: "Id",
                keyValue: new Guid("74b11255-c5b3-41b3-991c-c227bcb65523"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("14fd0136-6ddf-4168-8a06-0fe6b45c4ad0"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("76c324d6-224c-41ab-ad5f-acf07c727a6c"));

            migrationBuilder.DeleteData(
                table: "DogPictures",
                keyColumn: "Id",
                keyValue: new Guid("95145914-ba83-4ebf-b5ba-8ccb041c7e69"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("c997349a-a56e-4027-8e8f-d509d1601ea5"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: new Guid("f4a1567e-5600-44a7-b6b8-b8804c92f191"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("6ebf9138-3792-45d6-9520-24314d596ecd"));

            migrationBuilder.DeleteData(
                table: "UserDogs",
                keyColumn: "Id",
                keyValue: new Guid("c9b8c472-b5bd-4466-a582-0ab6430254f2"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("0736a20b-a6f6-48de-a21b-415181c9751f"));

            migrationBuilder.DeleteData(
                table: "UserHobbies",
                keyColumn: "Id",
                keyValue: new Guid("18ae64cb-2303-4b5d-aa9a-b88e95a0e6fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30e5ce5c-21dd-4861-a5f7-91b4afdfd802"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("ae4e1834-f846-4a21-b8aa-9cb8c3100c34"));

            migrationBuilder.DeleteData(
                table: "DogFiltersRelationships",
                keyColumn: "Id",
                keyValue: new Guid("ea6e5e26-2272-436e-a2d6-13a47efbd70e"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("51515a17-24ae-49af-bf57-609d5ad69349"));

            migrationBuilder.DeleteData(
                table: "DogPicturesRelationships",
                keyColumn: "Id",
                keyValue: new Guid("c9f255e4-3a7b-42de-9dfb-4e5822a8716a"));

            migrationBuilder.DeleteData(
                table: "UserDogRelationships",
                keyColumn: "Id",
                keyValue: new Guid("dd5e5ac0-b782-4925-8314-50b9d3ddcae3"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("d517f437-12b6-4383-8977-87eba4d6ba8d"));

            migrationBuilder.DeleteData(
                table: "UserHobbiesRelationShips",
                keyColumn: "Id",
                keyValue: new Guid("6d14e72d-66f5-4b16-83f3-e850adbcb142"));

            migrationBuilder.DeleteData(
                table: "UserPreferences",
                keyColumn: "Id",
                keyValue: new Guid("21265a9c-7711-4623-a728-ba38abbabe99"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserDogRelationshipsId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserDogRelationships_UserDogRelationshipsId",
                table: "Users",
                column: "UserDogRelationshipsId",
                principalTable: "UserDogRelationships",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserProfiles_UserProfileId",
                table: "Users",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserDogRelationships_UserDogRelationshipsId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserProfiles_UserProfileId",
                table: "Users");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserDogRelationshipsId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "DogFilters",
                columns: new[] { "Id", "Adaptable", "AverageWalk", "Confident", "DogFiltersRelationshipsId", "EnergyLevel", "Independent", "LaidBack", "Timid", "WorksWithBoys", "WorksWithGirls" },
                values: new object[,]
                {
                    { new Guid("0f3a3690-9e28-46f7-af88-ce63a16986ec"), false, 0m, false, null, "Low2", false, false, false, false, false },
                    { new Guid("4d86f4ab-da1d-4e5d-958a-93d620ff12b5"), false, 0m, false, null, "Medium2", false, false, false, false, false },
                    { new Guid("6d37cc29-2c57-45df-894c-0e71b0224d12"), false, 0m, false, null, "Low", false, false, false, false, false },
                    { new Guid("74b11255-c5b3-41b3-991c-c227bcb65523"), false, 0m, false, null, "Medium", false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "DogFiltersRelationships",
                columns: new[] { "Id", "DogPersonality", "DogPreferences" },
                values: new object[,]
                {
                    { new Guid("ae4e1834-f846-4a21-b8aa-9cb8c3100c34"), new Guid("74b11255-c5b3-41b3-991c-c227bcb65523"), new Guid("4d86f4ab-da1d-4e5d-958a-93d620ff12b5") },
                    { new Guid("ea6e5e26-2272-436e-a2d6-13a47efbd70e"), new Guid("6d37cc29-2c57-45df-894c-0e71b0224d12"), new Guid("0f3a3690-9e28-46f7-af88-ce63a16986ec") }
                });

            migrationBuilder.InsertData(
                table: "DogPictures",
                columns: new[] { "Id", "DogPicturesId", "DogPicturesRelationshipsId", "Photo" },
                values: new object[,]
                {
                    { new Guid("14fd0136-6ddf-4168-8a06-0fe6b45c4ad0"), new Guid("8a0e4ab6-2905-446d-a1f6-25c34a49e7ad"), null, "Thors second profile Picture" },
                    { new Guid("76c324d6-224c-41ab-ad5f-acf07c727a6c"), new Guid("2700a7a4-c59a-43e9-b908-79f7648509a4"), null, "Eddies only profile Picture" },
                    { new Guid("95145914-ba83-4ebf-b5ba-8ccb041c7e69"), new Guid("8a0e4ab6-2905-446d-a1f6-25c34a49e7ad"), null, "Thors first profile Picture" }
                });

            migrationBuilder.InsertData(
                table: "DogPicturesRelationships",
                columns: new[] { "Id", "DogPicturesId" },
                values: new object[,]
                {
                    { new Guid("51515a17-24ae-49af-bf57-609d5ad69349"), new Guid("8a0e4ab6-2905-446d-a1f6-25c34a49e7ad") },
                    { new Guid("c9f255e4-3a7b-42de-9dfb-4e5822a8716a"), new Guid("2700a7a4-c59a-43e9-b908-79f7648509a4") }
                });

            migrationBuilder.InsertData(
                table: "UserDogRelationships",
                columns: new[] { "Id", "UsersDogId" },
                values: new object[] { new Guid("dd5e5ac0-b782-4925-8314-50b9d3ddcae3"), new Guid("659fa371-154e-470c-a927-6fdae716bebf") });

            migrationBuilder.InsertData(
                table: "UserDogs",
                columns: new[] { "Id", "DogId", "UserDogRelationshipsId", "UsersDogId" },
                values: new object[,]
                {
                    { new Guid("6ebf9138-3792-45d6-9520-24314d596ecd"), new Guid("c997349a-a56e-4027-8e8f-d509d1601ea5"), null, new Guid("659fa371-154e-470c-a927-6fdae716bebf") },
                    { new Guid("c9b8c472-b5bd-4466-a582-0ab6430254f2"), new Guid("f4a1567e-5600-44a7-b6b8-b8804c92f191"), null, new Guid("659fa371-154e-470c-a927-6fdae716bebf") }
                });

            migrationBuilder.InsertData(
                table: "UserHobbies",
                columns: new[] { "Id", "Gaming", "Gymming", "Hiking", "Movies", "Music", "Nature", "Swimming", "UserHobbiesRelationShipsId" },
                values: new object[,]
                {
                    { new Guid("0736a20b-a6f6-48de-a21b-415181c9751f"), false, true, false, false, false, false, false, null },
                    { new Guid("18ae64cb-2303-4b5d-aa9a-b88e95a0e6fa"), true, false, false, true, false, false, true, null }
                });

            migrationBuilder.InsertData(
                table: "UserHobbiesRelationShips",
                columns: new[] { "Id", "DislikesId", "LikesId" },
                values: new object[] { new Guid("6d14e72d-66f5-4b16-83f3-e850adbcb142"), new Guid("0736a20b-a6f6-48de-a21b-415181c9751f"), new Guid("18ae64cb-2303-4b5d-aa9a-b88e95a0e6fa") });

            migrationBuilder.InsertData(
                table: "UserPreferences",
                columns: new[] { "Id", "Gender", "LocationRange", "OldestAge", "YoungestAge" },
                values: new object[] { new Guid("21265a9c-7711-4623-a728-ba38abbabe99"), "All", 60, 40, 25 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Age", "Allergenic", "DogBreedId", "DogEnergyLevelId", "DogFiltersRelationshipsId", "DogPicturesRelationshipsId", "DogSizeId", "Name" },
                values: new object[,]
                {
                    { new Guid("c997349a-a56e-4027-8e8f-d509d1601ea5"), null, 1, false, 1, 2, new Guid("ae4e1834-f846-4a21-b8aa-9cb8c3100c34"), new Guid("c9f255e4-3a7b-42de-9dfb-4e5822a8716a"), 3, "Eddie" },
                    { new Guid("f4a1567e-5600-44a7-b6b8-b8804c92f191"), null, 11, false, 2, 1, new Guid("ea6e5e26-2272-436e-a2d6-13a47efbd70e"), new Guid("51515a17-24ae-49af-bf57-609d5ad69349"), 4, "Thor" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "About", "Gender", "Job", "Location", "Sexuality", "UserHobbiesRelationshipsId", "UserPreferencesId" },
                values: new object[] { new Guid("d517f437-12b6-4383-8977-87eba4d6ba8d"), "Test Content", "Male", "Student", "Bullaren", "Bisexual", new Guid("6d14e72d-66f5-4b16-83f3-e850adbcb142"), new Guid("21265a9c-7711-4623-a728-ba38abbabe99") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "LastName", "Password", "UserDogRelationshipsId", "UserProfileId" },
                values: new object[] { new Guid("30e5ce5c-21dd-4861-a5f7-91b4afdfd802"), 30, "Nixgabriel92@gmail.com", "Gabriel", "Nix", "Blank", new Guid("dd5e5ac0-b782-4925-8314-50b9d3ddcae3"), new Guid("d517f437-12b6-4383-8977-87eba4d6ba8d") });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserDogRelationships_UserDogRelationshipsId",
                table: "Users",
                column: "UserDogRelationshipsId",
                principalTable: "UserDogRelationships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserProfiles_UserProfileId",
                table: "Users",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
