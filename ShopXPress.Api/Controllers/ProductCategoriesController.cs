using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopXPress.Api.Controller;

namespace ShopXPress.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoriesController : AuthorizedControllerBase
    {
    }
}
