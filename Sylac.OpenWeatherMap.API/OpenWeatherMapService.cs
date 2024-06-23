using Microsoft.Extensions.Options;
using Sylac.OpenWeatherMap.API.Abstractions;
using Sylac.OpenWeatherMap.API.Models.Responses;
using Sylac.OpenWeatherMap.API.Options;
using System.Reactive.Linq;

namespace Sylac.OpenWeatherMap.API
{
    /// <summary>
    /// Implementation of the OpenWeatherMap API.
    /// </summary>
    /// <param name="options"> The options for the OpenWeatherMap API. </param>
    /// <param name="openWeatherMapRestAPI"> The REST API for the OpenWeatherMap API. </param>
    public sealed class OpenWeatherMapService(
        IOptions<OpenWeatherMapOptions> options,
        IOpenWeatherMapRestAPI openWeatherMapRestAPI) : IOpenWeatherMapService
    {
        private readonly IOptions<OpenWeatherMapOptions> options = options;
        private readonly IOpenWeatherMapRestAPI openWeatherMapRest = openWeatherMapRestAPI;

        /// <summary>
        /// Get the weather information for a specific location.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        public IObservable<OneCallWeatherInfo> GetOneCallWeatherInfoAsync(decimal latitude, decimal longitude)
        {
            if (latitude < -90 || latitude > 90)
            {
                return Observable.Throw<OneCallWeatherInfo>(new ArgumentOutOfRangeException(nameof(latitude), "Latitude must be between -90 and 90."));
            }

            if (longitude < -180 || longitude > 180)
            {
                return Observable.Throw<OneCallWeatherInfo>(new ArgumentOutOfRangeException(nameof(longitude), "Longitude must be between -180 and 180."));
            }

            return openWeatherMapRest.GetOneCallWeatherInfoAsync(
                latitude,
                longitude,
                options.Value.ApiKey,
                units: options.Value.UnitSystem.ToQueryString(),
                language: options.Value.Language.ToQueryString());
        }
    }
}
