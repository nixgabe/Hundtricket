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
        public Task<DogPreferencesViewModel> GetDogFiltersOnId(Guid dogFiltersRelationshipId);
        public void UpdateDogFilters(DogPreferencesViewModel dogPreferencesViewModel);
    }
}
