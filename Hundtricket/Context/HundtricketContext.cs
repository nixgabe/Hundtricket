using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Hundtricket.Context
{
    public class HundtricketContext : DbContext
    {
        public HundtricketContext(DbContextOptions<HundtricketContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=tcp:hundtricket.database.windows.net,1433;Initial Catalog=Hundtricket;User Id=azureuser@hundtricket;Password=Thorloke1");
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextFactory<HundtricketContext>(
                options => options.UseSqlServer(@"Data Source=tcp:hundtricket.database.windows.net,1433;Initial Catalog=Hundtricket;User Id=azureuser@hundtricket;Password=Thorloke1"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Guid GabesDogRelationShips = Guid.NewGuid();
            Guid GabesPupsRelId = Guid.NewGuid();

            Guid EddieId = Guid.NewGuid();
            int EddieBreed = 1;
            Guid EddiesPicsId = Guid.NewGuid();
            Guid EddiesPictures = Guid.NewGuid();
            Guid EddiesPersonality = Guid.NewGuid();
            Guid EddiesPreferences = Guid.NewGuid();
            
            Guid ThorId = Guid.NewGuid();
            int ThorBreed = 2;
            Guid ThorsPicsId = Guid.NewGuid();
            Guid ThorsPictures = Guid.NewGuid();
            Guid ThorsPersonality = Guid.NewGuid();
            Guid ThorsPreferences = Guid.NewGuid();

            modelBuilder.Entity<Dog>()
                .HasData(
                new Dog { DogId = EddieId, Name = "Eddie", Age = 1, GenderId = 1,  DogBreedId = EddieBreed, DogPicturesRelationshipsId = EddiesPicsId, 
                    DogPersonalityId = EddiesPersonality, DogPreferencesId = EddiesPreferences, DogSizeId = 3, DogEnergyLevelId = 2
                },
                new Dog { DogId = ThorId, Name = "Thor", Age = 11, GenderId = 1, DogBreedId = ThorBreed, DogPicturesRelationshipsId = ThorsPicsId,
                    DogPersonalityId = ThorsPersonality, DogPreferencesId = ThorsPreferences, DogSizeId = 4, DogEnergyLevelId = 1
                });

            modelBuilder.Entity<DogBreed>().HasData(
                new DogBreed { Id = EddieBreed, Breed = "Mixed" },
                new DogBreed { Id = ThorBreed, Breed = "Samoyed" },
                new DogBreed { Id = 3, Breed = "Golden Retriever" },
                new DogBreed { Id = 4, Breed = "German Shepherd" },
                new DogBreed { Id = 5, Breed = "Borzoi" },
                new DogBreed { Id = 6, Breed = "Yorkshire Terrier" },
                new DogBreed { Id = 7, Breed = "Beagle" },
                new DogBreed { Id = 8, Breed = "Great Dane" },
                new DogBreed { Id = 9, Breed = "Siberian Husky" }
                );

            modelBuilder.Entity<DogSize>().HasData(
                new DogSize { Id = 1, Size = "Mini" },
                new DogSize { Id = 2, Size = "Small" },
                new DogSize { Id = 3, Size = "Medium" },
                new DogSize { Id = 4, Size = "Large" },
                new DogSize { Id = 5, Size = "Giant" }
                );

            modelBuilder.Entity<DogEnergyLevel>().HasData(
                new DogEnergyLevel { Id = 1, EnergyLevel = "Low" },
                new DogEnergyLevel { Id = 2, EnergyLevel = "Medium" },
                new DogEnergyLevel { Id = 3, EnergyLevel = "High" }
                );

            modelBuilder.Entity<DogPicturesRelationships>().HasData(
                new DogPicturesRelationships { Id = EddiesPicsId, DogPicturesId = EddiesPictures },
                new DogPicturesRelationships { Id = ThorsPicsId, DogPicturesId = ThorsPictures }
                );

            modelBuilder.Entity<DogPicturesRelationships>()
                .HasMany(f => f.DogPictures);

            modelBuilder.Entity<DogPictures>().HasData(
                new DogPictures { Id = Guid.NewGuid(), DogPicturesId = EddiesPictures, Photo = "Eddies only profile Picture" },
                new DogPictures { Id = Guid.NewGuid(), DogPicturesId = ThorsPictures, Photo = "Thors first profile Picture" },
                new DogPictures { Id = Guid.NewGuid(), DogPicturesId = ThorsPictures, Photo = "Thors second profile Picture" }
                );

            modelBuilder.Entity<DogPersonality>().HasData(
                new DogPersonality { Id = EddiesPersonality, WorksWithBoys = true, WorksWithGirls = true, AverageWalk = 4, Timid = false, Confident = true, Adaptable = false, Independent = false, LaidBack = true },
                new DogPersonality { Id = ThorsPersonality, WorksWithBoys = true, WorksWithGirls = true, AverageWalk = 2, Timid = false, Confident = true, Adaptable = true, Independent = true, LaidBack = true }
                );

            modelBuilder.Entity<DogPreferences>().HasData(
                new DogPreferences { Id = EddiesPreferences, WorksWithBoys = true, WorksWithGirls = true, AverageWalk = 4, Timid = false, Confident = true, Adaptable = true, Independent = true, LaidBack = true },
                new DogPreferences { Id = ThorsPreferences, WorksWithBoys = true, WorksWithGirls = true, AverageWalk = 2, Timid = true, Confident = true, Adaptable = true, Independent = true, LaidBack = true }
                );

            Guid GabesId = Guid.NewGuid();
            Guid GabesProfileId = Guid.NewGuid();
            Guid GabesHobbyId = Guid.NewGuid();
            Guid GabesPreferenceId = Guid.NewGuid();
            Guid GabesOwnerId = Guid.NewGuid();
            
            modelBuilder.Entity<User>()
                .HasData(
                new User{ Id = GabesId, Age = 30, Email = "Nixgabriel92@gmail.com", FirstName = "Gabriel", LastName = "Nix", UserProfileId = GabesProfileId,
                    UserDogRelationshipsId = GabesPupsRelId });

            modelBuilder.Entity<UserDogRelationships>()
                .HasData(
                    new UserDogRelationships { Id = GabesPupsRelId, UsersDogId = GabesOwnerId }
                );

            modelBuilder.Entity<UserDogRelationships>()
                .HasMany(f => f.UserDogs);

            Guid UserDogId = Guid.NewGuid();    

            modelBuilder.Entity<UserDogs>()
                .HasData(
                    new UserDogs { Id = GabesOwnerId, UsersDogId = UserDogId, DogId = EddieId },
                    new UserDogs { Id = Guid.NewGuid(), UsersDogId = UserDogId, DogId = ThorId }
                );

            modelBuilder.Entity<UserPreferences>()
                .HasData(
                new UserPreferences { Id = GabesPreferenceId, Gender = "All", LocationRange = 60, YoungestAge = 25, OldestAge = 40 }
                );

            modelBuilder.Entity<UserHobbies>()
                .HasData(
                new UserHobbies { Id = GabesHobbyId, Gaming = true, Movies = true, Swimming = true }
                );

            modelBuilder.Entity<UserProfile>()
                .HasData(
                new UserProfile { Id = GabesProfileId, About = "Test Content", GenderId = 1, Job = "Student", Location = "Bullaren", Sexuality = "Bisexual",
                    UserHobbiesId = GabesHobbyId, UserPreferencesId = GabesPreferenceId});

            modelBuilder.Entity<Gender>()
                .HasData(
                new Gender { Id = 1, GenderOption = "Male"},
                new Gender { Id = 2, GenderOption = "Female" });            

        }

        public DbSet<Dog> Dogs { get; set; }
        public DbSet<DogBreed> DogBreeds { get; set; }
        public DbSet<DogPicturesRelationships> DogPicturesRelationships { get; set; }
        public DbSet<DogPictures> DogPictures { get; set; }
        public DbSet<DogPreferences> DogPreferences { get; set; }
        public DbSet<DogPersonality> DogPersonality { get; set; }
        public DbSet<DogSize> DogSizes { get; set; }
        public DbSet<DogEnergyLevel> DogEnergyLevels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDogRelationships> UserDogRelationships { get; set; }
        public DbSet<UserHobbies> UserHobbies { get; set; }
        public DbSet<UserPreferences> UserPreferences { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserDogs> UserDogs { get; set; }
        public DbSet<Gender> Genders { get; set; }        
    }
}