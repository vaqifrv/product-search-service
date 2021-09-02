using Microsoft.AspNetCore.Mvc;
using ProductSearchService.Domain.Entities;
using ProductSearchService.DTO.Request;
using ProductSearchService.Services.Abstractions;
using System.Threading.Tasks;

namespace ProductSearchService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductWarehouseController : ControllerBase
    {
        private readonly IProductWarehouseService _productWarehouseService;

        public ProductWarehouseController(IProductWarehouseService productWarehouseService)
        {
            _productWarehouseService = productWarehouseService;
        }

        [HttpPost]
        public async Task Save(ProductWarehouseSaveDto entity)
        {
            await _productWarehouseService.Save(new ProductWarehouse { WarehouseId = entity.WarehouseId, ProductId = entity.ProductId });
        }
    }
}
