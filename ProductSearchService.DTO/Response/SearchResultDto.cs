using ProductSearchService.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProductSearchService.DTO.Response
{
    public class SearchResultDto
    {
        public WarehouseResultDto Warehouse { get; set; }
        public ProductResultDto Product { get; set; }
        public List<TransportType> TransportTypes { get; set; }
    }
}
