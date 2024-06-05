using ShopXPress.Api.Settings;

namespace ShopXPress.Api.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services;
    }

    public static IServiceCollection AddSettings(this IServiceCollection services, IConfiguration configuration)
    {
        return services.Configure<JwtSetting>(configuration.GetSection(JwtSetting.SECTION));
    }
}
