using RR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.Conctrats.Repositories
{
    public interface IRestaurantRepository : IRepositoryBase<Restaurant>
    {
        Task<Restaurant> GetRestaurantByIdAsync(Guid restaurantId, bool trackChanges);
        Task<List<Restaurant>> GetRestaurantsByCityAsync(string city, bool trackChanges);

    }
}
