using Microsoft.EntityFrameworkCore;
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
        public async Task<Restaurant> GetRestaurantByIdAsync(Guid restaurantId, bool trackChanges) => await
                                FindByCondition(r => r.Id.Equals(restaurantId), trackChanges)
                               .SingleOrDefaultAsync();

        public async Task<List<Restaurant>> GetRestaurantsByCityAsync(string city, bool trackChanges) => await
                                FindByCondition(r => r.Address.Contains(city), trackChanges)
                               .OrderBy(r => r.Name)
                               .ToListAsync();

    }
}
