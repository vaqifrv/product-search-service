using Microsoft.Extensions.Logging;
using ProductSearchService.Domain.Entities;
using ProductSearchService.Domain.Repositories;
using ProductSearchService.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductSearchService.Services
{
    public class TransportTypeService : ITransportTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITransportTypeRepository _transportTypeRepository;
        private readonly ILogger<TransportTypeService> _logger;

        public TransportTypeService(IUnitOfWork unitOfWork,
            ITransportTypeRepository transportTypeRepository, 
            ILogger<TransportTypeService> logger)
        {
            _unitOfWork = unitOfWork;
            _transportTypeRepository = transportTypeRepository;
            _logger = logger;
        }

        public async Task Save(TransportType entity)
        {
            try
            {
                _transportTypeRepository.Save(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred when save TransportType");
            }
        }

        public async Task<List<TransportType>> GetTransportTypesByWeightByDistance(double weight, double distance)
        {
            try
            {
                return await _transportTypeRepository.GetTransportTypesByWeightByDistance(weight, distance);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred when Get TransportTypes");
            }

            return null;
        }
    }
}
