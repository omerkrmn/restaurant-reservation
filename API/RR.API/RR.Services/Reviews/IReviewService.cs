using RR.API.Models;

namespace RR.Services.Reviews
{
    public interface IReviewService
    {
        Task<IEnumerable<Review>> GetReviewsByRestaurantIdAsync(Guid restaurantId);
        Task<Review> GetReviewByIdAsync(Guid id);
        Task AddReviewAsync(Review review);
        Task UpdateReviewAsync(Review review);
        Task DeleteReviewAsync(Guid id);
        Task<IEnumerable<Review>> GetReviewsByUserIdAsync(Guid userId);
    }
}