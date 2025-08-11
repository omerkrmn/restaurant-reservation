using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RR.API.Models;
using RR.Entities.DTOs.Restourant;
using RR.Repositories.Conctrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Services.Restaurants
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper _mapper;

        public RestaurantService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<RestaurantResponseDto> CreateRestaurantAsync(RestaurantForCreationDto restaurant)
        {
            if (restaurant == null)
                throw new ArgumentNullException(nameof(restaurant), "Restaurant cannot be null.");
            var restaurantEntity = _mapper.Map<Restaurant>(restaurant);
            repositoryManager.Restaurant.Create(restaurantEntity);
            await repositoryManager.SaveAsync();
            return _mapper.Map<RestaurantResponseDto>(restaurantEntity);

        }

        public async Task DeleteRestaurantAsync(Guid restaurantId, bool trackChanges)
        {
            if (restaurantId == Guid.Empty)
                throw new ArgumentException("Restaurant ID cannot be empty.", nameof(restaurantId));
            var restaurant = await repositoryManager.Restaurant.GetRestaurantByIdAsync(restaurantId, trackChanges);
            if (restaurant == null)
                throw new KeyNotFoundException($"Restaurant with ID {restaurantId} not found.");
            repositoryManager.Restaurant.Delete(restaurant);
            await repositoryManager.SaveAsync();
        }

        public async Task<List<RestaurantResponseDto>> GetAllRestaurantsAsync(bool trackChanges)
        {
            var restaurants = await repositoryManager.Restaurant.FindAll(trackChanges).ToListAsync();
            return restaurants.Select(r => _mapper.Map<RestaurantResponseDto>(r)).ToList();

        }

        public async Task<List<RestaurantResponseDto>> GetAllRestourantFromCity(string city, bool trackChanges)
        {
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City cannot be null or empty.", nameof(city));
            var restaurants = repositoryManager.Restaurant.FindByCondition(r => r.Address.Contains(city, StringComparison.OrdinalIgnoreCase), trackChanges);
            var response = await restaurants.Select(r => _mapper.Map<RestaurantResponseDto>(r)).ToListAsync();
            return response;
        }

        public async Task<RestaurantResponseDto> GetRestaurantByIdAsync(Guid restaurantId, bool trackChanges)
        {
            if (restaurantId == Guid.Empty)
                throw new ArgumentException("Restaurant ID cannot be empty.", nameof(restaurantId));
            var restaurant = await repositoryManager.Restaurant.GetRestaurantByIdAsync(restaurantId, trackChanges);
            if (restaurant == null)
                throw new KeyNotFoundException($"Restaurant with ID {restaurantId} not found.");
            return _mapper.Map<RestaurantResponseDto>(restaurant);
        }

        public Task UpdateRestaurantAsync(RestaurantForUpdateDto restaurant)
        {
            if (restaurant == null)
                throw new ArgumentNullException(nameof(restaurant), "Restaurant cannot be null.");
            var restaurantEntity = _mapper.Map<Restaurant>(restaurant);
            repositoryManager.Restaurant.Update(restaurantEntity);
            return repositoryManager.SaveAsync();
        }
    }
}
