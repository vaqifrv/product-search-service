using Microsoft.EntityFrameworkCore;
using ProductSearchService.Domain.Entities;
using ProductSearchService.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductSearchService.DataAccess.Repositories
{
    public class WarehouseRepository: IWarehouseRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public WarehouseRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public async Task<List<Warehouse>> GetAllAsync()
        {
            return await _dbContext.Warehouses.ToListAsync();
        }

        public void Save(Warehouse entity)
        {
            _dbContext.Add(entity);
        }
    }
}
