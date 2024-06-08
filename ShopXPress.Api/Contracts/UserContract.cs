using ShopXPress.Api.Contracts.Attributes;
using ShopXPress.Api.Entities;
using ShopXPress.Api.Entities.Enums;

namespace ShopXPress.Api.Contracts;

[MapFrom(typeof(User))]
public class UserContract
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public UserType UserType { get; set; }
}
