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
        

        public void CreateMenuCategory(MenuCategory menuCategory)
        {
            throw new NotImplementedException();
        }

        public void DeleteMenuCategory(MenuCategory menuCategory)
        {
            throw new NotImplementedException();
        }

        public Task<List<MenuCategory>> GetAllMenuCategoriesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<List<MenuCategory>> GetMenuCategoriesByRestaurantIdAsync(Guid restaurantId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<MenuCategory> GetMenuCategoryByIdAsync(Guid menuCategoryId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateMenuCategory(MenuCategory menuCategory)
        {
            throw new NotImplementedException();
        }
    }
}
