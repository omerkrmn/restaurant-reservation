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
    public class ReservationRepository : RepositoryBase<Reservation>, IReservationRepository
    {
        public ReservationRepository(RestourantReservationDBContext context) : base(context)
        {
        }

        public async Task<Reservation> GetReservationByIdAsync(Guid reservationId, bool trackChanges)
        {
            return await FindByCondition(r => r.Id == reservationId, trackChanges)
                        .SingleOrDefaultAsync();
        }

        public async Task<List<Reservation>> GetReservationsByRestourant(Guid restourantId, bool trackChanges)
        {
           return await FindByCondition(r => r.RestaurantId == restourantId, trackChanges)
                        .OrderBy(r => r.ReservationDate)
                        .ToListAsync();
        }
    }
}
