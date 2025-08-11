using RR.API.Models;
using RR.Repositories.Conctrats;
using RR.Repositories.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Services.MenuCategories
{
    public class MenuCategoryService : IMenuCategoryService
    {
        private readonly IRepositoryManager _manager;

        public MenuCategoryService(IRepositoryManager repositoryManager)
        {
            _manager = repositoryManager;
        }

        public async Task AddMenuCategoryAsync(MenuCategory menuCategory)
        {
            if (menuCategory == null)
                throw new ArgumentNullException(nameof(menuCategory), "Menu category cannot be null");
            _manager.MenuCategory.Create(menuCategory);
            await _manager.SaveAsync();
        }

        public async Task DeleteMenuCategoryAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Menu category ID cannot be empty", nameof(id));
            var menuCategory = _manager.MenuCategory.GetMenuCategoryByIdAsync(id,true);
            if (menuCategory == null)
                throw new KeyNotFoundException($"Menu category with ID {id} not found");
            _manager.MenuCategory.Delete(menuCategory.Result);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<MenuCategory>> GetMenuCategoriesByRestaurantIdAsync(Guid restaurantId)
        {
            if (restaurantId == Guid.Empty)
                throw new ArgumentException("Restaurant ID cannot be empty", nameof(restaurantId));
            var categories = await _manager.MenuCategory.GetMenuCategoriesByRestaurantIdAsync(restaurantId, false);
            return categories ?? throw new KeyNotFoundException($"No menu categories found for restaurant ID {restaurantId}");
        }

        public async Task<MenuCategory> GetMenuCategoryByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Menu category ID cannot be empty", nameof(id));
            var menuCategory = await _manager.MenuCategory.GetMenuCategoryByIdAsync(id, false);
            return menuCategory ?? throw new KeyNotFoundException($"Menu category with ID {id} not found");
        }

        public async Task UpdateMenuCategoryAsync(MenuCategory menuCategory)
        {
            if (menuCategory == null)
                throw new ArgumentNullException(nameof(menuCategory), "Menu category cannot be null");
            _manager.MenuCategory.Update(menuCategory);
            await _manager.SaveAsync();
        }
    }
}
