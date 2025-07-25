using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using ServiceContract;

namespace Storage.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockGatewayController: ControllerBase
    {
        private readonly IStockUseCase stockUseCase;
        public StockGatewayController(IStockUseCase stockUseCase)
        {
            this.stockUseCase = stockUseCase;
        }
        [HttpPost]
        public string Get([FromBody] string sku) 
        {
            stockUseCase.Find(sku);
            return "Bad";
        }
    }
}
