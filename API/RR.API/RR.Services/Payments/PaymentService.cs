using RR.Repositories.Conctrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Services.Payments
{
    public class PaymentService : IPaymentService
    {
        private readonly IRepositoryManager repositoryManager;

        public PaymentService(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }
    }
}
