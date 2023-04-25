﻿// <auto-generated />
using System;
using Hundtricket.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(HundtricketContext))]
    [Migration("20230425084121_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("GenderId")
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

                    b.HasIndex("GenderId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = new Guid("8d6bb601-7c2f-4bc8-b0e3-704758facb53"),
                            Age = 1,
                            Allergenic = false,
                            DogBreedId = 1,
                            DogEnergyLevelId = 2,
                            DogFiltersRelationshipsId = new Guid("ac9c3e0b-23ad-4aa8-b3a7-f470395d5e50"),
                            DogPicturesRelationshipsId = new Guid("fb195804-0a4c-4c5e-a278-cde2dfd72dbd"),
                            DogSizeId = 3,
                            GenderId = 1,
                            Name = "Eddie"
                        },
                        new
                        {
                            DogId = new Guid("297b7ebd-17b2-45bd-98a4-1b0dff1af087"),
                            Age = 11,
                            Allergenic = false,
                            DogBreedId = 2,
                            DogEnergyLevelId = 1,
                            DogFiltersRelationshipsId = new Guid("24a9f4e6-85ad-4e75-85c7-4eeb407315b4"),
                            DogPicturesRelationshipsId = new Guid("9746b7e7-74cc-4d73-a8ae-2566e65411ff"),
                            DogSizeId = 4,
                            GenderId = 1,
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
                        },
                        new
                        {
                            Id = 3,
                            Breed = "Golden Retriever"
                        },
                        new
                        {
                            Id = 4,
                            Breed = "German Shepherd"
                        },
                        new
                        {
                            Id = 5,
                            Breed = "Borzoi"
                        },
                        new
                        {
                            Id = 6,
                            Breed = "Yorkshire Terrier"
                        },
                        new
                        {
                            Id = 7,
                            Breed = "Beagle"
                        },
                        new
                        {
                            Id = 8,
                            Breed = "Great Dane"
                        },
                        new
                        {
                            Id = 9,
                            Breed = "Siberian Husky"
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

                    b.ToTable("DogEnergyLevels");

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
                            Id = new Guid("26e2922f-83cb-4f52-9ed8-9ab17c7e729f"),
                            Adaptable = false,
                            AverageWalk = 0m,
                            Confident = false,
                            Independent = false,
                            LaidBack = false,
                            Timid = false,
                            WorksWithBoys = false,
                            WorksWithGirls = false
                        },
                        new
                        {
                            Id = new Guid("9aef8b61-36e6-4320-a353-919d6607edb2"),
                            Adaptable = false,
                            AverageWalk = 0m,
                            Confident = false,
                            Independent = false,
                            LaidBack = false,
                            Timid = false,
                            WorksWithBoys = false,
                            WorksWithGirls = false
                        },
                        new
                        {
                            Id = new Guid("bfd03a4b-aaf9-4d07-a172-57a90bb4efdd"),
                            Adaptable = false,
                            AverageWalk = 0m,
                            Confident = false,
                            Independent = false,
                            LaidBack = false,
                            Timid = false,
                            WorksWithBoys = false,
                            WorksWithGirls = false
                        },
                        new
                        {
                            Id = new Guid("af55df1e-144e-4ad9-99e1-e7963a79308f"),
                            Adaptable = false,
                            AverageWalk = 0m,
                            Confident = false,
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
                            Id = new Guid("ac9c3e0b-23ad-4aa8-b3a7-f470395d5e50"),
                            DogPersonality = new Guid("26e2922f-83cb-4f52-9ed8-9ab17c7e729f"),
                            DogPreferences = new Guid("9aef8b61-36e6-4320-a353-919d6607edb2")
                        },
                        new
                        {
                            Id = new Guid("24a9f4e6-85ad-4e75-85c7-4eeb407315b4"),
                            DogPersonality = new Guid("bfd03a4b-aaf9-4d07-a172-57a90bb4efdd"),
                            DogPreferences = new Guid("af55df1e-144e-4ad9-99e1-e7963a79308f")
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
                            Id = new Guid("968d787a-5721-4a90-8e87-146f19a27503"),
                            DogPicturesId = new Guid("cebb355a-922c-4287-844a-4bec229c681d"),
                            Photo = "Eddies only profile Picture"
                        },
                        new
                        {
                            Id = new Guid("c9b55875-c1ae-420b-a5fc-b9966ff377ed"),
                            DogPicturesId = new Guid("e7c0a7ab-5211-4d9b-8405-d10eb4e4fff7"),
                            Photo = "Thors first profile Picture"
                        },
                        new
                        {
                            Id = new Guid("9ee1fe8d-652d-427a-a1dd-67fa6dca7f5e"),
                            DogPicturesId = new Guid("e7c0a7ab-5211-4d9b-8405-d10eb4e4fff7"),
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
                            Id = new Guid("fb195804-0a4c-4c5e-a278-cde2dfd72dbd"),
                            DogPicturesId = new Guid("cebb355a-922c-4287-844a-4bec229c681d")
                        },
                        new
                        {
                            Id = new Guid("9746b7e7-74cc-4d73-a8ae-2566e65411ff"),
                            DogPicturesId = new Guid("e7c0a7ab-5211-4d9b-8405-d10eb4e4fff7")
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

                    b.ToTable("DogSizes");

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

            modelBuilder.Entity("Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GenderOption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenderOption = "Male"
                        },
                        new
                        {
                            Id = 2,
                            GenderOption = "Female"
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
                            Id = new Guid("84c98b27-fd27-4530-8ac4-a5de2ed88c45"),
                            Age = 30,
                            Email = "Nixgabriel92@gmail.com",
                            FirstName = "Gabriel",
                            IsSignedOn = false,
                            LastName = "Nix",
                            Password = "Blank",
                            UserDogRelationshipsId = new Guid("0aad4509-0236-4eca-9334-455cb02db57c"),
                            UserProfileId = new Guid("fbdfbaae-8d26-4eb8-9cfd-ce7322cf2311")
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
                            Id = new Guid("0aad4509-0236-4eca-9334-455cb02db57c"),
                            UsersDogId = new Guid("ba1b76e0-75c7-464e-a4d5-481360ea00b5")
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
                            Id = new Guid("bce4d1be-1e2a-4e9f-b143-f5ecbbc7d320"),
                            DogId = new Guid("8d6bb601-7c2f-4bc8-b0e3-704758facb53"),
                            UsersDogId = new Guid("ba1b76e0-75c7-464e-a4d5-481360ea00b5")
                        },
                        new
                        {
                            Id = new Guid("1dc3fbc0-0ec0-4f1e-b183-73c43cd9f0fd"),
                            DogId = new Guid("297b7ebd-17b2-45bd-98a4-1b0dff1af087"),
                            UsersDogId = new Guid("ba1b76e0-75c7-464e-a4d5-481360ea00b5")
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
                            Id = new Guid("f67b9a94-2a14-42b7-aedf-5fc414f4eeac"),
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
                            Id = new Guid("fe363297-0904-41b8-8ef7-e4e01208b0a0"),
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

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

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

                    b.HasIndex("GenderId");

                    b.HasIndex("UserHobbiesId");

                    b.HasIndex("UserPreferencesId");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fbdfbaae-8d26-4eb8-9cfd-ce7322cf2311"),
                            About = "Test Content",
                            GenderId = 1,
                            Job = "Student",
                            Location = "Bullaren",
                            Sexuality = "Bisexual",
                            UserHobbiesId = new Guid("f67b9a94-2a14-42b7-aedf-5fc414f4eeac"),
                            UserPreferencesId = new Guid("fe363297-0904-41b8-8ef7-e4e01208b0a0")
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

                    b.HasOne("Entities.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DogBreed");

                    b.Navigation("DogEnergyLevel");

                    b.Navigation("DogFiltersRelationships");

                    b.Navigation("DogPicturesRelationships");

                    b.Navigation("DogSize");

                    b.Navigation("Gender");
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
                    b.HasOne("Entities.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId");

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

                    b.Navigation("Gender");

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