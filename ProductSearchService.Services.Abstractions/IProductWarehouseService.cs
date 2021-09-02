using ProductSearchService.Domain.Entities;
using System.Threading.Tasks;

namespace ProductSearchService.Services.Abstractions
{
    public interface IProductWarehouseService
    {
        Task Save(ProductWarehouse entity);
    }
}
