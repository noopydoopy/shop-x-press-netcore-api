using ShopXPress.Api.Contracts;

namespace ShopXPress.Api.Services.Interfaces;

public interface IProductService
{
    Task<List<ProductContract>> GetProducts();
    Task<ProductContract> GetProductById();
    Task CreateProduct();
    Task UpdateProduct(int productId);
    Task DeleteProduct(int productId);
}
