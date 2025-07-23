using DTO;
using Entity;
using RepositoryContract;
using ServiceContract;

namespace Service
{
    public class AddProductUseCase: IAddProductUseCase
    {
        private readonly IAddProduct addProduct;
        public AddProductUseCase(IAddProduct addProduct)
        {
            this.addProduct = addProduct;
        }
        public void AddProductCase(ProductRequestDto productRequestDto)
        {
            var product = new Product
            {
                Name = productRequestDto.Name,
                SKU = productRequestDto.SKU,
                CreatedAt = productRequestDto.CreatedAt,
                Price = productRequestDto.Price,
                Description = productRequestDto.Description,
            };
            addProduct.Add(product);
        }
    }
}
