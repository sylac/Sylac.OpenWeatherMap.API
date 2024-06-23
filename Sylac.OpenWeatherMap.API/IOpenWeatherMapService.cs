using Sylac.OpenWeatherMap.API.Models.Responses;

namespace Sylac.OpenWeatherMap.API
{
    /// <summary>
    /// Interface for the OpenWeatherMap API.
    /// </summary>
    public interface IOpenWeatherMapService
    {
        /// <summary>
        /// Get the weather information for a specific location.
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <returns></returns>
        IObservable<OneCallWeatherInfo> GetOneCallWeatherInfoAsync(decimal latitude, decimal longitude);
    }
}
