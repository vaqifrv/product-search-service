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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productservice;

        public ProductController(IProductService productService)
        {
            _productservice = productService;
        }

        [HttpPost]
        public async Task Save(ProductSaveDto entity)
        {
            await _productservice.Save(new Product { Name = entity.Name });
        }

        [Route("search/{name}")]
        [HttpGet]
        public async Task<BaseResponse<SearchResultDto>> Search(string name)
        {
            return await _productservice.Search(name);
        }
    }
}
