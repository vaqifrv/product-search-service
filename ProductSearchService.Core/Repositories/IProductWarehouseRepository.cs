using ProductSearchService.Domain.Entities;

namespace ProductSearchService.Domain.Repositories
{
    public interface IProductWarehouseRepository
    {
        void Save(ProductWarehouse entity);
    }
}
