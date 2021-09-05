using ProductSearchService.Domain.Entities;
using ProductSearchService.DTO.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSearchService.DTO
{
    public static class Helpers
    {
        public static BaseResponse<SearchResultDto> NotFoundResult => new BaseResponse<SearchResultDto>(null, ResponseStatus.NotFound);
        public static BaseResponse<SearchResultDto> BadRequestResult => new BaseResponse<SearchResultDto>(null, ResponseStatus.BadRequest);

        public static BaseResponse<SearchResultDto> ErrorResult => new BaseResponse<SearchResultDto>(null, ResponseStatus.Error);

        public static BaseResponse<SearchResultDto> SuccessResult(Product item, Warehouse warehouse, List<TransportType> transportTypes) => new BaseResponse<SearchResultDto>(
                new SearchResultDto()
                {
                    Product = new ProductResultDto { Id = item.Id, Name = item.Name, Weight = item.Weight },
                    Warehouse = new WarehouseResultDto { Id = warehouse.Id, Name = warehouse.Name },
                    TransportTypes = transportTypes
                },
                ResponseStatus.Success
                );
    }
}
