using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSearchService.DTO.Response
{
    public class ProductResultDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
    }
}
