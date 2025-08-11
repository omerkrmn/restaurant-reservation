using Microsoft.AspNetCore.Identity;
using RR.API.Models;
using RR.Services.MenuCategories;
using RR.Services.MenuItems;
using RR.Services.Notifications;
using RR.Services.Payments;
using RR.Services.Reservations;
using RR.Services.Restaurants;
using RR.Services.Reviews;
using RR.Services.Tables;
using RR.Services.Users;

namespace RR.Services.Services
{
    public interface IServiceManager
    {
        public IMenuCategoryService MenuCategoryService { get; }
        public IMenuItemService MenuItemService { get; }
        public INotificationService NotificationService { get; }
        public IPaymentService PaymentService { get; }
        public IReservationService ReservationService { get; }
        public IRestaurantService RestaurantService { get; }
        public IReviewService ReviewService { get; }
        public ITableService TableService { get; }
        public IAuthenticationService AuthenticationService { get; }
        public UserManager<User> UserManager { get; }
        }
}