using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Warehouse
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string? Location { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<StockOperation> FromStockOperations { get; set; } = new List<StockOperation>();
        public ICollection<StockOperation> ToStockOperations { get; set; } = new List<StockOperation>();
    }

}
