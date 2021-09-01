using ProductSearchService.Domain.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductSearchService.Domain.Repositories
{
    public interface IWarehouseRepository
    {
        public Task<List<Warehouse>> GetOrderedWarehouses(double clientLat, double clientLon);
    }
}
