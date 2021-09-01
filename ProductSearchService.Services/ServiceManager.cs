using ProductSearchService.Domain.Repositories;
using ProductSearchService.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSearchService.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _lazyProductService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyProductService = new Lazy<IProductService>(() => new ProductService(repositoryManager));
        }

        public IProductService ProductService => _lazyProductService.Value;
    }
}
