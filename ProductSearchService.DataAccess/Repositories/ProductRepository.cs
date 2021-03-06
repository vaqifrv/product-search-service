using Microsoft.EntityFrameworkCore;
using ProductSearchService.Domain.Entities;
using ProductSearchService.Domain.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProductSearchService.DataAccess.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public ProductRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public async Task<Product> GetProductByNameByWarehouse(string name, int warehouseId)
        {
            var product = await _dbContext.ProductWarehouses
                .Include(x => x.Product)
                .Where(x => x.Product.Name == name && x.Warehouse.Id == warehouseId)
                .Select(x => x.Product)
                .FirstOrDefaultAsync();

            return product;
        }

        public void Save(Product entity)
        {
            _dbContext.Add(entity);
        }
    }
}
