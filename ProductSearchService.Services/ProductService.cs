using ProductSearchService.Domain.Repositories;
using ProductSearchService.Services.Abstractions;
using System;

namespace ProductSearchService.Services
{
    public class ProductService: IProductService
    {
        private readonly IRepositoryManager _repositoryManager;

        public ProductService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;
    }
}
