using ProductSearchService.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductSearchService.Services.Abstractions
{
    public interface IWarehouseService
    {
        Task<List<Warehouse>> GetOrderedWarehouses(double clientLat, double clientLon);
    }
}
