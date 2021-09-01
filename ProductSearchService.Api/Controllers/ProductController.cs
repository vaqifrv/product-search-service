using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductSearchService.Domain.Entities;
using ProductSearchService.Services.Abstractions;
using System.Collections.Generic;

namespace ProductSearchService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IServiceManager serviceManager, ILogger<ProductController> logger)
        {
            _serviceManager = serviceManager;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new List<Product>();
        }
    }
}
