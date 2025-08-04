using RR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.Conctrats.Repositories
{
    public interface IMenuItemRepository : IRepositoryBase<MenuItem>
    {
        Task<List<MenuItem>> GetAllMenuItemsAsync(bool trackChanges);
        Task<MenuItem> GetMenuItemByIdAsync(Guid menuItemId, bool trackChanges);
        Task<List<MenuItem>> GetMenuItemsByRestaurantIdAsync(Guid restaurantId, bool trackChanges);
        void CreateMenuItem(MenuItem menuItem);
        void UpdateMenuItem(MenuItem menuItem);
        void DeleteMenuItem(MenuItem menuItem);
    }
}
