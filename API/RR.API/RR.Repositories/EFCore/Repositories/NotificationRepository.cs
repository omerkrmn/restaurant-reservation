using RR.API.Models;
using RR.Repositories.Conctrats.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.EFCore.Repositories
{
    public class NotificationRepository : RepositoryBase<Notification>, INotificationRepository
    {
        public NotificationRepository(RestourantReservationDBContext context) : base(context)
        {
        }

        public void CreateNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public void DeleteNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public Task<List<Notification>> GetAllNotificationsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Notification> GetNotificationByIdAsync(Guid notificationId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<List<Notification>> GetNotificationsByUserIdAsync(Guid userId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateNotification(Notification notification)
        {
            throw new NotImplementedException();
        }
    }
}
