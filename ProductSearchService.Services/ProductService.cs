using Microsoft.Extensions.Logging;
using ProductSearchService.Domain.Repositories;
using ProductSearchService.DTO;
using ProductSearchService.Services.Abstractions;
using System;

namespace ProductSearchService.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository productRepository, ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public BaseResponse<SearchResultDto> Search(string name)
        {
            try
            {
                return new BaseResponse<SearchResultDto>(null, ResponseStatus.Success);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred when search product");
                return new BaseResponse<SearchResultDto>(null, ResponseStatus.Error);
            }
        }
    }
}
