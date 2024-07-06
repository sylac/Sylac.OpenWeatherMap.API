using Sylac.OpenWeatherMap.API.Converters;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Models.Weather
{
    /// <summary>
    /// Weather forecast for a specific minute
    /// </summary>
    public sealed record MinuteWeatherForecast
    {
        /// <summary>
        /// Time of the forecasted data, Unix, UTC
        /// </summary>
        [JsonPropertyName("dt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DateTime { get; init; }

        /// <summary>
        /// Precipitation volume
        /// </summary>
        [JsonPropertyName("precipitation")]
        public double Precipitation { get; init; }
    }
}
