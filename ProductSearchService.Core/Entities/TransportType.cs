using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductSearchService.Domain.Entities
{
    [Table("TransportTypes")]
    public class TransportType : BaseEntity
    {
        public string Name { get; set; }
        public double MinWeight { get; set; }
        public double MaxWeight { get; set; }
        public double MinDistance { get; set; }
        public double MaxDistance { get; set; }
    }
}
