using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSearchService.Services.Abstractions
{
    public interface IServiceManager
    {
        IProductService ProductService { get; }
    }
}
