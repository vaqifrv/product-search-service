using System;

namespace ProductSearchService.DTO.Response
{
    public class SearchResultDto
    {
        public WarehouseResultDto Warehouse { get; set; }
        public ProductResultDto Product { get; set; }
    }
}
