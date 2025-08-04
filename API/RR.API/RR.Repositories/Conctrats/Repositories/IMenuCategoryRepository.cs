using RR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.Conctrats.Repositories
{
    public interface IMenuCategoryRepository : IRepositoryBase<MenuCategory>
    {
        Task<List<MenuCategory>> GetAllMenuCategoriesAsync(bool trackChanges);
        Task<MenuCategory> GetMenuCategoryByIdAsync(Guid menuCategoryId, bool trackChanges);
        Task<List<MenuCategory>> GetMenuCategoriesByRestaurantIdAsync(Guid restaurantId, bool trackChanges);
        void CreateMenuCategory(MenuCategory menuCategory);
        void UpdateMenuCategory(MenuCategory menuCategory);
        void DeleteMenuCategory(MenuCategory menuCategory);


    }
}
