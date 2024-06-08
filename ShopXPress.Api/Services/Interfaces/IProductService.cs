using ShopXPress.Api.Contracts;

namespace ShopXPress.Api.Services.Interfaces;

public interface IProductService
{
    Task<List<ProductContract>> GetTopListProducts(int maxRecord);
    Task<List<ProductContract>> GetProducts();
    Task<ProductContract> GetProductById(int productId);
    Task CreateProduct(ProductContract product);
    Task UpdateProduct(int productId, ProductContract product);
    Task DeleteProduct(int productId);
}
