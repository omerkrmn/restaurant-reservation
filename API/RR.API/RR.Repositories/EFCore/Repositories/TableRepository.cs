using Microsoft.EntityFrameworkCore;
using RR.API.Models;
using RR.Repositories.Conctrats;
using RR.Repositories.Conctrats.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.EFCore.Repositories
{
    public class TableRepository : RepositoryBase<Table>, ITableRepository
    {
        public TableRepository(RestourantReservationDBContext context) : base(context)
        {
        }
        public async Task<Table> GetTableByIdAsync(Guid tableId, bool trackChanges)
        {
            return await FindByCondition(t => t.Id == tableId, trackChanges)
                        .SingleOrDefaultAsync();
        }

        public async Task<List<Table>> GetTablesByRestourant(Guid restourantId, bool trackChanges)
        {
            return await FindByCondition(t => t.RestaurantId == restourantId, trackChanges)
                        .OrderBy(t => t.TableNumber)
                        .ToListAsync();
        }
    }
}
