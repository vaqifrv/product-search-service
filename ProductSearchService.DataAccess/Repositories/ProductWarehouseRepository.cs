using ProductSearchService.Domain.Entities;
using ProductSearchService.Domain.Repositories;

namespace ProductSearchService.DataAccess.Repositories
{
    public class ProductWarehouseRepository : IProductWarehouseRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public ProductWarehouseRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public void Save(ProductWarehouse entity)
        {
            _dbContext.Add(entity);
        }
    }
}
