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

        public void CreateMenuItem(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteMenuItem(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public Task<List<MenuItem>> GetAllMenuItemsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<MenuItem> GetMenuItemByIdAsync(Guid menuItemId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<List<MenuItem>> GetMenuItemsByRestaurantIdAsync(Guid restaurantId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }
    }
}
