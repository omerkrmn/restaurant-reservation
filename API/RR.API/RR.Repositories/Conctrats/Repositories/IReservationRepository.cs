using RR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.Conctrats.Repositories
{
    public interface IReservationRepository : IRepositoryBase<Reservation>
    {
        Task<List<Reservation>> GetAllReservationsAsync(bool trackChanges);
        Task<List<Reservation>> GetReservationsByRestourant(Guid restourantId, bool trackChanges);
        Task<Reservation> GetReservationByIdAsync(Guid reservationId, bool trackChanges);
        void CreateReservation(Reservation reservation);
        void UpdateReservation(Reservation reservation);
        void DeleteReservation(Reservation reservation);
    }
}
