using Microsoft.EntityFrameworkCore;
using RR.API.Models;
using RR.Repositories.Conctrats;
using RR.Repositories.Conctrats.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.EFCore.Repositories
{
    public class MenuCategoryRepository : RepositoryBase<MenuCategory>, IMenuCategoryRepository
    {

        public MenuCategoryRepository(RestourantReservationDBContext context) : base(context)
        {

        }

        public async Task<List<MenuCategory>> GetMenuCategoriesByRestaurantIdAsync(Guid restaurantId, bool trackChanges)
        {
            return await FindByCondition(mc => mc.RestaurantId == restaurantId, trackChanges)
                .OrderBy(mc => mc.Name)
                .ToListAsync();
        }

        public async Task<MenuCategory> GetMenuCategoryByIdAsync(Guid menuCategoryId, bool trackChanges)
        {
            return await FindByCondition(mc => mc.Id == menuCategoryId, trackChanges)
                .SingleOrDefaultAsync();
        }
    }
}
