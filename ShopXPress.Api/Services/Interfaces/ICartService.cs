namespace ShopXPress.Api.Services.Interfaces;

public interface ICartService
{
    Task GetUserCarts(int userId);
    Task CheckoutCart();
}
