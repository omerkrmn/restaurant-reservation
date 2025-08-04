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
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(RestourantReservationDBContext context) : base(context)
        {
        }

        public async Task<Payment> GetPaymentByIdAsync(Guid paymentId, bool trackChanges)
        {
            return await FindByCondition(p => p.Id == paymentId, trackChanges)
                        .SingleOrDefaultAsync();
        }

        public async Task<List<Payment>> GetPaymentsByRestourant(Guid restourantId, bool trackChanges)
        {
            return await FindByCondition(p => p.ReservationId == restourantId, trackChanges)
                        .OrderBy(p => p.CreatedAt)
                        .ToListAsync();
        }
    }
}
