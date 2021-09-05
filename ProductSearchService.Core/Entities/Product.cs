using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductSearchService.Domain.Entities
{
    [Table("Products")]
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public ICollection<ProductWarehouse> ProductWarehouses { get; set; }
    }
}
