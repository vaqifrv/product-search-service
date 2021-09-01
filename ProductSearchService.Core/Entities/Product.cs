﻿using System;
using System.Collections.Generic;

namespace ProductSearchService.Domain.Entities
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }

        public IList<ProductWarehouse> ProductWarehouses { get; set; }
    }
}
