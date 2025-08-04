using RR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.Conctrats.Repositories
{
    public interface INotificationRepository : IRepositoryBase<Notification>
    {
        Task<List<Notification>> GetNotificationsByUserIdAsync(Guid userId, bool trackChanges);
        Task<Notification> GetNotificationByIdAsync(Guid notificationId, bool trackChanges);
    }
}
