using Microsoft.EntityFrameworkCore;
using RR.API.Models;
using RR.Repositories.Conctrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Services.Tables
{
    public class TableService : ITableService
    {
        private readonly IRepositoryManager _manager;

        public TableService(IRepositoryManager repositoryManager)
        {
            _manager = repositoryManager;
        }

        public Task AddTableAsync(Table table)
        {
            if (table == null)
                throw new ArgumentNullException(nameof(table), "Table cannot be null");
            _manager.Table.Create(table);
            return _manager.SaveAsync();

        }

        public async Task DeleteTableAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Invalid table ID", nameof(id));
            var table = await _manager.Table.GetTableByIdAsync(id,true);
            if (table is null)
                throw new KeyNotFoundException($"Table with ID {id} not found");
            _manager.Table.Delete(table);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<Table>> GetAllTablesAsync()
        {
            return await _manager.Table.FindAll(false).ToListAsync();
        }

        public Task<Table> GetTableByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Invalid table ID", nameof(id));
            return _manager.Table.GetTableByIdAsync(id, false);
        }

        public async Task<IEnumerable<Table>> GetTablesByRestaurantIdAsync(Guid restaurantId)
        {
            if (restaurantId == Guid.Empty)
                throw new ArgumentException("Invalid restaurant ID", nameof(restaurantId));
            return  await _manager.Table.GetTablesByRestourant(restaurantId, false);
        }

        public Task UpdateTableAsync(Table table)
        {
            if (table == null)
                throw new ArgumentNullException(nameof(table), "Table cannot be null");
            if (table.Id == Guid.Empty)
                throw new ArgumentException("Invalid table ID", nameof(table.Id));
            _manager.Table.Update(table);
            return _manager.SaveAsync();
        }
    }
}
