using DTO;
using Microsoft.AspNetCore.Mvc;
using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddProductController: ControllerBase
    {
        private readonly IAddProductUseCase addProductUseCase;
        public AddProductController(IAddProductUseCase addProductUseCase)
        {
            this.addProductUseCase = addProductUseCase;
        }
        [HttpPost]
        public string Addproducts ([FromBody]ProductRequestDto productRequestDto)
        {
            addProductUseCase.AddProductCase(productRequestDto);
            return "Ok";
        }
    }
}
