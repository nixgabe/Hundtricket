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
                            DogId = new Guid("68f9fd64-8e35-4756-9b19-7ea6f7eef4a4"),
                            Age = 1,
                            Allergenic = false,
                            DogBreedId = 1,
                            DogEnergyLevelId = 2,
                            DogFiltersRelationshipsId = new Guid("cfc573ca-9d1d-49a0-b1d8-5bcaae0b3e73"),
                            DogPicturesRelationshipsId = new Guid("d405858d-a2cd-4adc-afb0-4bdbf199b953"),
                            DogSizeId = 3,
                            Name = "Eddie"
                        },
                        new
                        {
                            DogId = new Guid("1830331f-1d41-4cc9-b321-9b40369a14a0"),
                            Age = 11,
                            Allergenic = false,
                            DogBreedId = 2,
                            DogEnergyLevelId = 1,
                            DogFiltersRelationshipsId = new Guid("41c1ae82-9f5d-4125-b134-4768a4b6379a"),
                            DogPicturesRelationshipsId = new Guid("ee67df58-ad08-4fef-a6f8-d7e1357b1a3f"),
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
                            Id = new Guid("654f517b-d5cc-4620-b2cf-7614734c08be"),
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
                            Id = new Guid("9c249f11-4ee1-4d5f-bc3f-ab4611dce55b"),
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
                            Id = new Guid("2bc1e9ca-29a6-4332-bb03-156a0d810818"),
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
                            Id = new Guid("be583850-3c88-479f-9f3a-1fd1cab29a45"),
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
                            Id = new Guid("cfc573ca-9d1d-49a0-b1d8-5bcaae0b3e73"),
                            DogPersonality = new Guid("654f517b-d5cc-4620-b2cf-7614734c08be"),
                            DogPreferences = new Guid("9c249f11-4ee1-4d5f-bc3f-ab4611dce55b")
                        },
                        new
                        {
                            Id = new Guid("41c1ae82-9f5d-4125-b134-4768a4b6379a"),
                            DogPersonality = new Guid("2bc1e9ca-29a6-4332-bb03-156a0d810818"),
                            DogPreferences = new Guid("be583850-3c88-479f-9f3a-1fd1cab29a45")
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
                            Id = new Guid("fec5d52f-b724-47c5-8479-ab60fb4de8b0"),
                            DogPicturesId = new Guid("6f354ed5-b90c-40ac-b755-19809199e5cb"),
                            Photo = "Eddies only profile Picture"
                        },
                        new
                        {
                            Id = new Guid("ed0b4256-9ef8-4889-b311-d16379f6e3fb"),
                            DogPicturesId = new Guid("eeae08b1-f64c-43f6-a944-afd481a5d208"),
                            Photo = "Thors first profile Picture"
                        },
                        new
                        {
                            Id = new Guid("9db96541-ca78-43ff-bb3f-8b805c8e61b1"),
                            DogPicturesId = new Guid("eeae08b1-f64c-43f6-a944-afd481a5d208"),
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
                            Id = new Guid("d405858d-a2cd-4adc-afb0-4bdbf199b953"),
                            DogPicturesId = new Guid("6f354ed5-b90c-40ac-b755-19809199e5cb")
                        },
                        new
                        {
                            Id = new Guid("ee67df58-ad08-4fef-a6f8-d7e1357b1a3f"),
                            DogPicturesId = new Guid("eeae08b1-f64c-43f6-a944-afd481a5d208")
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
                            Id = new Guid("042e0a2d-66eb-4e7d-965b-34c5d7e18639"),
                            Age = 30,
                            Email = "Nixgabriel92@gmail.com",
                            FirstName = "Gabriel",
                            IsSignedOn = false,
                            LastName = "Nix",
                            Password = "Blank",
                            UserDogRelationshipsId = new Guid("a89d4696-bb8b-47cb-b531-6fd4b14610a5"),
                            UserProfileId = new Guid("e8f019b9-31f3-4d1f-b1f2-0d5415829ce8")
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
                            Id = new Guid("a89d4696-bb8b-47cb-b531-6fd4b14610a5"),
                            UsersDogId = new Guid("5af92ab9-2d21-4ee8-b1fd-e71acb9cbb61")
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
                            Id = new Guid("752342a0-5e17-4740-9a43-50f59748a89d"),
                            DogId = new Guid("68f9fd64-8e35-4756-9b19-7ea6f7eef4a4"),
                            UsersDogId = new Guid("5af92ab9-2d21-4ee8-b1fd-e71acb9cbb61")
                        },
                        new
                        {
                            Id = new Guid("f86c2f00-b6d4-4c64-8a33-f91b41ce0eb2"),
                            DogId = new Guid("1830331f-1d41-4cc9-b321-9b40369a14a0"),
                            UsersDogId = new Guid("5af92ab9-2d21-4ee8-b1fd-e71acb9cbb61")
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

                    b.Property<Guid?>("UserHobbiesRelationShipsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserHobbiesRelationShipsId");

                    b.ToTable("UserHobbies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f77e7105-fa44-420d-91a3-941e2236b945"),
                            Gaming = true,
                            Gymming = false,
                            Hiking = false,
                            Movies = true,
                            Music = false,
                            Nature = false,
                            Swimming = true
                        },
                        new
                        {
                            Id = new Guid("8e39158a-44b0-4e3e-bda2-08dda146fc8c"),
                            Gaming = false,
                            Gymming = true,
                            Hiking = false,
                            Movies = false,
                            Music = false,
                            Nature = false,
                            Swimming = false
                        });
                });

            modelBuilder.Entity("Entities.UserHobbiesRelationShips", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DislikesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LikesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserHobbiesRelationShips");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f5e28e93-2e8a-401c-9fea-69bf4d573695"),
                            DislikesId = new Guid("8e39158a-44b0-4e3e-bda2-08dda146fc8c"),
                            LikesId = new Guid("f77e7105-fa44-420d-91a3-941e2236b945")
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
                            Id = new Guid("6ea11c65-c1a6-423b-8c98-bd2dcc9328b2"),
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

                    b.Property<Guid>("UserHobbiesRelationshipsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserPreferencesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserHobbiesRelationshipsId");

                    b.HasIndex("UserPreferencesId");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e8f019b9-31f3-4d1f-b1f2-0d5415829ce8"),
                            About = "Test Content",
                            Gender = "Male",
                            Job = "Student",
                            Location = "Bullaren",
                            Sexuality = "Bisexual",
                            UserHobbiesRelationshipsId = new Guid("f5e28e93-2e8a-401c-9fea-69bf4d573695"),
                            UserPreferencesId = new Guid("6ea11c65-c1a6-423b-8c98-bd2dcc9328b2")
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

            modelBuilder.Entity("Entities.UserHobbies", b =>
                {
                    b.HasOne("Entities.UserHobbiesRelationShips", null)
                        .WithMany("UserHobbies")
                        .HasForeignKey("UserHobbiesRelationShipsId");
                });

            modelBuilder.Entity("Entities.UserProfile", b =>
                {
                    b.HasOne("Entities.UserHobbiesRelationShips", "UserHobbiesRelationShips")
                        .WithMany()
                        .HasForeignKey("UserHobbiesRelationshipsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.UserPreferences", "UserPreferences")
                        .WithMany()
                        .HasForeignKey("UserPreferencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserHobbiesRelationShips");

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

            modelBuilder.Entity("Entities.UserHobbiesRelationShips", b =>
                {
                    b.Navigation("UserHobbies");
                });
#pragma warning restore 612, 618
        }
    }
}
