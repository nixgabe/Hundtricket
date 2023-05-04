using Entities;
using Infrastructure.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IDogFiltersRepository 
    {
        public Task<DogFilterViewModel> GetDogFiltersOnId(Dog dog);
        public void UpdateDogFilters(DogFilterViewModel dogPreferencesViewModel, Guid dogId);
    }
}
