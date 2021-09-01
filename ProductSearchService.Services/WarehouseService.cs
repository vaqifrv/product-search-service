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
        private readonly IWarehouseRepository _warehouseRepository;
        private readonly ILogger<WarehouseService> _logger;

        public WarehouseService(IWarehouseRepository warehouseRepository, ILogger<WarehouseService> logger)
        {
            _warehouseRepository = warehouseRepository;
            _logger = logger;
        }

        public Task<List<Warehouse>> GetOrderedWarehouses(double clientLat, double clientLon)
        {
            return _warehouseRepository.GetOrderedWarehouses(clientLat, clientLon);
        }
    }
}
