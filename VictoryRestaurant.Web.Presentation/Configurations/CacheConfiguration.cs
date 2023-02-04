namespace VictoryRestaurant.Web.Presentation.Configurations;

internal static class CacheConfiguration
{
    public static void AddCache(this IServiceCollection services)
    {
        services.AddMemoryCache();

        services.AddSingleton<IMemoryCache, MemoryCache>();
    }
}