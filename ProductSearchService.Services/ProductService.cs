using Microsoft.Extensions.Logging;
using ProductSearchService.Domain.Entities;
using ProductSearchService.Domain.Repositories;
using ProductSearchService.DTO;
using ProductSearchService.DTO.Response;
using ProductSearchService.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductSearchService.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductRepository _productRepository;
        private readonly IWarehouseService _warehouseService;
        private readonly ILogger<ProductService> _logger;

        const double clientLat = 40.1431, clientLon = 47.5769; // Azerbaijan coordinates

        public ProductService(IUnitOfWork unitOfWork,
            IProductRepository productRepository,
            IWarehouseService warehouseService,
            ILogger<ProductService> logger)
        {
            _unitOfWork = unitOfWork;
            _productRepository = productRepository;
            _warehouseService = warehouseService;
            _logger = logger;
        }

        public async Task Save(Product entity)
        {
            try
            {
                _productRepository.Save(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred when save product");
            }
        }

        public async Task<BaseResponse<SearchResultDto>> Search(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name)) return Helpers.BadRequestResult;

                var warehouses = await _warehouseService.GetOrderedWarehouses(clientLat, clientLon);

                return await SearchByNameByWarehouse(name, warehouses.FirstOrDefault());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred when search product");
                return Helpers.ErrorResult;
            }
        }

        private async Task<BaseResponse<SearchResultDto>> SearchByNameByWarehouse(string name, Warehouse warehouse)
        {
            // if warehouses not exist in database
            if(warehouse == null) return Helpers.NotFoundResult;

            var item = await _productRepository.GetProductByNameByWarehouse(name, warehouse.Id);

            if (item != null) return Helpers.SuccessResult(item, warehouse);

            // item not found curret warehouse, search in next closest
            if (warehouse.NextClosest == null) return Helpers.NotFoundResult;

            return await SearchByNameByWarehouse(name, warehouse.NextClosest);
        }
    }
}
