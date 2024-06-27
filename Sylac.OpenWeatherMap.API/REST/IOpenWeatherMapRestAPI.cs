using Refit;
using Sylac.OpenWeatherMap.API.Models.Responses;

namespace Sylac.OpenWeatherMap.API.Abstractions
{
    /// <summary>
    /// Represents the OpenWeatherMap REST API.
    /// </summary>
    public interface IOpenWeatherMapRestAPI
    {
        /// <summary>
        /// Gets the current weather information for the specified geo coordinates.
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> Your unique API key from OpenWeatherMap. </param>
        /// <param name="exclude"> Optional. Exclude some parts of the response. </param>
        /// <param name="units"> Optional. Units of measurement. </param>
        /// <param name="language"> Optional. Language of the response. </param>
        /// <returns> The current weather information. </returns>
        [Get("/data/3.0/onecall")]
        IObservable<OneCallWeatherInfo> GetOneCallWeatherInfoAsync(
            [AliasAs("lat")] decimal latitude,
            [AliasAs("lon")] decimal longitude,
            [AliasAs("appid")] string apiKey,
            [AliasAs("exclude")] string? exclude = null,
            [AliasAs("units")] string? units = null,
            [AliasAs("lang")] string? language = null);
    }
}
