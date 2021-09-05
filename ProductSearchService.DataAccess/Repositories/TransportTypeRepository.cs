using Microsoft.EntityFrameworkCore;
using ProductSearchService.Domain.Entities;
using ProductSearchService.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductSearchService.DataAccess.Repositories
{
    public class TransportTypeRepository : ITransportTypeRepository
    {
        private readonly RepositoryDbContext _dbContext;

        public TransportTypeRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public void Save(TransportType entity)
        {
            _dbContext.Add(entity);
        }

        public async Task<List<TransportType>> GetTransportTypesByWeightByDistance(double weight, double distance)
        {
            List<TransportType> result = null;

            result = await _dbContext.TransportTypes
                .Where(x => weight >= x.MinWeight && weight <= x.MaxWeight && distance >= x.MinDistance && distance <= x.MaxDistance)
                .ToListAsync();

            return result;
        }
    }
}
