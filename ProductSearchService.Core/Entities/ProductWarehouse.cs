using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSearchService.Domain.Entities
{
    public class ProductWarehouse
    {
        public int WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
