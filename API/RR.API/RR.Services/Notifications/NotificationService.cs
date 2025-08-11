using Microsoft.EntityFrameworkCore;
using RR.API.Models;
using RR.Repositories.Conctrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Services.Notifications
{
    public class NotificationService : INotificationService
    {
        private readonly IRepositoryManager repositoryManager;

        public NotificationService(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        public async Task AddNotificationAsync(Notification notification)
        {
            if (notification == null)
                throw new ArgumentNullException(nameof(notification));
            repositoryManager.Notification.Create(notification);
        }

        public async Task DeleteNotificationAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Notification ID cannot be empty.", nameof(id));
            var notif = await repositoryManager.Notification.FindByCondition(n => n.Id.Equals(id), true)
                .FirstOrDefaultAsync();
            if (notif is null)
                throw new KeyNotFoundException($"Notification with ID {id} not found.");
            repositoryManager.Notification.Delete(notif);
        }

        public async Task<Notification> GetNotificationByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Notification ID cannot be empty.", nameof(id));
            var notif = await repositoryManager.Notification.FindByCondition(n => n.Id.Equals(id), true)
                .FirstOrDefaultAsync();
            return notif ?? throw new KeyNotFoundException($"Notification with ID {id} not found.");

        }

        public async Task<IEnumerable<Notification>> GetNotificationsByUserIdAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentException("User ID cannot be null or empty.", nameof(userId));
            return await repositoryManager.Notification
                .FindByCondition(n => n.UserId.Equals(userId), true)
                .ToListAsync();
        }

        public Task<IEnumerable<Notification>> GetNotificationsByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException("This method is not implemented for Guid userId.");
        }

        public Task MarkAllNotificationsAsReadAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentException("User ID cannot be null or empty.", nameof(userId));
            var notifications = repositoryManager.Notification
                .FindByCondition(n => n.UserId.Equals(userId) && !n.IsRead, true);
            foreach (var notification in notifications)
            {
                notification.IsRead = true;
                repositoryManager.Notification.Update(notification);
            }
            return Task.CompletedTask;
        }

        public Task MarkAllNotificationsAsReadAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task MarkNotificationAsReadAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Notification ID cannot be empty.", nameof(id));
            var notification = repositoryManager.Notification
                .FindByCondition(n => n.Id.Equals(id), true)
                .FirstOrDefault();
            if (notification == null)
                throw new KeyNotFoundException($"Notification with ID {id} not found.");
            notification.IsRead = true;
            repositoryManager.Notification.Update(notification);
            return Task.CompletedTask;

        }

        public Task UpdateNotificationAsync(Notification notification)
        {
            if (notification == null)
                throw new ArgumentNullException(nameof(notification));
            if (notification.Id == Guid.Empty)
                throw new ArgumentException("Notification ID cannot be empty.", nameof(notification.Id));
            var existingNotification = repositoryManager.Notification
                .FindByCondition(n => n.Id.Equals(notification.Id), true)
                .FirstOrDefault();
            if (existingNotification == null)
                throw new KeyNotFoundException($"Notification with ID {notification.Id} not found.");
            existingNotification.Message = notification.Message;
            existingNotification.IsRead = notification.IsRead;
            repositoryManager.Notification.Update(existingNotification);
            return Task.CompletedTask;

        }
    }
}
