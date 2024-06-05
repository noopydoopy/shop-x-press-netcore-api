using System.ComponentModel.DataAnnotations.Schema;

namespace ShopXPress.Api.Entities;

[Table("Product")]
public class Product : BaseEntity
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int InStock { get; set; }
    public decimal Price { get; set; }
    public int ProductCategoryId { get; set; }
    [ForeignKey(nameof(ProductCategoryId))]
    public ProductCategory ProductCategory { get; set; }
    public List<Order> Orders { get; set; }
    public List<Cart> Carts { get; set; }
}
