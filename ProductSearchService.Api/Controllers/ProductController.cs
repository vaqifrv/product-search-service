using Microsoft.AspNetCore.Mvc;
using ProductSearchService.DTO;
using ProductSearchService.Services.Abstractions;

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
        public BaseResponse<SearchResultDto> Search(string name)
        {
            return _productservice.Search(name);
        }
    }
}
