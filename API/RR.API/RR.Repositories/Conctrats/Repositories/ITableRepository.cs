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
        Task<List<Table>> GetAllTablesAsync(bool trackChanges);
        Task<List<Table>> GetTablesByRestourant(Guid restourantId,bool trackChanges);
        void CreateTable(Table table);
        void UpdateTable(Table table);
        void DeleteTable(Table table);

    }
}
