using RR.API.Models;

namespace RR.Services.Notifications
{
    public interface INotificationService
    {
        Task<IEnumerable<Notification>> GetNotificationsByUserIdAsync(Guid userId);
        Task<Notification> GetNotificationByIdAsync(Guid id);
        Task AddNotificationAsync(Notification notification);
        Task UpdateNotificationAsync(Notification notification);
        Task DeleteNotificationAsync(Guid id);
        Task MarkNotificationAsReadAsync(Guid id);
        Task MarkAllNotificationsAsReadAsync(Guid userId);
    }
}