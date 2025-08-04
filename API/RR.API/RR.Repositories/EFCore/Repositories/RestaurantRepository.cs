using RR.API.Models;
using RR.Repositories.Conctrats.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.EFCore.Repositories
{
    public class RestaurantRepository : RepositoryBase<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(RestourantReservationDBContext context) : base(context)
        {
        }

        public void CreateRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public Task<List<Restaurant>> GetAllRestaurantsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Restaurant> GetRestaurantByIdAsync(Guid restaurantId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<List<Restaurant>> GetRestaurantsByCityAsync(string city, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
