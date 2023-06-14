using Entities;
using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;
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
            optionsBuilder.UseSqlServer(@"Data Source=tcp:hundtricket.database.windows.net,1433;Initial Catalog=Hundtricket;User Id=azureuser@hundtricket;Password=Thorloke1; Integrated Security=true; Column Encryption Setting=enabled; Trusted_Connection=False;Encrypt=True");
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextFactory<HundtricketContext>(
                options => options.UseSqlServer(@"Data Source=tcp:hundtricket.database.windows.net,1433;Initial Catalog=Hundtricket;User Id=azureuser@hundtricket;Password=Thorloke1; Integrated Security=true; Column Encryption Setting=enabled; Trusted_Connection=False;Encrypt=True"));
        }

        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Dog>();

            modelBuilder.Entity<DogBreed>().HasData(
                new DogBreed { Id = 1, Breed = "Mixed" },
                new DogBreed { Id = 2, Breed = "Samoyed" },
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

            modelBuilder.Entity<DogPicturesRelationships>();

            modelBuilder.Entity<DogPicturesRelationships>()
                .HasMany(f => f.DogPictures);

            modelBuilder.Entity<DogPictures>();

            modelBuilder.Entity<DogPersonality>();

            modelBuilder.Entity<DogPreferences>();

            modelBuilder.Entity<User>();

            modelBuilder.Entity<UserDogRelationships>();

            modelBuilder.Entity<UserDogRelationships>();

            modelBuilder.Entity<UserDogs>();

            modelBuilder.Entity<UserPreferences>();

            modelBuilder.Entity<UserHobbies>();

            modelBuilder.Entity<UserProfile>();

            modelBuilder.Entity<Gender>()
                .HasData(
                new Gender { Id = 1, GenderOption = "Male"},
                new Gender { Id = 2, GenderOption = "Female" });

            modelBuilder.Entity<ReportedConversation>();
            modelBuilder.Entity<Message>();

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
        public DbSet<ReportedConversation> ReportedConversation { get; set; }
        public DbSet<Message> Message { get; set; }
    }
}