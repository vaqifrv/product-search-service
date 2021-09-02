using Microsoft.Extensions.Logging;
using ProductSearchService.Domain.Entities;
using ProductSearchService.Domain.Repositories;
using ProductSearchService.Services.Abstractions;
using System;
using System.Threading.Tasks;

namespace ProductSearchService.Services
{
    public class ProductWarehouseService : IProductWarehouseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductWarehouseRepository _productWarehouseRepository;
        private readonly ILogger<ProductWarehouseService> _logger;

        public ProductWarehouseService(IUnitOfWork unitOfWork,
            IProductWarehouseRepository productWarehouseRepository,
            ILogger<ProductWarehouseService> logger)
        {
            _unitOfWork = unitOfWork;
            _productWarehouseRepository = productWarehouseRepository;
            _logger = logger;
        }

        public async Task Save(ProductWarehouse entity)
        {
            try
            {
                _productWarehouseRepository.Save(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred when save Warehouse");
            }
        }
    }
}
