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
            Guid EddiesFilters = Guid.NewGuid();
            Guid EddiesPersonality = Guid.NewGuid();
            Guid EddiesPreferences = Guid.NewGuid();
            
            Guid ThorId = Guid.NewGuid();
            int ThorBreed = 2;
            Guid ThorsPicsId = Guid.NewGuid();
            Guid ThorsPictures = Guid.NewGuid();
            Guid ThorsFilters = Guid.NewGuid();
            Guid ThorsPersonality = Guid.NewGuid();
            Guid ThorsPreferences = Guid.NewGuid();

            modelBuilder.Entity<Dog>()
                .HasData(
                new Dog { DogId = EddieId, Name = "Eddie", Age = 1, DogBreedId = EddieBreed, DogPicturesRelationshipsId = EddiesPicsId, 
                    DogFiltersRelationshipsId = EddiesFilters, DogSizeId = 3, DogEnergyLevelId = 2
                },
                new Dog { DogId = ThorId, Name = "Thor", Age = 11, DogBreedId = ThorBreed, DogPicturesRelationshipsId = ThorsPicsId, 
                    DogFiltersRelationshipsId = ThorsFilters, DogSizeId = 4, DogEnergyLevelId = 1
                });

            modelBuilder.Entity<DogBreed>().HasData(
                new DogBreed { Id = EddieBreed, Breed = "Mixed" },
                new DogBreed { Id = ThorBreed, Breed = "Samoyed" }
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

            modelBuilder.Entity<DogFiltersRelationships>().HasData(
                new DogFiltersRelationships { Id = EddiesFilters, DogPersonality = EddiesPersonality, DogPreferences = EddiesPreferences },
                new DogFiltersRelationships { Id = ThorsFilters, DogPersonality = ThorsPersonality, DogPreferences = ThorsPreferences }
                );

            modelBuilder.Entity<DogFilters>()
                .HasData(
                new DogFilters { Id = EddiesPersonality, EnergyLevel = "Medium" },
                new DogFilters { Id = EddiesPreferences, EnergyLevel = "Medium2" },
                new DogFilters { Id = ThorsPersonality, EnergyLevel = "Low" },
                new DogFilters { Id = ThorsPreferences, EnergyLevel = "Low2" }
                );

            modelBuilder.Entity<DogFiltersRelationships>()
                .HasMany(f => f.DogFilters);

            Guid GabesId = Guid.NewGuid();
            Guid GabesProfileId = Guid.NewGuid();
            Guid GabesHobbiesRelationshipsId = Guid.NewGuid();
            Guid GabesLikesId = Guid.NewGuid();
            Guid GabesDislikesId = Guid.NewGuid();
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

            modelBuilder.Entity<UserDogs>()
                .HasData(
                    new UserDogs { Id = Guid.NewGuid(), UsersDogId = GabesOwnerId, DogId = EddieId },
                    new UserDogs { Id = Guid.NewGuid(), UsersDogId = GabesOwnerId, DogId = ThorId }
                );

            modelBuilder.Entity<UserPreferences>()
                .HasData(
                new UserPreferences { Id = GabesPreferenceId, Gender = "All", LocationRange = 60, YoungestAge = 25, OldestAge = 40 }
                );

            modelBuilder.Entity<UserHobbies>()
                .HasData(
                new UserHobbies { Id = GabesLikesId, Gaming = true, Movies = true, Swimming = true },
                new UserHobbies { Id = GabesDislikesId, Gymming = true }
                );

            modelBuilder.Entity<UserHobbiesRelationShips>()
                .HasData(
                new UserHobbiesRelationShips { Id = GabesHobbiesRelationshipsId, LikesId = GabesLikesId, DislikesId = GabesDislikesId }
                );

            modelBuilder.Entity<UserHobbiesRelationShips>()
                .HasMany(f => f.UserHobbies);

            modelBuilder.Entity<UserProfile>()
                .HasData(
                new UserProfile { Id = GabesProfileId, About = "Test Content", Gender = "Male", Job = "Student", Location = "Bullaren", Sexuality = "Bisexual",
                    UserHobbiesRelationshipsId = GabesHobbiesRelationshipsId, UserPreferencesId = GabesPreferenceId});
        }

        public DbSet<Dog> Dogs { get; set; }
        public DbSet<DogBreed> DogBreeds { get; set; }
        public DbSet<DogPicturesRelationships> DogPicturesRelationships { get; set; }
        public DbSet<DogPictures> DogPictures { get; set; }
        public DbSet<DogFiltersRelationships> DogFiltersRelationships { get; set; }
        public DbSet<DogFilters> DogFilters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDogRelationships> UserDogRelationships { get; set; }
        public DbSet<UserHobbies> UserHobbies { get; set; }
        public DbSet<UserHobbiesRelationShips> UserHobbiesRelationShips { get; set; }
        public DbSet<UserPreferences> UserPreferences { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}