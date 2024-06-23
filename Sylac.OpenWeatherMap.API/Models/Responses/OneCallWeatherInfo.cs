using Sylac.OpenWeatherMap.API.Models.Weather;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Models.Responses
{
    /// <summary>
    /// The response object for the One Call API
    /// </summary>
    public sealed record OneCallWeatherInfo
    {
        /// <summary>
        /// The latitude of the location
        /// </summary>
        [JsonPropertyName("lat")]
        public double Latitude { get; init; }

        /// <summary>
        /// The longitude of the location
        /// </summary>
        [JsonPropertyName("lon")]
        public double Longitude { get; init; }

        /// <summary>
        /// The timezone name for the requested location
        /// </summary>
        [JsonPropertyName("timezone")]
        public string Timezone { get; init; } = string.Empty;

        /// <summary>
        /// The current timezone offset in seconds
        /// </summary>
        [JsonPropertyName("timezone_offset")]
        public int TimezoneOffset { get; init; }

        /// <summary>
        /// The current weather information
        /// </summary>
        [JsonPropertyName("current")]
        public CurrentWeather CurrentWeather { get; init; } = new CurrentWeather();

        /// <summary>
        /// The minute weather forecast
        /// </summary>
        [JsonPropertyName("minutely")]
        public MinuteWeatherForecast[] MinuteWeatherForecasts { get; init; } = [];

        /// <summary>
        /// The hourly weather forecast
        /// </summary>
        [JsonPropertyName("hourly")]
        public HourlyWeatherForecast[] HourlyWeatherForecasts { get; init; } = [];

        /// <summary>
        /// The daily weather forecast
        /// </summary>
        [JsonPropertyName("daily")]
        public DailyWeatherForecast[] DailyWeatherForecasts { get; init; } = [];

        /// <summary>
        /// National weather alerts data from major national weather warning systems
        /// </summary>
        [JsonPropertyName("alerts")]
        public WeatherAlert[] Alerts { get; init; } = [];
    }
}
