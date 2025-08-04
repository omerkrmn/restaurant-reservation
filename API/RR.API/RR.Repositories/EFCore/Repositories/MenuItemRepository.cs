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
    public class MenuItemRepository : RepositoryBase<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(RestourantReservationDBContext context) : base(context)
        {
        }

        public async Task<MenuItem> GetMenuItemByIdAsync(Guid menuItemId, bool trackChanges)
        {
            return await FindByCondition(m => m.Id == menuItemId, trackChanges)
                        .SingleOrDefaultAsync();
        }

        public async Task<List<MenuItem>> GetMenuItemsByRestaurantIdAsync(Guid restaurantId, bool trackChanges)
        {
            return await FindByCondition(m => m.RestaurantId == restaurantId, trackChanges)
                        .OrderBy(m => m.Name)
                        .ToListAsync();
        }
    }
}
