using RR.API.Models;
using RR.Repositories.Conctrats.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.EFCore.Repositories
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(RestourantReservationDBContext context) : base(context)
        {
        }

        public void CreateReview(Review review)
        {
            throw new NotImplementedException();
        }

        public void DeleteReview(Review review)
        {
            throw new NotImplementedException();
        }

        public Task<List<Review>> GetAllReviewsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Review> GetReviewByIdAsync(Guid reviewId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<List<Review>> GetReviewsByRestourant(Guid restourantId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
