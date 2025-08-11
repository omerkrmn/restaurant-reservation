using RR.API.Models;
using RR.Entities.DTOs.Restourant;

namespace RR.Services.Restaurants
{
    public interface IRestaurantService
    {
        Task<List<RestaurantResponseDto>> GetAllRestaurantsAsync(bool trackChanges);
        Task<RestaurantResponseDto> GetRestaurantByIdAsync(Guid restaurantId, bool trackChanges);
        Task<RestaurantResponseDto> CreateRestaurantAsync(RestaurantForCreationDto restaurant);
        Task UpdateRestaurantAsync(RestaurantForUpdateDto restaurant);
        Task DeleteRestaurantAsync(Guid restaurantId, bool trackChanges);
        Task<List<RestaurantResponseDto>> GetAllRestourantFromCity(string city, bool trackChanges);
    }
}