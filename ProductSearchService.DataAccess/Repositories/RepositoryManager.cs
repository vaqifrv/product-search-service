﻿using ProductSearchService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSearchService.DataAccess.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IProductRepository> _lazyProductRepository;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _lazyProductRepository = new Lazy<IProductRepository>(() => new ProductRepository(dbContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
        }

        public IProductRepository ProductRepository => _lazyProductRepository.Value;

        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
    }
}
