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

                    b.Property<Guid>("DogPersonalityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DogPicturesRelationshipsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DogPreferencesId")
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

                    b.HasIndex("DogPersonalityId");

                    b.HasIndex("DogPicturesRelationshipsId");

                    b.HasIndex("DogPreferencesId");

                    b.HasIndex("DogSizeId");

                    b.HasIndex("GenderId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = new Guid("77e177d9-b3bc-447c-9b96-1c4cfa41025e"),
                            Age = 1,
                            Allergenic = false,
                            DogBreedId = 1,
                            DogEnergyLevelId = 2,
                            DogPersonalityId = new Guid("f4ad8511-795e-4dc5-96c8-e59645f719a1"),
                            DogPicturesRelationshipsId = new Guid("063b6857-3abf-4939-af6e-fa77b3d74fc0"),
                            DogPreferencesId = new Guid("b04fd782-6199-45c9-a9e9-cd0f2081a298"),
                            DogSizeId = 3,
                            GenderId = 1,
                            Name = "Eddie"
                        },
                        new
                        {
                            DogId = new Guid("babf3e11-ec06-4b56-8a9c-f7bf3fdbf138"),
                            Age = 11,
                            Allergenic = false,
                            DogBreedId = 2,
                            DogEnergyLevelId = 1,
                            DogPersonalityId = new Guid("4eee9ef1-c531-4472-a112-8ee1dd0bd866"),
                            DogPicturesRelationshipsId = new Guid("fbf3499b-c9ad-44b2-aee5-edc957741025"),
                            DogPreferencesId = new Guid("bcbd8c76-c019-4673-88ef-33c1a06c2491"),
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

            modelBuilder.Entity("Entities.DogPersonality", b =>
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

                    b.ToTable("DogPersonality");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f4ad8511-795e-4dc5-96c8-e59645f719a1"),
                            Adaptable = false,
                            AverageWalk = 4m,
                            Confident = true,
                            Independent = false,
                            LaidBack = true,
                            Timid = false,
                            WorksWithBoys = true,
                            WorksWithGirls = true
                        },
                        new
                        {
                            Id = new Guid("4eee9ef1-c531-4472-a112-8ee1dd0bd866"),
                            Adaptable = true,
                            AverageWalk = 2m,
                            Confident = true,
                            Independent = true,
                            LaidBack = true,
                            Timid = false,
                            WorksWithBoys = true,
                            WorksWithGirls = true
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
                            Id = new Guid("a41670f8-45a8-4775-ac2a-0cf3395a1bd3"),
                            DogPicturesId = new Guid("440b93c3-4dcf-4417-adf9-4fc066c5dcc7"),
                            Photo = "Eddies only profile Picture"
                        },
                        new
                        {
                            Id = new Guid("20af2d3f-50b4-4bd3-8d01-4df68d48ed3f"),
                            DogPicturesId = new Guid("e62e7e89-d2a4-47d6-b07f-82735ec14181"),
                            Photo = "Thors first profile Picture"
                        },
                        new
                        {
                            Id = new Guid("61d1c576-cdf2-425e-be21-5e41638b6b6a"),
                            DogPicturesId = new Guid("e62e7e89-d2a4-47d6-b07f-82735ec14181"),
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
                            Id = new Guid("063b6857-3abf-4939-af6e-fa77b3d74fc0"),
                            DogPicturesId = new Guid("440b93c3-4dcf-4417-adf9-4fc066c5dcc7")
                        },
                        new
                        {
                            Id = new Guid("fbf3499b-c9ad-44b2-aee5-edc957741025"),
                            DogPicturesId = new Guid("e62e7e89-d2a4-47d6-b07f-82735ec14181")
                        });
                });

            modelBuilder.Entity("Entities.DogPreferences", b =>
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

                    b.ToTable("DogPreferences");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b04fd782-6199-45c9-a9e9-cd0f2081a298"),
                            Adaptable = true,
                            AverageWalk = 4m,
                            Confident = true,
                            Independent = true,
                            LaidBack = true,
                            Timid = false,
                            WorksWithBoys = true,
                            WorksWithGirls = true
                        },
                        new
                        {
                            Id = new Guid("bcbd8c76-c019-4673-88ef-33c1a06c2491"),
                            Adaptable = true,
                            AverageWalk = 2m,
                            Confident = true,
                            Independent = true,
                            LaidBack = true,
                            Timid = true,
                            WorksWithBoys = true,
                            WorksWithGirls = true
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

            modelBuilder.Entity("Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("ConversationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FromUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("ToUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Entities.ReportedConversation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConversationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ReportedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Reporter")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ReportedConversation");
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
                            Id = new Guid("6bae828f-a5ff-40aa-ba7f-a6bff874edfd"),
                            Age = 30,
                            Email = "Nixgabriel92@gmail.com",
                            FirstName = "Gabriel",
                            IsSignedOn = false,
                            LastName = "Nix",
                            Password = "Blank",
                            UserDogRelationshipsId = new Guid("eb50c3ad-c5b8-412e-92a3-ba61adcb44b9"),
                            UserProfileId = new Guid("f9b76317-63eb-4e5d-8924-50414fd95a63")
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
                            Id = new Guid("eb50c3ad-c5b8-412e-92a3-ba61adcb44b9"),
                            UsersDogId = new Guid("54bcf77a-3c90-4c2f-8f07-eefda4e7e7a2")
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
                            Id = new Guid("54bcf77a-3c90-4c2f-8f07-eefda4e7e7a2"),
                            DogId = new Guid("77e177d9-b3bc-447c-9b96-1c4cfa41025e"),
                            UsersDogId = new Guid("72cb553a-2117-4589-a58d-9eefb9e85dc0")
                        },
                        new
                        {
                            Id = new Guid("7375641f-22a9-4ffd-b88d-15a6a548a6ff"),
                            DogId = new Guid("babf3e11-ec06-4b56-8a9c-f7bf3fdbf138"),
                            UsersDogId = new Guid("72cb553a-2117-4589-a58d-9eefb9e85dc0")
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
                            Id = new Guid("05f10c46-197b-4ba0-86d1-89e74e6a4905"),
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
                            Id = new Guid("bf0d4139-a5ec-4b18-90ee-42f97e776962"),
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
                            Id = new Guid("f9b76317-63eb-4e5d-8924-50414fd95a63"),
                            About = "Test Content",
                            GenderId = 1,
                            Job = "Student",
                            Location = "Bullaren",
                            Sexuality = "Bisexual",
                            UserHobbiesId = new Guid("05f10c46-197b-4ba0-86d1-89e74e6a4905"),
                            UserPreferencesId = new Guid("bf0d4139-a5ec-4b18-90ee-42f97e776962")
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

                    b.HasOne("Entities.DogPersonality", "DogPersonality")
                        .WithMany()
                        .HasForeignKey("DogPersonalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.DogPicturesRelationships", "DogPicturesRelationships")
                        .WithMany()
                        .HasForeignKey("DogPicturesRelationshipsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.DogPreferences", "DogPreferences")
                        .WithMany()
                        .HasForeignKey("DogPreferencesId")
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

                    b.Navigation("DogPersonality");

                    b.Navigation("DogPicturesRelationships");

                    b.Navigation("DogPreferences");

                    b.Navigation("DogSize");

                    b.Navigation("Gender");
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
