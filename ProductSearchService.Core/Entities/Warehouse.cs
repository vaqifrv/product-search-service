using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductSearchService.Domain.Entities
{
    public class Warehouse: BaseEntity
    {
        public string Name { get; set; }
        public int Lat { get; set; }
        public int Long { get; set; }

        [NotMapped]
        public Warehouse NextClosest { get; set; }
        [NotMapped]
        public double DistanceByClient { get; set; }

        public IList<ProductWarehouse> ProductWarehouses { get; set; }
    }
}
