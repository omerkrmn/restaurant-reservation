using RR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.Conctrats.Repositories
{
    public interface IPaymentRepository : IRepositoryBase<Payment>
    {
        Task<List<Payment>> GetAllPaymentsAsync(bool trackChanges);
        Task<List<Payment>> GetPaymentsByRestourant(Guid restourantId, bool trackChanges);
        Task<Payment> GetPaymentByIdAsync(Guid paymentId, bool trackChanges);
        void CreatePayment(Payment payment);
        void UpdatePayment(Payment payment);
        void DeletePayment(Payment payment);
    }
}
