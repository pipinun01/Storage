using RepositoryContract;
using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class StockUseCase: IStockUseCase
    {
        private readonly IStockGateway stockGateway;
        public StockUseCase(IStockGateway stockGateway)
        {
            this.stockGateway = stockGateway;
        }
        public void Find(string sku)
        {
            stockGateway.find(sku);
        }
    }
}
