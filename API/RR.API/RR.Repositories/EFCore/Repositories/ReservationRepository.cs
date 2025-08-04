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

        public void CreateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public void DeleteReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reservation>> GetAllReservationsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Reservation> GetReservationByIdAsync(Guid reservationId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reservation>> GetReservationsByRestourant(Guid restourantId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}
