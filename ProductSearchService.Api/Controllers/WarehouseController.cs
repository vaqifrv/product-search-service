using Microsoft.AspNetCore.Mvc;
using ProductSearchService.Domain.Entities;
using ProductSearchService.DTO;
using ProductSearchService.DTO.Request;
using ProductSearchService.Services.Abstractions;
using System.Threading.Tasks;

namespace ProductSearchService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpPost]
        public async Task Save(WarehouseSaveDto entity)
        {
            await _warehouseService.Save(new Warehouse { Name = entity.Name, Lat = entity.Lat, Lon = entity.Lon });
        }
    }
}
