using ProductSearchService.Domain.Entities;
using ProductSearchService.DTO;
using ProductSearchService.DTO.Response;
using System;
using System.Threading.Tasks;

namespace ProductSearchService.Services.Abstractions
{
    public interface IProductService
    {
        Task<BaseResponse<SearchResultDto>> Search(string name);
        Task Save(Product entity);
    }
}
