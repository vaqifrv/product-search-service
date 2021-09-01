using Microsoft.AspNetCore.Mvc;
using ProductSearchService.DTO;
using ProductSearchService.Services.Abstractions;
using System.Threading.Tasks;

namespace ProductSearchService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productservice;

        public ProductController(IProductService productservice)
        {
            _productservice = productservice;
        }

        [Route("search/{name}")]
        [HttpGet]
        public async Task<BaseResponse<SearchResultDto>> Search(string name)
        {
            return await _productservice.Search(name);
        }
    }
}
