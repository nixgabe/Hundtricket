﻿// <auto-generated />
using System;
using Hundtricket.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(HundtricketContext))]
    partial class HundtricketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Dog", b =>
                {
                    b.Property<Guid>("DogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("Allergenic")
                        .HasColumnType("bit");

                    b.Property<int>("DogBreedId")
                        .HasColumnType("int");

                    b.Property<int>("DogEnergyLevelId")
                        .HasColumnType("int");

                    b.Property<Guid>("DogFiltersRelationshipsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DogPicturesRelationshipsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DogSizeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DogId");

                    b.HasIndex("DogBreedId");

                    b.HasIndex("DogEnergyLevelId");

                    b.HasIndex("DogFiltersRelationshipsId");

                    b.HasIndex("DogPicturesRelationshipsId");

                    b.HasIndex("DogSizeId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = new Guid("2ddea553-f3d6-4a4b-89e7-f40fb15e8352"),
                            Age = 1,
                            Allergenic = false,
                            DogBreedId = 1,
                            DogEnergyLevelId = 2,
                            DogFiltersRelationshipsId = new Guid("d7f78adb-1339-4f98-8447-aa75b4e1bf81"),
                            DogPicturesRelationshipsId = new Guid("fdd4c483-e7dd-4b2e-8912-3ccebfc8e32d"),
                            DogSizeId = 3,
                            Name = "Eddie"
                        },
                        new
                        {
                            DogId = new Guid("d15605cb-e81f-4a26-88ba-1ee1d525f719"),
                            Age = 11,
                            Allergenic = false,
                            DogBreedId = 2,
                            DogEnergyLevelId = 1,
                            DogFiltersRelationshipsId = new Guid("796edc83-b48c-4645-8d4d-67da19b10c08"),
                            DogPicturesRelationshipsId = new Guid("eacf642f-ff75-4eec-a437-3424765cf160"),
                            DogSizeId = 4,
                            Name = "Thor"
                        });
                });

            modelBuilder.Entity("Entities.DogBreed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DogBreeds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Breed = "Mixed"
                        },
                        new
                        {
                            Id = 2,
                            Breed = "Samoyed"
                        });
                });

            modelBuilder.Entity("Entities.DogEnergyLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EnergyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DogEnergyLevel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnergyLevel = "Low"
                        },
                        new
                        {
                            Id = 2,
                            EnergyLevel = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            EnergyLevel = "High"
                        });
                });

            modelBuilder.Entity("Entities.DogFilters", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Adaptable")
                        .HasColumnType("bit");

                    b.Property<decimal>("AverageWalk")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Confident")
                        .HasColumnType("bit");

                    b.Property<Guid?>("DogFiltersRelationshipsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EnergyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Independent")
                        .HasColumnType("bit");

                    b.Property<bool>("LaidBack")
                        .HasColumnType("bit");

                    b.Property<bool>("Timid")
                        .HasColumnType("bit");

                    b.Property<bool>("WorksWithBoys")
                        .HasColumnType("bit");

                    b.Property<bool>("WorksWithGirls")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DogFiltersRelationshipsId");

                    b.ToTable("DogFilters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1bd4aa58-743b-4bd9-93fc-2f32c1a58b04"),
                            Adaptable = false,
                            AverageWalk = 0m,
                            Confident = false,
                            EnergyLevel = "Medium",
                            Independent = false,
                            LaidBack = false,
                            Timid = false,
                            WorksWithBoys = false,
                            WorksWithGirls = false
                        },
                        new
                        {
                            Id = new Guid("a45bba47-f35a-4882-8bf8-5116577a3d25"),
                            Adaptable = false,
                            AverageWalk = 0m,
                            Confident = false,
                            EnergyLevel = "Medium2",
                            Independent = false,
                            LaidBack = false,
                            Timid = false,
                            WorksWithBoys = false,
                            WorksWithGirls = false
                        },
                        new
                        {
                            Id = new Guid("6e5e06cf-a0f8-4419-acc5-bfed17cec6d4"),
                            Adaptable = false,
                            AverageWalk = 0m,
                            Confident = false,
                            EnergyLevel = "Low",
                            Independent = false,
                            LaidBack = false,
                            Timid = false,
                            WorksWithBoys = false,
                            WorksWithGirls = false
                        },
                        new
                        {
                            Id = new Guid("b40b2931-1df4-43f1-a7d2-6edfacab66c3"),
                            Adaptable = false,
                            AverageWalk = 0m,
                            Confident = false,
                            EnergyLevel = "Low2",
                            Independent = false,
                            LaidBack = false,
                            Timid = false,
                            WorksWithBoys = false,
                            WorksWithGirls = false
                        });
                });

            modelBuilder.Entity("Entities.DogFiltersRelationships", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DogPersonality")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DogPreferences")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("DogFiltersRelationships");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d7f78adb-1339-4f98-8447-aa75b4e1bf81"),
                            DogPersonality = new Guid("1bd4aa58-743b-4bd9-93fc-2f32c1a58b04"),
                            DogPreferences = new Guid("a45bba47-f35a-4882-8bf8-5116577a3d25")
                        },
                        new
                        {
                            Id = new Guid("796edc83-b48c-4645-8d4d-67da19b10c08"),
                            DogPersonality = new Guid("6e5e06cf-a0f8-4419-acc5-bfed17cec6d4"),
                            DogPreferences = new Guid("b40b2931-1df4-43f1-a7d2-6edfacab66c3")
                        });
                });

            modelBuilder.Entity("Entities.DogPictures", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DogPicturesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DogPicturesRelationshipsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DogPicturesRelationshipsId");

                    b.ToTable("DogPictures");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a7d2fe65-f2d3-4ea5-8a24-ba606fe99b7e"),
                            DogPicturesId = new Guid("9e3e90e0-5a5a-48e9-8386-960c6ca95b9d"),
                            Photo = "Eddies only profile Picture"
                        },
                        new
                        {
                            Id = new Guid("993c93ba-8db5-4048-b87a-a4b88d0418b7"),
                            DogPicturesId = new Guid("70f1fb91-5889-46d8-b0f0-e63645fb753b"),
                            Photo = "Thors first profile Picture"
                        },
                        new
                        {
                            Id = new Guid("5a6fe1f0-4f81-4ac4-9fd1-eefaf293095c"),
                            DogPicturesId = new Guid("70f1fb91-5889-46d8-b0f0-e63645fb753b"),
                            Photo = "Thors second profile Picture"
                        });
                });

            modelBuilder.Entity("Entities.DogPicturesRelationships", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DogPicturesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("DogPicturesRelationships");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fdd4c483-e7dd-4b2e-8912-3ccebfc8e32d"),
                            DogPicturesId = new Guid("9e3e90e0-5a5a-48e9-8386-960c6ca95b9d")
                        },
                        new
                        {
                            Id = new Guid("eacf642f-ff75-4eec-a437-3424765cf160"),
                            DogPicturesId = new Guid("70f1fb91-5889-46d8-b0f0-e63645fb753b")
                        });
                });

            modelBuilder.Entity("Entities.DogSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DogSize");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Size = "Mini"
                        },
                        new
                        {
                            Id = 2,
                            Size = "Small"
                        },
                        new
                        {
                            Id = 3,
                            Size = "Medium"
                        },
                        new
                        {
                            Id = 4,
                            Size = "Large"
                        },
                        new
                        {
                            Id = 5,
                            Size = "Giant"
                        });
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSignedOn")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserDogRelationshipsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserDogRelationshipsId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8293e866-0b02-4527-b121-330ff28f2cca"),
                            Age = 30,
                            Email = "Nixgabriel92@gmail.com",
                            FirstName = "Gabriel",
                            IsSignedOn = false,
                            LastName = "Nix",
                            Password = "Blank",
                            UserDogRelationshipsId = new Guid("838b776d-85de-456f-ae13-d7e3e6d544e4"),
                            UserProfileId = new Guid("934a5e3f-20fa-4efb-988b-cd7cfc4bb95c")
                        });
                });

            modelBuilder.Entity("Entities.UserDogRelationships", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersDogId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserDogRelationships");

                    b.HasData(
                        new
                        {
                            Id = new Guid("838b776d-85de-456f-ae13-d7e3e6d544e4"),
                            UsersDogId = new Guid("1ea1ee74-cc56-478a-a8dc-c46cf7d722f7")
                        });
                });

            modelBuilder.Entity("Entities.UserDogs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserDogRelationshipsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersDogId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserDogRelationshipsId");

                    b.ToTable("UserDogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0b19492f-27cf-433c-8abd-9add7dbf1ef8"),
                            DogId = new Guid("2ddea553-f3d6-4a4b-89e7-f40fb15e8352"),
                            UsersDogId = new Guid("1ea1ee74-cc56-478a-a8dc-c46cf7d722f7")
                        },
                        new
                        {
                            Id = new Guid("93022f06-02eb-4008-bb22-17010ac0e1aa"),
                            DogId = new Guid("d15605cb-e81f-4a26-88ba-1ee1d525f719"),
                            UsersDogId = new Guid("1ea1ee74-cc56-478a-a8dc-c46cf7d722f7")
                        });
                });

            modelBuilder.Entity("Entities.UserHobbies", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Gaming")
                        .HasColumnType("bit");

                    b.Property<bool>("Gymming")
                        .HasColumnType("bit");

                    b.Property<bool>("Hiking")
                        .HasColumnType("bit");

                    b.Property<bool>("Movies")
                        .HasColumnType("bit");

                    b.Property<bool>("Music")
                        .HasColumnType("bit");

                    b.Property<bool>("Nature")
                        .HasColumnType("bit");

                    b.Property<bool>("Swimming")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("UserHobbies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("04123a5b-5b7a-49f4-b8c3-76029bfdf687"),
                            Gaming = true,
                            Gymming = false,
                            Hiking = false,
                            Movies = true,
                            Music = false,
                            Nature = false,
                            Swimming = true
                        });
                });

            modelBuilder.Entity("Entities.UserPreferences", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationRange")
                        .HasColumnType("int");

                    b.Property<int?>("OldestAge")
                        .HasColumnType("int");

                    b.Property<int?>("YoungestAge")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserPreferences");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1c940708-a8b0-47c7-b8e1-ad6ee60b0ceb"),
                            Gender = "All",
                            LocationRange = 60,
                            OldestAge = 40,
                            YoungestAge = 25
                        });
                });

            modelBuilder.Entity("Entities.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexuality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserHobbiesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserPreferencesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserHobbiesId");

                    b.HasIndex("UserPreferencesId");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("934a5e3f-20fa-4efb-988b-cd7cfc4bb95c"),
                            About = "Test Content",
                            Gender = "Male",
                            Job = "Student",
                            Location = "Bullaren",
                            Sexuality = "Bisexual",
                            UserHobbiesId = new Guid("04123a5b-5b7a-49f4-b8c3-76029bfdf687"),
                            UserPreferencesId = new Guid("1c940708-a8b0-47c7-b8e1-ad6ee60b0ceb")
                        });
                });

            modelBuilder.Entity("Entities.Dog", b =>
                {
                    b.HasOne("Entities.DogBreed", "DogBreed")
                        .WithMany()
                        .HasForeignKey("DogBreedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.DogEnergyLevel", "DogEnergyLevel")
                        .WithMany()
                        .HasForeignKey("DogEnergyLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.DogFiltersRelationships", "DogFiltersRelationships")
                        .WithMany()
                        .HasForeignKey("DogFiltersRelationshipsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.DogPicturesRelationships", "DogPicturesRelationships")
                        .WithMany()
                        .HasForeignKey("DogPicturesRelationshipsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.DogSize", "DogSize")
                        .WithMany()
                        .HasForeignKey("DogSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DogBreed");

                    b.Navigation("DogEnergyLevel");

                    b.Navigation("DogFiltersRelationships");

                    b.Navigation("DogPicturesRelationships");

                    b.Navigation("DogSize");
                });

            modelBuilder.Entity("Entities.DogFilters", b =>
                {
                    b.HasOne("Entities.DogFiltersRelationships", null)
                        .WithMany("DogFilters")
                        .HasForeignKey("DogFiltersRelationshipsId");
                });

            modelBuilder.Entity("Entities.DogPictures", b =>
                {
                    b.HasOne("Entities.DogPicturesRelationships", null)
                        .WithMany("DogPictures")
                        .HasForeignKey("DogPicturesRelationshipsId");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.HasOne("Entities.UserDogRelationships", "UserDogRelationships")
                        .WithMany()
                        .HasForeignKey("UserDogRelationshipsId");

                    b.HasOne("Entities.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId");

                    b.Navigation("UserDogRelationships");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Entities.UserDogs", b =>
                {
                    b.HasOne("Entities.UserDogRelationships", null)
                        .WithMany("UserDogs")
                        .HasForeignKey("UserDogRelationshipsId");
                });

            modelBuilder.Entity("Entities.UserProfile", b =>
                {
                    b.HasOne("Entities.UserHobbies", "UserHobbies")
                        .WithMany()
                        .HasForeignKey("UserHobbiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.UserPreferences", "UserPreferences")
                        .WithMany()
                        .HasForeignKey("UserPreferencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserHobbies");

                    b.Navigation("UserPreferences");
                });

            modelBuilder.Entity("Entities.DogFiltersRelationships", b =>
                {
                    b.Navigation("DogFilters");
                });

            modelBuilder.Entity("Entities.DogPicturesRelationships", b =>
                {
                    b.Navigation("DogPictures");
                });

            modelBuilder.Entity("Entities.UserDogRelationships", b =>
                {
                    b.Navigation("UserDogs");
                });
#pragma warning restore 612, 618
        }
    }
}
