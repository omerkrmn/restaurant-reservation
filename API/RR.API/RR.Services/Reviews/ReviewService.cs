using Microsoft.EntityFrameworkCore;
using RR.API.Models;
using RR.Repositories.Conctrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Services.Reviews
{
    public class ReviewService : IReviewService
    {
        private readonly IRepositoryManager repositoryManager;

        public ReviewService(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        public async Task AddReviewAsync(Review review)
        {
            if (review == null)
                throw new ArgumentNullException(nameof(review));
            repositoryManager.Review.Create(review);
            await repositoryManager.SaveAsync();
        }

        public async Task DeleteReviewAsync(Guid id)
        {
            var review =  await repositoryManager.Review.FindByCondition(r=>r.Id.Equals(id),true).FirstOrDefaultAsync();
            if (review == null)
                throw new ArgumentNullException(nameof(review));
            repositoryManager.Review.Delete(review);
            await repositoryManager.SaveAsync();
        }

        public async Task<Review> GetReviewByIdAsync(Guid id)
        {
            var review =await repositoryManager.Review.FindByCondition(r => r.Id.Equals(id), true).FirstOrDefaultAsync();
            if (review == null)
                throw new ArgumentNullException(nameof(review));
            return review;
        }

        public async Task<IEnumerable<Review>> GetReviewsByRestaurantIdAsync(Guid restaurantId)
        {
            
            return await repositoryManager.Review
                .FindByCondition(r => r.RestaurantId.Equals(restaurantId), true)
                .ToListAsync();
        }

        public async Task<IEnumerable<Review>> GetReviewsByUserIdAsync(Guid userId)
        {
            return await repositoryManager.Review
                .FindByCondition(r => r.UserId.Equals(userId), true)
                .ToListAsync();
        }

        public async Task UpdateReviewAsync(Review review)
        {
            if (review == null)
                throw new ArgumentNullException(nameof(review));
            repositoryManager.Review.Update(review);
            await repositoryManager.SaveAsync();

        }
    }
}
