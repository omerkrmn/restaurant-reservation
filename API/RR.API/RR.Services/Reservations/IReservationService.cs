using RR.API.Models;

namespace RR.Services.Reservations
{
    public interface IReservationService
    {
        Task<IEnumerable<Reservation>> GetReservationsByRestaurantIdAsync(Guid restaurantId);
        Task<Reservation> GetReservationByIdAsync(Guid id);
        Task AddReservationAsync(Reservation reservation);
        Task UpdateReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(Guid id);
        Task<IEnumerable<Reservation>> GetReservationsByUserIdAsync(Guid userId);
    }
}