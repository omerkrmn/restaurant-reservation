using RR.Repositories.Conctrats;
using RR.Repositories.Conctrats.Repositories;
using RR.Repositories.EFCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {

        private readonly RestourantReservationDBContext _context;
        private readonly Lazy<ITableRepository> _tableRepository;
        private readonly Lazy<IReviewRepository> _reviewRepository;
        private readonly Lazy<IRestaurantRepository> _restaurantRepository;
        private readonly Lazy<IReservationRepository> _reservationRepository;
        private readonly Lazy<IPaymentRepository> _paymentRepository;
        private readonly Lazy<INotificationRepository> _notificationRepository;
        private readonly Lazy<IMenuItemRepository> _menuItemRepository;
        private readonly Lazy<IMenuCategoryRepository> _menuCategoryRepository;

        public RepositoryManager(RestourantReservationDBContext context)
        {
            _context = context;
            _tableRepository = new Lazy<ITableRepository>(() => new TableRepository(_context));
            _reviewRepository = new Lazy<IReviewRepository>(() => new ReviewRepository(_context));
            _restaurantRepository = new Lazy<IRestaurantRepository>(() => new RestaurantRepository(_context));
            _reservationRepository = new Lazy<IReservationRepository>(() => new ReservationRepository(_context));
            _paymentRepository = new Lazy<IPaymentRepository>(() => new PaymentRepository(_context));
            _notificationRepository = new Lazy<INotificationRepository>(() => new NotificationRepository(_context));
            _menuItemRepository = new Lazy<IMenuItemRepository>(() => new MenuItemRepository(_context));
            _menuCategoryRepository = new Lazy<IMenuCategoryRepository>(() => new MenuCategoryRepository(_context));
        }

        public ITableRepository Table => _tableRepository.Value;
        public IReviewRepository Review => _reviewRepository.Value;
        public IRestaurantRepository Restaurant => _restaurantRepository.Value;
        public IReservationRepository Reservation => _reservationRepository.Value;
        public IPaymentRepository Payment => _paymentRepository.Value;
        public INotificationRepository Notification => _notificationRepository.Value;
        public IMenuItemRepository MenuItem => _menuItemRepository.Value;
        public IMenuCategoryRepository MenuCategory => _menuCategoryRepository.Value;
        public Task SaveAsync() => _context.SaveChangesAsync();
    }
}
