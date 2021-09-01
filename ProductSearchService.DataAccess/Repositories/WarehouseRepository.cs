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

        public async Task<List<Warehouse>> GetOrderedWarehouses(double clientLat, double clientLon)
        {
            var warehouses = await _dbContext.Warehouses.ToListAsync();

            warehouses.ForEach((x) =>
            {
                x.DistanceByClient = Helpers.CalculateDistanceByLatLong(x.Lat, x.Long, clientLat, clientLon);
            });

            warehouses = warehouses.OrderBy(x => x.DistanceByClient).ToList();

            for (int i = 0; i < warehouses.Count - 1; i++)
            {
                warehouses[i].NextClosest = warehouses[i + 1];
            }

            return warehouses;
        }
    }
}
