using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ShopXPress.Api.Contracts;
using ShopXPress.Api.Settings;

namespace ShopXPress.Api.Controller;

[Route("api/[controller]")]
[ApiController]
public class AuthController
{
    private readonly JwtSetting _jwtSetting;
    public AuthController(IOptions<JwtSetting> jwtSetting)
    {
        _jwtSetting = jwtSetting.Value;
    }

    [HttpPost("Login")]
    public async Task<string> Login([FromBody] LoginContract loginContract)
    {
        if (loginContract.Email == "admin@shopexpress.com" && loginContract.Password == "1234")
        {
            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, loginContract.Email),
                new Claim(ClaimTypes.Name, loginContract.Email),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSetting.Secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var jwtToken = new JwtSecurityToken(
                issuer: _jwtSetting.Issuer,
                audience: _jwtSetting.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
        return null;
    }

}
