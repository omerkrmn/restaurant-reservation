using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using RR.API.Models;
using RR.Repositories.Conctrats;
using RR.Services.Managers;
using RR.Services.MenuCategories;
using RR.Services.MenuItems;
using RR.Services.Notifications;
using RR.Services.Payments;
using RR.Services.Reservations;
using RR.Services.Restaurants;
using RR.Services.Reviews;
using RR.Services.Tables;
using RR.Services.Users;
using System.Net;


namespace RR.Services.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly UserManager<User> _userManager;

        private readonly Lazy<IMenuCategoryService> _menuCategoryService;
        private readonly Lazy<IMenuItemService> _menuItemService;
        private readonly Lazy<INotificationService> _notificationService;
        private readonly Lazy<IPaymentService> _paymentService;
        private readonly Lazy<IReservationService> _reservationService;
        private readonly Lazy<IRestaurantService> _restaurantService;
        private readonly Lazy<IReviewService> _reviewService;
        private readonly Lazy<ITableService> _tableService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, UserManager<User> userManager, IMapper mapper, IConfiguration configuration)
        {
            _menuCategoryService = new Lazy<IMenuCategoryService>(() => new MenuCategoryService(repositoryManager));
            _menuItemService = new Lazy<IMenuItemService>(() => new MenuItemService(repositoryManager));
            _notificationService = new Lazy<INotificationService>(() => new NotificationService(repositoryManager));
            _paymentService = new Lazy<IPaymentService>(() => new PaymentService(repositoryManager));
            _reservationService = new Lazy<IReservationService>(() => new ReservationService(repositoryManager));
            _restaurantService = new Lazy<IRestaurantService>(() => new RestaurantService(repositoryManager,mapper));
            _reviewService = new Lazy<IReviewService>(() => new ReviewService(repositoryManager));
            _tableService = new Lazy<ITableService>(() => new TableService(repositoryManager));

            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(mapper, userManager, configuration));
        }

        public IMenuCategoryService MenuCategoryService => _menuCategoryService.Value;
        public IMenuItemService MenuItemService => _menuItemService.Value;
        public INotificationService NotificationService => _notificationService.Value;
        public IPaymentService PaymentService => _paymentService.Value;
        public IReservationService ReservationService => _reservationService.Value;
        public IRestaurantService RestaurantService => _restaurantService.Value;
        public IReviewService ReviewService => _reviewService.Value;
        public ITableService TableService => _tableService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
        public UserManager<User> UserManager => _userManager;
    }
}
