using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Refit;
using Sylac.OpenWeatherMap.API.Abstractions;
using Sylac.OpenWeatherMap.API.Options;

namespace Sylac.OpenWeatherMap.API
{
    /// <summary>
    /// Dependency injection for the OpenWeatherMap API.
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Add the OpenWeatherMap API to the service collection.
        /// </summary>
        /// <param name="services"> The service collection. </param>
        /// <param name="configure"> The configuration for the OpenWeatherMap API. </param>
        /// <returns> The service collection. </returns>
        public static IServiceCollection AddOpenWeatherMap(this IServiceCollection services, Action<OpenWeatherMapOptions> configure)
        {
            return services
                .Configure(configure)
                .AddTransient(provider =>
                {
                    var options = provider.GetRequiredService<IOptions<OpenWeatherMapOptions>>().Value;
                    return RestService.For<IOpenWeatherMapRestAPI>(options.BaseUrl);
                })
                .AddTransient<IOpenWeatherMapService, OpenWeatherMapService>();
        }
    }
}
