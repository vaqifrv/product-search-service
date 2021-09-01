﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSearchService.Domain.Repositories
{
    public interface IRepositoryManager
    {
        IProductRepository ProductRepository { get; }

        IUnitOfWork UnitOfWork { get; }
    }
}