using RR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.Conctrats.Repositories
{
    public interface IReviewRepository : IRepositoryBase<Review>
    {
        Task<List<Review>> GetReviewsByRestourant(Guid restourantId, bool trackChanges);
        Task<double> GetReviewRateByRestourantAsync(Guid restourantId, bool trackChanges);

    }
}
