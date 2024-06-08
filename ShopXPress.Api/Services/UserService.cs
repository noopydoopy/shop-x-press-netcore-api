using ShopXPress.Api.Contracts;
using ShopXPress.Api.Entities.Database;
using ShopXPress.Api.Services.Interfaces;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using Microsoft.Extensions.Options;
using ShopXPress.Api.Settings;
using System.Text;
using ShopXPress.Api.Exceptions;
using ShopXPress.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ShopXPress.Api.Services;

public class UserService : IUserService
{
    private readonly ApplicationDBContext _dbContext;
    private readonly JwtSetting _jwtSetting;

    public UserService(ApplicationDBContext dbContext, IOptions<JwtSetting> jwtSetting)
    {
        _dbContext = dbContext;
        _jwtSetting = jwtSetting.Value;
    }

    public async Task<AuthContract> AuthenticateUser(string email, string password)
    {

    }

    public Task<List<UserContract>> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public Task<UserContract> GetUserById(int userId)
    {
        throw new NotImplementedException();
    }
}
