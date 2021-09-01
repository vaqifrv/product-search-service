using ProductSearchService.DTO;
using System;

namespace ProductSearchService.Services.Abstractions
{
    public interface IProductService
    {
        BaseResponse<SearchResultDto> Search(string name);
    }
}
