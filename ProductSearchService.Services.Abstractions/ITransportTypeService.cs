using ProductSearchService.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductSearchService.Services.Abstractions
{
    public interface ITransportTypeService
    {
        Task Save(TransportType entity);
        Task<List<TransportType>> GetTransportTypesByWeightByDistance(double weight, double distance);
    }
}
