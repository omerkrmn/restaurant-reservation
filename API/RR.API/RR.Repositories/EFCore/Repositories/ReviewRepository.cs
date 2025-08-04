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
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(RestourantReservationDBContext context) : base(context)
        {
        }

        public async Task<double> GetReviewRateByRestourantAsync(Guid restourantId, bool trackChanges)
        {
                     return await FindByCondition(r => r.RestaurantId == restourantId, trackChanges)
                                 .AverageAsync(r => r.Rating);
        }

        public Task<List<Review>> GetReviewsByRestourant(Guid restourantId, bool trackChanges)=>
                                  FindByCondition(r => r.RestaurantId == restourantId, trackChanges)
                                 .OrderBy(r => r.CreatedAt)
                                 .ToListAsync();

    }
}
