using Entities;
using Infrastructure.Overviews;
using Infrastructure.Repository;
using Moq;
using Microsoft.Identity.Client;
using FluentAssertions;

namespace AddDogTests
{
    public class AddDogOverviewUnitTests 
    {
        [Fact]
        public async Task CreateNewDogTemplates_CreatesNewInstanceOfDog_ShouldBeTrue()
        {
            //Arrange
            var dogInterface = new Mock<IDogRepository>();
            var addDogOverview = new AddDogOverview(dogInterface.Object);

            Dog testDog = new Dog()
            {
                DogId = Guid.NewGuid(),
                Name = "",
                Age = 0,
                DogBreedId = 1,
                DogEnergyLevelId = 1,
                DogSizeId = 1,
                Allergenic = false,
            };

            //Act
            await addDogOverview.CreateNewDogTemplates();

            testDog.DogId = addDogOverview.NewDog.DogId;

            //Assert
            testDog.Equals(addDogOverview.NewDog);
        }
    }
}