using Microsoft.Extensions.Logging;
using ProductSearchService.Domain.Entities;
using ProductSearchService.Domain.Repositories;
using ProductSearchService.DTO;
using ProductSearchService.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductSearchService.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWarehouseRepository _warehouseRepository;
        private readonly ILogger<WarehouseService> _logger;

        public WarehouseService(IUnitOfWork unitOfWork, 
            IWarehouseRepository warehouseRepository, 
            ILogger<WarehouseService> logger)
        {
            _unitOfWork = unitOfWork;
            _warehouseRepository = warehouseRepository;
            _logger = logger;
        }

        public async Task Save(Warehouse entity)
        {
            try
            {
                _warehouseRepository.Save(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred when save Warehouse");
            }
        }

        public async Task<List<Warehouse>> GetOrderedWarehouses(double clientLat, double clientLon)
        {
            return await _warehouseRepository.GetOrderedWarehouses(clientLat, clientLon);
        }
    }
}
