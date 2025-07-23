using DTO;

namespace ServiceContract
{
    public interface IAddProductUseCase
    {
        void AddProductCase(ProductRequestDto productRequestDto);
    }
}
