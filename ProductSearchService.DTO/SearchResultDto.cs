using ProductSearchService.Domain.Entities;
using System;

namespace ProductSearchService.DTO
{
    public class SearchResultDto
    {
        public Warehouse Warehouse { get; set; }
        public Product Product { get; set; }
    }
}
