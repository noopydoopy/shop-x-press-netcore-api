using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ShopXPress.Api.Controller;

[Authorize]
[ApiController]
public class AuthorizedControllerBase : ControllerBase
{

}
