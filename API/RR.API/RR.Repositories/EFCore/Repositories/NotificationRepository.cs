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
    public class NotificationRepository : RepositoryBase<Notification>, INotificationRepository
    {
        public NotificationRepository(RestourantReservationDBContext context) : base(context)
        {
        }

        public async Task<Notification> GetNotificationByIdAsync(Guid notificationId, bool trackChanges)
        {
            return await FindByCondition(n => n.Id == notificationId, trackChanges)
                        .SingleOrDefaultAsync();
        }

        public async Task<List<Notification>> GetNotificationsByUserIdAsync(Guid userId, bool trackChanges)
        {
            return await FindByCondition(n => n.UserId == userId, trackChanges)
                        .OrderByDescending(n => n.CreatedAt)
                        .ToListAsync();
        }
    }
}
