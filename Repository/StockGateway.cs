using Entity;
using RepositoryContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StockGateway: IStockGateway
    {
        private readonly StorageContext _storageContext;
        public StockGateway(StorageContext storageContext)
        {
            _storageContext = storageContext;
        }
        public Product find (string sku)
        {
            var res = _storageContext.Product.FirstOrDefault(f => f.SKU == sku);

            return res;
        }
    }
}
