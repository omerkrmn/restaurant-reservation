using RR.Repositories.Conctrats.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.Conctrats
{
    public interface IRepositoryManager
    {
        ITableRepository Table { get; }
        IReviewRepository Review { get; }
        IRestaurantRepository Restaurant { get; }
        IReservationRepository Reservation { get; }
        IPaymentRepository Payment { get; }
        INotificationRepository Notification { get; }
        IMenuItemRepository MenuItem { get; }
        IMenuCategoryRepository MenuCategory { get; }

        Task SaveAsync();
    }
}
