using Microsoft.AspNetCore.Mvc;
using ProductSearchService.Domain.Entities;
using ProductSearchService.Services.Abstractions;
using System.Threading.Tasks;

namespace ProductSearchService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransportTypeController : ControllerBase
    {
        private readonly ITransportTypeService _transportTypeService;

        public TransportTypeController(ITransportTypeService transportTypeService)
        {
            _transportTypeService = transportTypeService;
        }

        [HttpPost]
        public async Task Save(TransportType entity)
        {
            await _transportTypeService.Save(entity);
        }
    }
}
