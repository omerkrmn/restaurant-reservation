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

        public void CreateTable(Table table)
        {
            throw new NotImplementedException();
        }

        public void DeleteTable(Table table)
        {
            throw new NotImplementedException();
        }

        public Task<List<Table>> GetAllTablesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<List<Table>> GetTablesByRestourant(Guid restourantId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateTable(Table table)
        {
            throw new NotImplementedException();
        }
    }
}
