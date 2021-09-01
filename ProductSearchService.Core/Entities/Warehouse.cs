using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSearchService.Domain.Entities
{
    public class Warehouse: BaseEntity
    {
        public string Name { get; set; }
        public IList<ProductWarehouse> ProductWarehouses { get; set; }
    }
}
