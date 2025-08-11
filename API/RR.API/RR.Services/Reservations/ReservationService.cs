using Microsoft.EntityFrameworkCore;
using RR.API.Models;
using RR.Repositories.Conctrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Services.Reservations
{
    public class ReservationService : IReservationService
    {
        private readonly IRepositoryManager _manager;

        public ReservationService(IRepositoryManager repositoryManager)
        {
            _manager = repositoryManager;
        }

        public async Task AddReservationAsync(Reservation reservation)
        {
            if (reservation == null)
                throw new ArgumentNullException(nameof(reservation));
            
            _manager.Reservation.Create(reservation);
            await _manager.SaveAsync();
        }

        public async Task DeleteReservationAsync(Guid id)
        {
            
            if (id == Guid.Empty)
                throw new ArgumentException("Invalid reservation ID", nameof(id));
            var reservation = await _manager.Reservation.GetReservationByIdAsync(id,true);
            if (reservation == null)
                throw new KeyNotFoundException($"Reservation with ID {id} not found.");
            _manager.Reservation.Delete(reservation);
            await _manager.SaveAsync();
        }

        public Task<Reservation> GetReservationByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Invalid reservation ID", nameof(id));
            return _manager.Reservation.GetReservationByIdAsync(id, false);
        }

        public async Task<IEnumerable<Reservation>> GetReservationsByRestaurantIdAsync(Guid restaurantId)
        {
            if (restaurantId == Guid.Empty)
                throw new ArgumentException("Invalid restaurant ID", nameof(restaurantId));
            var res = await _manager.Reservation.GetReservationsByRestourant(restaurantId, false);
            if (res is null)
                throw new KeyNotFoundException($"No reservations found for restaurant with ID {restaurantId}.");
            return res;
        }

        public async Task<IEnumerable<Reservation>> GetReservationsByUserIdAsync(Guid userId)
        {
            if (userId == Guid.Empty)
                throw new ArgumentException("Invalid user ID", nameof(userId));
            return await _manager.Reservation.FindByCondition(r => r.UserId.Equals(userId), false).ToListAsync();
        }

        public async Task UpdateReservationAsync(Reservation reservation)
        {
            if (reservation == null)
                throw new ArgumentNullException(nameof(reservation));
            if (reservation.Id == Guid.Empty)
                throw new ArgumentException("Invalid reservation ID", nameof(reservation.Id));
            
            _manager.Reservation.Update(reservation);
            await _manager.SaveAsync();
        }
    }
}
