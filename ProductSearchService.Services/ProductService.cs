using Microsoft.Extensions.Logging;
using ProductSearchService.Domain.Entities;
using ProductSearchService.Domain.Repositories;
using ProductSearchService.DTO;
using ProductSearchService.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductSearchService.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IWarehouseService _warehouseService;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository productRepository,
            IWarehouseService warehouseService,
            ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _warehouseService = warehouseService;
            _logger = logger;
        }

        public async Task<BaseResponse<SearchResultDto>> Search(string name)
        {
            try
            {
                double clientLat = 0, 
                       clientLon = 0;

                var warehouses = await _warehouseService.GetOrderedWarehouses(clientLat, clientLon);

                return await SearchByNameByWarehouse(name, warehouses[0]);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred when search product");
                return new BaseResponse<SearchResultDto>(null, ResponseStatus.Error);
            }
        }

        private async Task<BaseResponse<SearchResultDto>> SearchByNameByWarehouse(string name, Warehouse warehouse)
        {
            var item = await _productRepository.GetProductByNameByWarehouse(name, warehouse.Id);

            if (item != null) return new BaseResponse<SearchResultDto>(
                new SearchResultDto()
                {
                    Product = item,
                    Warehouse = warehouse
                },
                ResponseStatus.Success
                );

            return await SearchByNameByWarehouse(name, warehouse.NextClosest);
        }
    }
}
