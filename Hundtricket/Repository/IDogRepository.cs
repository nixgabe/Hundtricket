﻿using Infrastructure.Service.ViewModels;

namespace Infrastructure.Repository
{
    public interface IDogRepository
    {
        public Task<List<DogViewModel>> GetAllDogs();
        public Task<AddDogViewModel> FillDogviewModelLists();
    }
}
