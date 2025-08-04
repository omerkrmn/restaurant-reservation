using RR.API.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.Conctrats.Repositories
{
    public interface ITableRepository : IRepositoryBase<Table>
    {
        Task<List<Table>> GetTablesByRestourant(Guid restourantId,bool trackChanges);

        Task<Table> GetTableByIdAsync(Guid tableId, bool trackChanges);

    }
}
