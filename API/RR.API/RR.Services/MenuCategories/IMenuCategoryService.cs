using RR.API.Models;

namespace RR.Services.MenuCategories
{
    public interface IMenuCategoryService
    {
        Task<MenuCategory> GetMenuCategoryByIdAsync(Guid id);
        Task AddMenuCategoryAsync(MenuCategory menuCategory);
        Task UpdateMenuCategoryAsync(MenuCategory menuCategory);
        Task DeleteMenuCategoryAsync(Guid id);
        Task<IEnumerable<MenuCategory>> GetMenuCategoriesByRestaurantIdAsync(Guid restaurantId);

    }
}