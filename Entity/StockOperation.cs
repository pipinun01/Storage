using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class StockOperation
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public int? FromWarehouseId { get; set; }
        public int? ToWarehouseId { get; set; }

        public int Quantity { get; set; }
        public string OperationType { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public Product Product { get; set; } = null!;
        public Warehouse? FromWarehouse { get; set; }
        public Warehouse? ToWarehouse { get; set; }
    }

}
