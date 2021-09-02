using ProductSearchService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductSearchService.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductByNameByWarehouse(string name, int warehouseId);
        void Save(Product entity);
    }
}
