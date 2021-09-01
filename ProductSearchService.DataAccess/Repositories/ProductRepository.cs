using ProductSearchService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSearchService.DataAccess.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public ProductRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;
    }
}
