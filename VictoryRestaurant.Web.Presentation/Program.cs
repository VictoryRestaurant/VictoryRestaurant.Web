var builder = WebApplication.CreateBuilder(args);

RegisterServices(services: builder.Services);

var app = builder.Build();

Configure(app, env: builder.Environment);

app.Run();

void RegisterServices(IServiceCollection services)
{
    services.AddControllersWithViews(options =>
    {
        options.CacheProfiles.Add(key: "Caching",
            value: new CacheProfile()
            {
                Duration = 600
            });

        options.CacheProfiles.Add(key: "NoCaching",
            value: new CacheProfile()
            {
                Location = ResponseCacheLocation.None,
                NoStore = true
            });
    });

    services.AddCache();
}

void Configure(WebApplication app, IHostEnvironment env)
{
    app.UseHttpsRedirection();

    app.UseStaticFiles();

    app.MapControllers();
}