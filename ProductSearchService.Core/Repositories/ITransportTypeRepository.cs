using ProductSearchService.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductSearchService.Domain.Repositories
{
    public interface ITransportTypeRepository
    {
        void Save(TransportType entity);
        Task<List<TransportType>> GetTransportTypesByWeightByDistance(double weight, double distance);
    }
}
