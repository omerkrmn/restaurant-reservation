using RR.API.Models;
using RR.Repositories.Conctrats.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.EFCore.Repositories
{
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(RestourantReservationDBContext context) : base(context)
        {
        }

        public void CreatePayment(Payment payment)
        {
            throw new NotImplementedException();
        }

        public void DeletePayment(Payment payment)
        {
            throw new NotImplementedException();
        }

        public Task<List<Payment>> GetAllPaymentsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Payment> GetPaymentByIdAsync(Guid paymentId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<List<Payment>> GetPaymentsByRestourant(Guid restourantId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdatePayment(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}
